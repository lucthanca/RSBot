using System.Drawing;
using System.Windows.Forms;

namespace RSBot
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
            lbLoadingState = new Label();
            SuspendLayout();
            // 
            // referenceDataLoader
            // 
            referenceDataLoader.WorkerReportsProgress = true;
            referenceDataLoader.DoWork += referenceDataLoader_DoWork;
            referenceDataLoader.ProgressChanged += ReferenceDataLoaderProgressChanged;
            referenceDataLoader.RunWorkerCompleted += ReferenceDataLoaderCompleted;
            // 
            // lbLoadingState
            // 
            lbLoadingState.AutoSize = true;
            lbLoadingState.BackColor = Color.Transparent;
            lbLoadingState.ForeColor = SystemColors.Window;
            lbLoadingState.Location = new Point(138, 314);
            lbLoadingState.Name = "lbLoadingState";
            lbLoadingState.Size = new Size(101, 15);
            lbLoadingState.TabIndex = 1;
            lbLoadingState.Text = "Đang khởi động...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            BlendedBackground = Properties.Resources.SilkroadOnline_splash;
            ClientSize = new Size(600, 340);
            Controls.Add(lbLoadingState);
            DrawControlBackgrounds = true;
            EnhancedRendering = true;
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Disable;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(600, 340);
            MinimizeBox = false;
            MinimumSize = new Size(600, 340);
            Name = "Form1";
            SizeMode = SizeModes.Clip;
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "private";
            Text = "Form1";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker referenceDataLoader;
        private Label lbLoadingState;
        private ComboBox comboBox1;
    }
}

