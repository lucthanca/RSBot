﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using SilkroadSecurityApi;
using System.Threading;

class Program
{
    class Context
    {
        public Socket Socket { get; set; }
        public Security Security { get; set; }
        public TransferBuffer Buffer { get; set; }
        public Security RelaySecurity { get; set; }

        public Context()
        {
            Socket = null;
            Security = new Security();
            RelaySecurity = null;
            Buffer = new TransferBuffer(8192);
        }
    }

    static void Main(string[] args)
    {
        try
        {
            String local_host;
            Int32 local_port;

            String remote_host;
            Int32 remote_port;

            local_host = args[0];
            local_port = Int32.Parse(args[1]);

            remote_host = args[2];
            remote_port = Int32.Parse(args[3]);

            Context local_context = new Context();
            local_context.Security.GenerateSecurity(true, true, true);

            Context remote_context = new Context();

            remote_context.RelaySecurity = local_context.Security;
            local_context.RelaySecurity = remote_context.Security;

            List<Context> contexts = new List<Context>();
            contexts.Add(local_context);
            contexts.Add(remote_context);

            using (Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                server.Bind(new IPEndPoint(IPAddress.Parse(local_host), local_port));
                server.Listen(1);

                local_context.Socket = server.Accept();
            }

            using (local_context.Socket)
            {
                using (remote_context.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    remote_context.Socket.Connect(remote_host, remote_port);
                    while (true)
                    {
                        if (Console.KeyAvailable == true) // Application event processing
                        {
                            ConsoleKeyInfo key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Escape)
                            {
                                break;
                            }
                        }

                        foreach (Context context in contexts) // Network input event processing
                        {
                            if (context.Socket.Poll(0, SelectMode.SelectRead))
                            {
                                int count = context.Socket.Receive(context.Buffer.Buffer);
                                if (count == 0)
                                {
                                    throw new Exception("The remote connection has been lost.");
                                }
                                context.Security.Recv(context.Buffer.Buffer, 0, count);
                            }
                        }

                        foreach (Context context in contexts) // Logic event processing
                        {
                            List<Packet> packets = context.Security.TransferIncoming();
                            if (packets != null)
                            {
                                foreach (Packet packet in packets)
                                {
                                    if (packet.Opcode == 0x5000 || packet.Opcode == 0x9000) // ignore always
                                    {
                                    }
                                    else if (packet.Opcode == 0x2001)
                                    {
                                        if (context == remote_context) // ignore local to proxy only
                                        {
                                            context.RelaySecurity.Send(packet); // proxy to remote is handled by API
                                        }
                                    }
                                    else if (packet.Opcode == 0xA102)
                                    {
                                        byte result = packet.ReadUInt8();
                                        if (result == 1)
                                        {
                                            uint id = packet.ReadUInt32();
                                            string ip = packet.ReadAscii();
                                            ushort port = packet.ReadUInt16();

                                            using (Process process = new Process())
                                            {
                                                process.StartInfo.UseShellExecute = false;
                                                process.StartInfo.FileName = System.Reflection.Assembly.GetExecutingAssembly().Location;
                                                process.StartInfo.Arguments = local_host + " " + (local_port + 1).ToString() + " " + ip + " " + port.ToString();
                                                if (!process.Start())
                                                {
                                                    throw new Exception("Could not start the AgentServer Proxy process.");
                                                }
                                            }

                                            Thread.Sleep(250); // Should be enough time, if not, increase, but too long and C9 timeout results

                                            Packet new_packet = new Packet(0xA102, true);
                                            new_packet.WriteUInt8(result);
                                            new_packet.WriteUInt32(id);
                                            new_packet.WriteAscii(local_host);
                                            new_packet.WriteUInt16(local_port + 1);

                                            context.RelaySecurity.Send(new_packet);
                                        }
                                    }
                                    else
                                    {
                                        context.RelaySecurity.Send(packet);
                                    }
                                }
                            }
                        }

                        foreach (Context context in contexts) // Network output event processing
                        {
                            if (context.Socket.Poll(0, SelectMode.SelectWrite))
                            {
                                List<KeyValuePair<TransferBuffer, Packet>> buffers = context.Security.TransferOutgoing();
                                if (buffers != null)
                                {
                                    foreach (KeyValuePair<TransferBuffer, Packet> kvp in buffers)
                                    {
                                        TransferBuffer buffer = kvp.Key;
                                        Packet packet = kvp.Value;

                                        byte[] packet_bytes = packet.GetBytes();
                                        Console.WriteLine("[{0}][{1:X4}][{2} bytes]{3}{4}{6}{5}{6}", context == local_context ? "S->C" : "C->S", packet.Opcode, packet_bytes.Length, packet.Encrypted ? "[Encrypted]" : "", packet.Massive ? "[Massive]" : "", Utility.HexDump(packet_bytes), Environment.NewLine);

                                        while (true)
                                        {
                                            int count = context.Socket.Send(buffer.Buffer, buffer.Offset, buffer.Size, SocketFlags.None);
                                            buffer.Offset += count;
                                            if (buffer.Offset == buffer.Size)
                                            {
                                                break;
                                            }
                                            Thread.Sleep(1);
                                        }
                                    }
                                }
                            }
                        }

                        Thread.Sleep(1); // Cycle complete, prevent 100% CPU usage
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}