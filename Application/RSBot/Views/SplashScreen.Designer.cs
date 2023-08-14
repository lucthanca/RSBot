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
            alphaFormTransformer1 = new Vadu.AlphaForm.AlphaFormTransformer();
            alphaFormMarker1 = new Vadu.AlphaForm.AlphaFormMarker();
            alphaFormTransformer1.SuspendLayout();
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
            lbLoadingState.Location = new Point(12, 280);
            lbLoadingState.Name = "lbLoadingState";
            lbLoadingState.Size = new Size(131, 21);
            lbLoadingState.TabIndex = 1;
            lbLoadingState.Text = "Đang khởi động...";
            // 
            // alphaFormTransformer1
            // 
            alphaFormTransformer1.BackgroundImage = Properties.Resources.SilkroadOnline_splash;
            alphaFormTransformer1.Controls.Add(lbLoadingState);
            alphaFormTransformer1.Controls.Add(alphaFormMarker1);
            alphaFormTransformer1.Dismiss = false;
            alphaFormTransformer1.Dock = DockStyle.Fill;
            alphaFormTransformer1.DragSleep = 30U;
            alphaFormTransformer1.Location = new Point(0, 0);
            alphaFormTransformer1.Margin = new Padding(0);
            alphaFormTransformer1.Name = "alphaFormTransformer1";
            alphaFormTransformer1.Size = new Size(600, 330);
            alphaFormTransformer1.TabIndex = 2;
            // 
            // alphaFormMarker1
            // 
            alphaFormMarker1.FillBorder = 4U;
            alphaFormMarker1.Location = new Point(12, 284);
            alphaFormMarker1.Name = "alphaFormMarker1";
            alphaFormMarker1.Size = new Size(17, 17);
            alphaFormMarker1.TabIndex = 0;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Fuchsia;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(600, 330);
            Controls.Add(alphaFormTransformer1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
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
            alphaFormTransformer1.ResumeLayout(false);
            alphaFormTransformer1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private System.ComponentModel.BackgroundWorker referenceDataLoader;
        private Label lbLoadingState;
        private Vadu.AlphaForm.AlphaFormTransformer alphaFormTransformer1;
        private Vadu.AlphaForm.AlphaFormMarker alphaFormMarker1;
    }
}