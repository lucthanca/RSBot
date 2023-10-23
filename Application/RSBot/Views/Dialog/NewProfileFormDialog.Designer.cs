namespace RSBot.Views.Dialog
{
    partial class NewProfileFormDialog
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
            txt_newProfileName = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            btn_ok = new System.Windows.Forms.Button();
            btn_cancel = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new System.Drawing.Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(39, 15);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Name";
            // 
            // txt_newProfileName
            // 
            txt_newProfileName.Location = new System.Drawing.Point(12, 27);
            txt_newProfileName.Name = "txt_newProfileName";
            txt_newProfileName.PlaceholderText = "Please enter a unique name";
            txt_newProfileName.Size = new System.Drawing.Size(229, 23);
            txt_newProfileName.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_ok);
            panel1.Controls.Add(btn_cancel);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 56);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(5);
            panel1.Size = new System.Drawing.Size(253, 35);
            panel1.TabIndex = 2;
            // 
            // btn_ok
            // 
            btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_ok.Location = new System.Drawing.Point(95, 5);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new System.Drawing.Size(75, 25);
            btn_ok.TabIndex = 1;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_cancel.Location = new System.Drawing.Point(173, 5);
            btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new System.Drawing.Size(75, 25);
            btn_cancel.TabIndex = 0;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // NewProfileFormDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(253, 91);
            Controls.Add(panel1);
            Controls.Add(txt_newProfileName);
            Controls.Add(lbTitle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewProfileFormDialog";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "New Profile";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txt_newProfileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}