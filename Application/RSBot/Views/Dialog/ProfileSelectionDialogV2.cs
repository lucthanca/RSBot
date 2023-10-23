using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSBot.Core;
using RSBot.Core.Components;
using RSBot.Views.Dialog;
using SDUI.Controls;

namespace RSBot.Views
{
    public partial class ProfileSelectionDialogV2 : Form
    {
        public string SelectedProfile { get; private set; }

        public List<string> recentAddedProfiles = new List<string>();

        public ProfileSelectionDialogV2()
        {
            InitializeComponent();
            DoubleBuffered = true;
            DoubleBuffer.Set(pn_actions);
            DoubleBuffer.Set(cb_profiles);
            DoubleBuffer.Set(btnConfirm);
            DoubleBuffer.Set(btnCreate);
            DoubleBuffer.Set(btnRemove);

            LoadProfiles();
        }

        private void LoadProfiles()
        {
            cb_profiles.Items.Clear();
            if (!ProfileManager.Any())
                ProfileManager.Add("Default");

            cb_profiles.Items.AddRange(ProfileManager.Profiles);
            cb_profiles.SelectedItem = ProfileManager.SelectedProfile;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var newProfile = CreateNewProfile();
            if (newProfile != string.Empty) SelectedProfile = newProfile;

            LoadProfiles();
        }

        private string CreateNewProfile()
        {
            var inputDialog = new NewProfileFormDialog();
            if (inputDialog.ShowDialog() != DialogResult.OK)
                return string.Empty;

            var profile = (string)inputDialog.Value;

            if (profile.LastIndexOfAny(Path.GetInvalidFileNameChars(), 0) != -1)
            {
                MessageBox.Show("The profile name contains invalid characters!", "Invalid name", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return string.Empty;
            }

            if (ProfileManager.ProfileExists(profile))
            {
                MessageBox.Show($"The profile name '{profile}' already exists!", "Invalid name", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return string.Empty;
            }

            ProfileManager.Add(profile, true);
            recentAddedProfiles.Add(profile);
            return profile;
        }

        private void cb_profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_profiles.SelectedItem == null)
                return;

            SelectedProfile = (string)cb_profiles.SelectedItem;
        }

        private void chk_saveSelection_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.ShowProfileDialog = !chk_saveSelection.Checked;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cb_profiles.SelectedIndex == 0) //Default
            {
                MessageBox.Show("You can not delete the default profile!", "Default profile",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (ProfileManager.SelectedProfile == (string)cb_profiles.SelectedItem) //Active profile?
            {
                MessageBox.Show("You can not delete the active profile!", "Profile active",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (MessageBox.Show(
                    $"Do you want to delete the profile {cb_profiles.SelectedItem} from the list?\nThis will not delete the user data.",
                    "Delete profile?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            ProfileManager.Remove((string)cb_profiles.SelectedItem);

            LoadProfiles();
        }
    }
}
