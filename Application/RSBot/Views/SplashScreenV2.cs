using RSBot.Core;
using RSBot.Core.Components;
using System;
using System.Globalization;
using System.Windows.Forms;
using Vadu.AlphaForm;
using RSBot.Core.Event;
using RSBot.Views.Dialog;
using SDUI.Controls;
using System.IO;

namespace RSBot.Views
{
    public partial class SplashScreenV2 : Form
    {
        private readonly MainLegacy _mainForm;

        public SplashScreenV2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _mainForm = new();

            // Enable console
            // AllocConsole();

            var ci = CultureInfo.InstalledUICulture;
            Kernel.Language = ci.Name.Replace("-", "_");
            LanguageManager.LoadLanguage("RSBot", Kernel.Language);
            referenceDataLoader.RunWorkerCompleted += ReferenceDataLoaderCompleted;
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the Initializer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
        private void ReferenceDataLoaderCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            _mainForm.Show();
            _mainForm.RefreshTheme(false);

            Hide();
        }

        private void SplashScreenV2_Load(object sender, EventArgs e)
        {
            Initialize();
            referenceDataLoader.RunWorkerAsync();
        }


        private void Initialize()
        {
            InitializeProfileConfig();
            lbLoadingState.Text = LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingLanguage", "Initializing Language...");
            LanguageManager.Translate(_mainForm, Kernel.Language);
            InitializeGameClient();
            InitializeBot();
            InitializeBotPlugins();
            InitializeBotTypes();
            lbLoadingState.Text = LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingBotCommands", "Initializing Bot Commands...");
            CommandManager.Initialize();
            InitializeMap();
        }
        /// <summary>
        /// Loads the profile configuration.
        /// </summary>
        private void InitializeProfileConfig()
        {
            lbLoadingState.Text = LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingProfileConfig", "Initializing Profile Config...");

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
            }
            catch (Exception ex)
            {
                File.WriteAllText(Kernel.BasePath + "\\critical.log", $"[Loading Profile Config] Failed: \n{ex.Message} at {ex.StackTrace}");
                throw new Exception(LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingProfileConfigFailed", "Initialize Profile config failed! Please try again!"));
            }
        }

        private void InitializeGameClient()
        {
            lbLoadingState.Text = LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingGameClient", "Initializing Game Client...");
            if (!GlobalConfig.Exists("RSBot.SilkroadDirectory") || !File.Exists(GlobalConfig.Get<string>("RSBot.SilkroadDirectory") + "\\media.pk2"))
            {
                var dialog = new OpenFileDialog
                {
                    Title = LanguageManager.GetLang("OpenFileDialogTitle"),
                    Filter = "Executable (*.exe)|*.exe",
                    FileName = "sro_client.exe"
                };

                var result = dialog.ShowDialog(this);

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

        private void InitializeBot()
        {
            lbLoadingState.Text = LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingBotCore", "Initializing Bot Core...");
            Kernel.Initialize();
            Game.Initialize();
        }

        private void InitializeBotPlugins()
        {
            lbLoadingState.Text = LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingBotPlugins", "Initializing Bot Plugins...");
            //---- Load Plugins ----
            if (!Kernel.PluginManager.LoadAssemblies())
            {
                MessageBox.Show(@"Failed to load plugins. Process canceled!", @"Initialize Application - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void InitializeBotTypes()
        {
            lbLoadingState.Text = LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingBotTypes", "Initializing Bot Types...");
            if (!Kernel.BotbaseManager.LoadAssemblies())
                MessageBox.Show(@"Failed to load botbases. Process canceled!", @"Initialize Application - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Initializes the map.
        /// </summary>
        private void InitializeMap()
        {
            lbLoadingState.Text = LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingBotMap", "Initializing Map...");
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

        /// <summary>
        /// Handles the DoWork event of the referenceDataLoader control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
        private void referenceDataLoader_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!Game.InitializeArchiveFiles())
            {
                MessageBox.Show(@"Failed to load game data. Boot process canceled!", @"Initialize Application - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Game.ReferenceManager.Load(GlobalConfig.Get<int>("RSBot.TranslationIndex", 9));
        }
    }
}
