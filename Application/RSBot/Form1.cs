using RSBot.Core.Components;
using RSBot.Core;
using System;
using System.IO;
using System.Windows.Forms;
using Vadu.AlphaForm;
using RSBot.Views.Dialog;
using SDUI.Controls;
using RSBot.Views;

namespace RSBot
{
    public partial class Form1 : AlphaForm
    {
        private byte _completed = 0;

        private MainLegacy _mainForm;

        public byte Completed { get => _completed; }

        public MainLegacy MainForm { set => _mainForm = value; }

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            // labelVersion.Text = Program.AssemblyVersion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateLayeredBackground();
            referenceDataLoader.RunWorkerAsync();
        }
        /// <summary>
        /// Loads the profile configuration.
        /// </summary>
        private bool LoadProfileConfig()
        {
            if (!ProfileManager.IsProfileLoadedByArgs)
            {
                if (ProfileManager.ShowProfileDialog)
                {
                    var dialog = new ProfileSelectionDialog();
                    if (dialog.ShowDialog() != DialogResult.Cancel)
                        ProfileManager.SetSelectedProfile(dialog.SelectedProfile);
                    else
                        return false;
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

            return true;
        }

        /// <summary>
        /// Initializes the map.
        /// </summary>
        private void InitializeMap()
        {
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
            referenceDataLoader.ReportProgress(7);
            if (!LoadProfileConfig())
            {
                Environment.Exit(0);
                return;
            }
            referenceDataLoader.ReportProgress(10);
            Kernel.Language = GlobalConfig.Get("RSBot.Language", "en_US");

            referenceDataLoader.ReportProgress(15);
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

            referenceDataLoader.ReportProgress(35);
            Kernel.Initialize();
            Game.Initialize();

            referenceDataLoader.ReportProgress(50);
            CommandManager.Initialize();

            referenceDataLoader.ReportProgress(66);
            InitializeMap();

            referenceDataLoader.ReportProgress(80);
            if (!Game.InitializeArchiveFiles())
            {
                // MessageBox.Show(@"Failed to load game data. Boot process canceled!", @"Initialize Application - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            referenceDataLoader.ReportProgress(83);
            Game.ReferenceManager.Load(GlobalConfig.Get<int>("RSBot.TranslationIndex", 9));
        }

        private void ReferenceDataLoaderProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            string stateString = $"[{e.ProgressPercentage}%] ";
            if (e.ProgressPercentage == 7)
            {
                stateString += LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingProfileConfig", "Initializing Profile Config..."); ;
            }
            else if (e.ProgressPercentage == 10)
            {
                stateString += LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingLanguage", "Initializing Language...");
            }
            else if (e.ProgressPercentage == 15)
            {
                stateString += LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingGameClient", "Initializing Game Client...");
            }
            else if (e.ProgressPercentage == 35)
            {
                stateString += LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingBotCore", "Initializing Bot Core...");
            }
            else if (e.ProgressPercentage == 50)
            {
                stateString += LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingCommand", "Initializing Command...");
            } else if (e.ProgressPercentage == 66)
            {
                stateString += LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingBotMap", "Initializing Map...");
            } else if (e.ProgressPercentage == 80)
            {
                stateString += LanguageManager.GetText("RSBot.SplashScreen.LoadingState.RecheckMediaPk2", "Rechecking Media.pk2...");
            }
            else if (e.ProgressPercentage == 83)
            {
                stateString += LanguageManager.GetText("RSBot.SplashScreen.LoadingState.InitializingGameData", "Initializing Game Data...");
            }

            lbLoadingState.Text = stateString;
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the Initializer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
        private void ReferenceDataLoaderCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            lbLoadingState.Text = "[93%] " + LanguageManager.GetText("RSBot.SplashScreen.LoadingState.AlmostDone", "Almost Done...");
            Kernel.PluginManager.LoadAssemblies();
            lbLoadingState.Text = "[99%] " + LanguageManager.GetText("RSBot.SplashScreen.LoadingState.Finishing", "Finishing...");
            Kernel.BotbaseManager.LoadAssemblies();
            // _mainForm.RefreshTheme(false);
            BeginInvoke(new MethodInvoker(() =>
            {
                RemoveImage();
                Close();
            }));
            if (_mainForm.InvokeRequired)
            {
                _mainForm.Invoke(new MethodInvoker(() =>
                {
                    _mainForm.Show();
                    _mainForm.RefreshTheme(false);
                }));
            } else
            {
                _mainForm.Show();
            }
        }
    }
}
