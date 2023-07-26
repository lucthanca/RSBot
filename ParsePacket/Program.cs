using System;
using System.IO;
using System.Text;

public class Program
{
    public static void Main()
    {
        // Hex code in string format
        string hexCode = "0100000055000000425CED00486918323044796301C2647B9B44BCE701F42A00000005405CED00";

        // Convert the hex string to a byte array
        byte[] byteArray = ConvertHexStringToByteArray(hexCode);

        // Create a MemoryStream from the byte array
        using (MemoryStream memoryStream = new MemoryStream(byteArray))
        {
            // Initialize BinaryReader with the MemoryStream
            using (BinaryReader reader = new BinaryReader(memoryStream))
            {
                // Do whatever you need with the read data
                Console.WriteLine("ref Type: " + reader.ReadUInt32());
                Console.WriteLine("Amount: " + reader.ReadUInt32());
                Console.WriteLine("UniqueId: " + reader.ReadUInt32());
                Console.WriteLine("Region: " + reader.ReadUInt16());
                Console.WriteLine("xOffset: " + reader.ReadSingle());
                Console.WriteLine("yOffset: " + reader.ReadSingle());
                Console.WriteLine("zOffset: " + reader.ReadSingle());
                Console.WriteLine("Angle: " + reader.ReadInt16());
                Console.WriteLine("Has Owner: " + reader.ReadBoolean());
                Console.WriteLine("Owner JID: " + reader.ReadUInt32());
            }
        }
    }

    // Helper function to convert hex string to byte array
    public static byte[] ConvertHexStringToByteArray(string hexString)
    {
        int numberChars = hexString.Length;
        byte[] bytes = new byte[numberChars / 2];
        for (int i = 0; i < numberChars; i += 2)
            bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
        return bytes;
    }
}