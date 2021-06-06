﻿using RSBot.Core.Client;
using RSBot.Core.Client.ReferenceObjects;
using RSBot.Core.Components;
using RSBot.Core.Network;
using RSBot.Core.Objects;
using RSBot.Core.Objects.Party;
using RSBot.Core.Objects.Spawn;

namespace RSBot.Core
{
    public class Game
    {
        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        public static ushort Port { get; private set; }

        /// <summary>
        /// Gets or sets the Media.pk2 reader.
        /// </summary>
        /// <value>
        /// The PK2 reader.
        /// </value>
        public static CacheController MediaPk2 { get; set; }

        /// <summary>
        /// Gets or sets the reference manager
        /// </summary>
        /// <value>
        /// The reference manager
        /// </value>
        public static ReferenceManager ReferenceManager { get; set; }

        /// <summary>
        /// Gets the character.
        /// </summary>
        /// <value>
        /// The character.
        /// </value>
        public static Player Player { get; internal set; }

        /// <summary>
        /// Gets or sets the selected entity.
        /// </summary>
        /// <value>
        /// The selected entity.
        /// </value>
        public static Entity SelectedEntity { get; internal set; }

        /// <summary>
        /// Gets the last selected entity.
        /// </summary>
        /// <value>
        /// The last selected entity.
        /// </value>
        public static Entity LastSelectedEntity { get; internal set; }

        /// <summary>
        /// Gets or sets the spawn information.
        /// </summary>
        /// <value>
        /// The spawn information.
        /// </value>
        internal static SpawnPacketInfo SpawnInfo { get; set; }

        /// <summary>
        /// Gets or sets the character packet.
        /// </summary>
        /// <value>
        /// The character packet.
        /// </value>
        internal static Packet CharacterPacket { get; set; }

        /// <summary>
        /// Gets or sets the spawns.
        /// </summary>
        /// <value>
        /// The spawns.
        /// </value>
        public static Spawns Spawns { get; internal set; }

        /// <summary>
        /// Gets or sets the party.
        /// </summary>
        /// <value>
        /// The party.
        /// </value>
        public static Party Party { get; internal set; }

        /// <summary>
        /// The acceptance request
        /// </summary>
        public static AcceptanceRequest AcceptanceRequest;

        /// <summary>
        /// Gets a value indicating whether this <see cref="Game"/> is clientless.
        /// </summary>
        /// <value>
        ///   <c>true</c> if clientless; otherwise, <c>false</c>.
        /// </value>
        public static bool Clientless { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Game"/> is started.
        /// </summary>
        /// <value><c>true</c> if started; otherwise, <c>false</c>.</value>
        public static bool Started { get; set; }

        /// <summary>
        /// Gets or sets the nearby teleports.
        /// </summary>
        public static RefTeleport[] NearbyTeleporters { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Game"/> is ready.
        /// </summary>
        /// <value>
        ///   <c>true</c> if ready; otherwise, <c>false</c>.
        /// </value>
        public static bool Ready { get; internal set; }

        /// <summary>
        /// Starts the game.
        /// </summary>
        public static void Start()
        {
            Started = false;

            if (Kernel.Bot.Running)
                Kernel.Bot.Stop();

            if (Kernel.Proxy != null)
                Kernel.Proxy.Shutdown();

            var divisionIndex = GlobalConfig.Get<int>("RSBot.DivisionIndex");
            var severIndex = GlobalConfig.Get<int>("RSBot.GatewayIndex");

            Port = NetworkUtilities.GetFreePort(1500, 2000, 1);

            Kernel.Proxy = new Proxy();
            Kernel.Proxy.Start(Port, ReferenceManager.DivisionInfo.Divisions[divisionIndex].GatewayServers[severIndex], ReferenceManager.GatewayInfo.Port);

            Started = true;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public static void Initialize()
        {
            ReferenceManager = new ReferenceManager();
            Party = new Party();

            SkillManager.Initialize();
            ShoppingManager.Initialize();
            PickupManager.Initialize();
            CollisionManager.Initialize();
            ClientlessManager.Initialize();
        }
    }
}