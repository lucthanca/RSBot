using System.Drawing;

namespace RSBot.Views
{
    partial class SplashScreenV2
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
            referenceDataLoader = new System.ComponentModel.BackgroundWorker();
            lbLoadingState = new System.Windows.Forms.Label();
            SuspendLayout();
            referenceDataLoader.DoWork += referenceDataLoader_DoWork;
            // 
            // lbLoadingState
            // 
            lbLoadingState.AutoSize = true;
            lbLoadingState.BackColor = Color.Transparent;
            lbLoadingState.ForeColor = SystemColors.Window;
            lbLoadingState.Location = new Point(12, 288);
            lbLoadingState.Name = "lbLoadingState";
            lbLoadingState.Size = new Size(101, 15);
            lbLoadingState.TabIndex = 0;
            lbLoadingState.Text = "Đang khởi động...";
            // 
            // SplashScreenV2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            //BlendedBackground = Properties.Resources.SilkroadOnline_splash;
            ClientSize = new Size(600, 330);
            Controls.Add(lbLoadingState);
            //DrawControlBackgrounds = true;
            //EnhancedRendering = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ImeMode = System.Windows.Forms.ImeMode.Disable;
            Name = "SplashScreenV2";
            Text = "SplashScreenV2";
            TransparencyKey = Color.Fuchsia;
            Load += SplashScreenV2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker referenceDataLoader;
        private System.Windows.Forms.Label lbLoadingState;
    }
}