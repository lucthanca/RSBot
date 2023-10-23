namespace RSBot.Views
{
    partial class ProfileSelectionDialogV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new System.Windows.Forms.Label();
            cb_profiles = new System.Windows.Forms.ComboBox();
            btnRemove = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            btnConfirm = new System.Windows.Forms.Button();
            pn_actions = new System.Windows.Forms.Panel();
            chk_saveSelection = new System.Windows.Forms.CheckBox();
            pn_actions.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new System.Drawing.Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(75, 15);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Select Profile";
            // 
            // cb_profiles
            // 
            cb_profiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cb_profiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_profiles.FormattingEnabled = true;
            cb_profiles.Location = new System.Drawing.Point(12, 28);
            cb_profiles.Name = "cb_profiles";
            cb_profiles.Size = new System.Drawing.Size(260, 23);
            cb_profiles.TabIndex = 1;
            cb_profiles.SelectedIndexChanged += cb_profiles_SelectedIndexChanged;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRemove.BackColor = System.Drawing.SystemColors.Window;
            btnRemove.Location = new System.Drawing.Point(85, 5);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(75, 25);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCreate.AutoSize = true;
            btnCreate.Location = new System.Drawing.Point(5, 5);
            btnCreate.Margin = new System.Windows.Forms.Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(75, 25);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnConfirm.AutoSize = true;
            btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnConfirm.Location = new System.Drawing.Point(204, 5);
            btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(75, 25);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Continue";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // pn_actions
            // 
            pn_actions.Controls.Add(btnCreate);
            pn_actions.Controls.Add(btnConfirm);
            pn_actions.Controls.Add(btnRemove);
            pn_actions.Dock = System.Windows.Forms.DockStyle.Bottom;
            pn_actions.Location = new System.Drawing.Point(0, 86);
            pn_actions.Margin = new System.Windows.Forms.Padding(0);
            pn_actions.Name = "pn_actions";
            pn_actions.Padding = new System.Windows.Forms.Padding(5);
            pn_actions.Size = new System.Drawing.Size(284, 35);
            pn_actions.TabIndex = 5;
            // 
            // chk_saveSelection
            // 
            chk_saveSelection.AutoSize = true;
            chk_saveSelection.Location = new System.Drawing.Point(12, 57);
            chk_saveSelection.Name = "chk_saveSelection";
            chk_saveSelection.Size = new System.Drawing.Size(100, 19);
            chk_saveSelection.TabIndex = 6;
            chk_saveSelection.Text = "Save selection";
            chk_saveSelection.UseVisualStyleBackColor = true;
            chk_saveSelection.CheckedChanged += chk_saveSelection_CheckedChanged;
            // 
            // ProfileSelectionDialogV2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(284, 121);
            Controls.Add(chk_saveSelection);
            Controls.Add(pn_actions);
            Controls.Add(cb_profiles);
            Controls.Add(lbTitle);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(300, 160);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(300, 160);
            Name = "ProfileSelectionDialogV2";
            ShowIcon = false;
            Text = "Select Profile";
            pn_actions.ResumeLayout(false);
            pn_actions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cb_profiles;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pn_actions;
        private System.Windows.Forms.CheckBox chk_saveSelection;
    }
}