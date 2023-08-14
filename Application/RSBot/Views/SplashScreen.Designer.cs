using System.Drawing;
using System.Windows.Forms;

namespace RSBot.Views
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            referenceDataLoader = new System.ComponentModel.BackgroundWorker();
            lbLoadingState = new Label();
            SuspendLayout();
            // 
            // referenceDataLoader
            // 
            referenceDataLoader.DoWork += referenceDataLoader_DoWork;
            // 
            // lbLoadingState
            // 
            lbLoadingState.AutoSize = true;
            lbLoadingState.BackColor = Color.Transparent;
            lbLoadingState.ForeColor = SystemColors.Window;
            lbLoadingState.Location = new Point(12, 300);
            lbLoadingState.Name = "lbLoadingState";
            lbLoadingState.Size = new Size(131, 21);
            lbLoadingState.TabIndex = 1;
            lbLoadingState.Text = "Đang khởi động...";
            // 
            // SplashScreen
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            DrawControlBackgrounds = true;
            EnhancedRendering = true;
            ImeMode = System.Windows.Forms.ImeMode.Disable;
            SizeMode = SizeModes.Clip;

            BackColor = Color.Fuchsia;
            BlendedBackground = Properties.Resources.SilkroadOnline_splash;
            ClientSize = new Size(600, 330);
            Controls.Add(lbLoadingState);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(0, 0, 0, 0);
            MaximizeBox = false;
            MaximumSize = new Size(600, 330);
            MinimizeBox = false;
            MinimumSize = new Size(600, 330);
            Name = "SplashScreen";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "private";
            TransparencyKey = Color.Fuchsia;
            Load += SplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.ComponentModel.BackgroundWorker referenceDataLoader;
        private Label lbLoadingState;
    }
}