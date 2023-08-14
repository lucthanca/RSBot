
using RSBot.Core.Components;
using RSBot.Core;
using RSBot.Views.Dialog;
using System.Windows.Forms;
using System.IO;
using System;
using RSBot.Core.Event;
using RSBot.Views;
using SDUI.Controls;

namespace RSBot
{
    public enum BotInitState : byte
    {
        INIT,
        INIT_PROFILE_CONFIG,
        INIT_LANGuAGE,
        INIT_GAME_CLIENT,
        INIT_BOT_CORE,
        INIT_BOT_PLUGINS,
        INIT_BOT_TYPES,
        INIT_BOT_COMMANDS,
        INIT_BOT_MAP,
    }
    public class BotManager
    {
        private static BotInitState _loadingStep = BotInitState.INIT;

        private static MainLegacy _mainForm;

        public static MainLegacy MainForm { set { _mainForm = value; } }

        private static SplashScreenV2 _splashScreen;

        public static SplashScreenV2 SplashScreen { set { _splashScreen = value; } }

        public static BotInitState CurrentStep { get { return _loadingStep; } }

        public static void Initialize()
        {
            InitializeProfileConfig();

            _loadingStep = BotInitState.INIT_LANGuAGE;
            EventManager.FireEvent("RSBot.InitializeBot");
            LanguageManager.Translate(_mainForm, Kernel.Language);

            InitializeGameClient();
            InitializeBot();
            InitializeBotPlugins();
            InitializeBotTypes();

            _loadingStep = BotInitState.INIT_LANGuAGE;
            EventManager.FireEvent("RSBot.InitializeBot");
            CommandManager.Initialize();

            InitializeMap();

            EventManager.FireEvent("RSBot.InitializeBotComplete");
        }
        /// <summary>
        /// Loads the profile configuration.
        /// </summary>
        private static void InitializeProfileConfig()
        {
            _loadingStep = BotInitState.INIT_PROFILE_CONFIG;
            EventManager.FireEvent("RSBot.InitializeBot");

            try
            {
                if (!ProfileManager.IsProfileLoadedByArgs)
                {
                    if (ProfileManager.ShowProfileDialog)
                    {
                        var dialog = new ProfileSelectionDialog();
                        if (dialog.ShowDialog() != DialogResult.Cancel)
                            ProfileManager.SetSelectedProfile(dialog.SelectedProfile);
                        else
                            return;
                    }
                    else //Load selected profile without dialog
                    {
                        var selectedProfile = ProfileManager.SelectedProfile;
                        var profilePath = ProfileManager.GetProfileFile(selectedProfile);

                        //Configured profile could not be found. Fallback to default profile
                        if (!string.IsNullOrEmpty(selectedProfile) && !File.Exists(profilePath))
                            selectedProfile = "Default";

                        ProfileManager.SetSelectedProfile(selectedProfile);
                    }
                }

                GlobalConfig.Load();
                Log.Notify($"Loaded profile {ProfileManager.SelectedProfile}");

                Kernel.Language = GlobalConfig.Get("RSBot.Language", "en_US");
            } catch (Exception ex)
            {
                File.WriteAllText(Kernel.BasePath + "\\critical.log", $"[Loading Profile Config] Failed: \n{ex.Message} at {ex.StackTrace}");
                throw new Exception(LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingProfileConfigFailed", "Initialize Profile config failed! Please try again!"));
            }
        }

        private static void InitializeGameClient()
        {
            _loadingStep = BotInitState.INIT_PROFILE_CONFIG;
            EventManager.FireEvent("RSBot.InitializeBot");
            if (!GlobalConfig.Exists("RSBot.SilkroadDirectory") || !File.Exists(GlobalConfig.Get<string>("RSBot.SilkroadDirectory") + "\\media.pk2"))
            {
                var dialog = new OpenFileDialog
                {
                    Title = LanguageManager.GetLang("OpenFileDialogTitle"),
                    Filter = "Executable (*.exe)|*.exe",
                    FileName = "sro_client.exe"
                };

                var result = dialog.ShowDialog(_splashScreen);

                var silkroadDirectory = Path.GetDirectoryName(dialog.FileName);

                if (result == DialogResult.OK && File.Exists(Path.Combine(silkroadDirectory, "media.pk2")))
                {
                    GlobalConfig.Set("RSBot.SilkroadDirectory", silkroadDirectory);
                    GlobalConfig.Set("RSBot.SilkroadExecutable", Path.GetFileName(dialog.FileName));

                    var title = LanguageManager.GetLang("ClientTypeInputDialogTitle");
                    var content = LanguageManager.GetLang("ClientTypeInputDialogContent");

                    var clientTypeDialog = new InputDialog(title, title, content, InputDialog.InputType.Combobox);
                    clientTypeDialog.ShowInTaskbar = true;
                    clientTypeDialog.StartPosition = FormStartPosition.CenterScreen;
                    clientTypeDialog.Selector.Items.AddRange(Enum.GetNames(typeof(GameClientType)));
                    clientTypeDialog.Selector.SelectedIndex = 2;
                    clientTypeDialog.TopMost = true;
                    clientTypeDialog.StartPosition = FormStartPosition.CenterScreen;

                    if (clientTypeDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (Enum.TryParse<GameClientType>(clientTypeDialog.Value.ToString(), out var clientType))
                        {
                            GlobalConfig.Set("RSBot.Game.ClientType", clientType);
                        }
                    }
                    else
                    {
                        MessageBox.Show(LanguageManager.GetLang("ClientTypeNotSelected"));
                        GlobalConfig.Set("RSBot.Game.ClientType", GameClientType.Vietnam);
                    }
                }
                else
                {
                    MessageBox.Show(LanguageManager.GetLang("SelectSroDirWarn"));
                    Environment.Exit(0);
                }
            }
        }

        private static void InitializeBot()
        {
            _loadingStep = BotInitState.INIT_BOT_CORE;
            EventManager.FireEvent("RSBot.InitializeBot");
            Kernel.Initialize();
            Game.Initialize();
        }

        private static void InitializeBotPlugins()
        {
            _loadingStep = BotInitState.INIT_BOT_PLUGINS;
            EventManager.FireEvent("RSBot.InitializeBot");
            //---- Load Plugins ----
            if (!Kernel.PluginManager.LoadAssemblies())
            {
                MessageBox.Show(@"Failed to load plugins. Process canceled!", @"Initialize Application - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private static void InitializeBotTypes()
        {
            _loadingStep = BotInitState.INIT_BOT_TYPES;
            EventManager.FireEvent("RSBot.InitializeBot");
            if (!Kernel.BotbaseManager.LoadAssemblies())
                MessageBox.Show(@"Failed to load botbases. Process canceled!", @"Initialize Application - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Initializes the map.
        /// </summary>
        private static void InitializeMap()
        {
            _loadingStep = BotInitState.INIT_BOT_MAP;
            EventManager.FireEvent("RSBot.InitializeBot");
            //---- Load Map ----
            var mapFile = Path.Combine(Kernel.BasePath, "Data", "Game", "map.rsc");

            if (!CollisionManager.Enabled)
            {
                Log.Warn("[Collision] Collision detection has been deactivated by the user!");
            }

            if (!File.Exists(mapFile))
            {
                Log.Error($"[Collisions] Directory {mapFile} not found!");

                return;
            }

            CollisionManager.Initialize();
        }
    }
}
