using System.Windows.Forms;

namespace RSBot.Views.Controls
{


    partial class Character
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
            label3 = new Label();
            label4 = new Label();
            lblLevel = new Label();
            lblGold = new Label();
            lblSP = new Label();
            lblPlayerName = new Label();
            lblStr = new Label();
            label9 = new Label();
            lblInt = new Label();
            label11 = new Label();
            progressEXP = new SDUI.Controls.ProgressBar();
            progressMP = new SDUI.Controls.ProgressBar();
            progressHP = new SDUI.Controls.ProgressBar();
            charInfo = new GroupBox();
            lbCharLv = new Label();
            cosController1 = new Cos.CosController();
            charInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label3.Location = new System.Drawing.Point(6, 147);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 17);
            label3.TabIndex = 4;
            label3.Text = "Gold:";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label4.Location = new System.Drawing.Point(6, 164);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(26, 17);
            label4.TabIndex = 5;
            label4.Text = "SP:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BackColor = System.Drawing.Color.Transparent;
            lblLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLevel.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblLevel.Location = new System.Drawing.Point(46, 20);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new System.Drawing.Size(33, 15);
            lblLevel.TabIndex = 6;
            lblLevel.Text = "[lv.0]";
            lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.BackColor = System.Drawing.Color.Transparent;
            lblGold.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblGold.Location = new System.Drawing.Point(46, 147);
            lblGold.Name = "lblGold";
            lblGold.Padding = new Padding(0, 1, 0, 0);
            lblGold.Size = new System.Drawing.Size(13, 16);
            lblGold.TabIndex = 7;
            lblGold.Text = "0";
            lblGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSP
            // 
            lblSP.AutoSize = true;
            lblSP.BackColor = System.Drawing.Color.Transparent;
            lblSP.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblSP.Location = new System.Drawing.Point(46, 164);
            lblSP.Name = "lblSP";
            lblSP.Padding = new Padding(0, 1, 0, 0);
            lblSP.Size = new System.Drawing.Size(13, 16);
            lblSP.TabIndex = 8;
            lblSP.Text = "0";
            lblSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerName
            // 
            lblPlayerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPlayerName.AutoSize = true;
            lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            lblPlayerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPlayerName.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblPlayerName.Location = new System.Drawing.Point(7, 4);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new System.Drawing.Size(84, 17);
            lblPlayerName.TabIndex = 9;
            lblPlayerName.Text = "Not in game";
            // 
            // lblStr
            // 
            lblStr.AutoSize = true;
            lblStr.BackColor = System.Drawing.Color.Transparent;
            lblStr.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblStr.Location = new System.Drawing.Point(46, 113);
            lblStr.Name = "lblStr";
            lblStr.Padding = new Padding(0, 1, 0, 0);
            lblStr.Size = new System.Drawing.Size(13, 16);
            lblStr.TabIndex = 11;
            lblStr.Text = "0";
            lblStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label9.Location = new System.Drawing.Point(6, 113);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(33, 17);
            label9.TabIndex = 10;
            label9.Text = "STR:";
            // 
            // lblInt
            // 
            lblInt.AutoSize = true;
            lblInt.BackColor = System.Drawing.Color.Transparent;
            lblInt.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblInt.Location = new System.Drawing.Point(46, 130);
            lblInt.Name = "lblInt";
            lblInt.Padding = new Padding(0, 1, 0, 0);
            lblInt.Size = new System.Drawing.Size(13, 16);
            lblInt.TabIndex = 13;
            lblInt.Text = "0";
            lblInt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label11.Location = new System.Drawing.Point(6, 130);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(32, 17);
            label11.TabIndex = 12;
            label11.Text = "INT:";
            // 
            // progressEXP
            // 
            progressEXP.BackColor = System.Drawing.Color.Transparent;
            progressEXP.DrawHatch = false;
            progressEXP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            progressEXP.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
            progressEXP.Gradient = new System.Drawing.Color[] { System.Drawing.Color.DarkGreen, System.Drawing.Color.Lime };
            progressEXP.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            progressEXP.Location = new System.Drawing.Point(6, 90);
            progressEXP.Maximum = 1L;
            progressEXP.MaxPercentShowValue = 99.99F;
            progressEXP.Name = "progressEXP";
            progressEXP.PercentIndices = 2;
            progressEXP.Radius = 1;
            progressEXP.ShowAsPercent = true;
            progressEXP.ShowValue = true;
            progressEXP.Size = new System.Drawing.Size(238, 20);
            progressEXP.TabIndex = 2;
            progressEXP.Text = "0.00%";
            progressEXP.Value = 0L;
            // 
            // progressMP
            // 
            progressMP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressMP.BackColor = System.Drawing.Color.Transparent;
            progressMP.DrawHatch = false;
            progressMP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            progressMP.Gradient = new System.Drawing.Color[] { System.Drawing.Color.MidnightBlue, System.Drawing.Color.RoyalBlue };
            progressMP.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            progressMP.Location = new System.Drawing.Point(6, 64);
            progressMP.Maximum = 1L;
            progressMP.MaxPercentShowValue = 100F;
            progressMP.Name = "progressMP";
            progressMP.PercentIndices = 2;
            progressMP.Radius = 1;
            progressMP.ShowAsPercent = false;
            progressMP.ShowValue = true;
            progressMP.Size = new System.Drawing.Size(238, 20);
            progressMP.TabIndex = 1;
            progressMP.Text = "0 / 1";
            progressMP.Value = 0L;
            // 
            // progressHP
            // 
            progressHP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressHP.BackColor = System.Drawing.Color.Transparent;
            progressHP.DrawHatch = false;
            progressHP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            progressHP.ForeColor = System.Drawing.Color.Firebrick;
            progressHP.Gradient = new System.Drawing.Color[] { System.Drawing.Color.Maroon, System.Drawing.Color.Red };
            progressHP.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            progressHP.Location = new System.Drawing.Point(6, 38);
            progressHP.Maximum = 1L;
            progressHP.MaxPercentShowValue = 100F;
            progressHP.Name = "progressHP";
            progressHP.PercentIndices = 2;
            progressHP.Radius = 1;
            progressHP.ShowAsPercent = false;
            progressHP.ShowValue = true;
            progressHP.Size = new System.Drawing.Size(238, 20);
            progressHP.TabIndex = 0;
            progressHP.Text = "0 / 1";
            progressHP.Value = 0L;
            // 
            // charInfo
            // 
            charInfo.BackColor = System.Drawing.Color.Transparent;
            charInfo.Controls.Add(lbCharLv);
            charInfo.Controls.Add(lblLevel);
            charInfo.Controls.Add(lblSP);
            charInfo.Controls.Add(lblInt);
            charInfo.Controls.Add(label4);
            charInfo.Controls.Add(lblGold);
            charInfo.Controls.Add(progressHP);
            charInfo.Controls.Add(label11);
            charInfo.Controls.Add(label3);
            charInfo.Controls.Add(progressMP);
            charInfo.Controls.Add(lblStr);
            charInfo.Controls.Add(progressEXP);
            charInfo.Controls.Add(label9);
            charInfo.Dock = DockStyle.Top;
            charInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            charInfo.Location = new System.Drawing.Point(3, 3);
            charInfo.Margin = new Padding(0);
            charInfo.Name = "charInfo";
            charInfo.Size = new System.Drawing.Size(250, 190);
            charInfo.TabIndex = 15;
            charInfo.TabStop = false;
            charInfo.Text = "Not in game";
            // 
            // lbCharLv
            // 
            lbCharLv.AutoSize = true;
            lbCharLv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbCharLv.Location = new System.Drawing.Point(3, 20);
            lbCharLv.Margin = new Padding(0);
            lbCharLv.Name = "lbCharLv";
            lbCharLv.Size = new System.Drawing.Size(40, 15);
            lbCharLv.TabIndex = 7;
            lbCharLv.Text = "Level:";
            // 
            // cosController1
            // 
            cosController1.BackColor = System.Drawing.Color.Teal;
            cosController1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cosController1.Location = new System.Drawing.Point(3, 193);
            cosController1.Margin = new Padding(0);
            cosController1.MinimumSize = new System.Drawing.Size(250, 102);
            cosController1.Name = "cosController1";
            cosController1.Size = new System.Drawing.Size(250, 102);
            cosController1.TabIndex = 16;
            cosController1.Visible = false;
            // 
            // Character
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(cosController1);
            Controls.Add(charInfo);
            Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new Padding(0);
            MinimumSize = new System.Drawing.Size(256, 260);
            Name = "Character";
            Padding = new Padding(3);
            Size = new System.Drawing.Size(256, 366);
            charInfo.ResumeLayout(false);
            charInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SDUI.Controls.ProgressBar progressHP;
        private SDUI.Controls.ProgressBar progressMP;
        private SDUI.Controls.ProgressBar progressEXP;
        private Label label3;
        private Label label4;
        private Label lblLevel;
        private Label lblGold;
        private Label lblSP;
        private Label lblPlayerName;
        private Label lblStr;
        private Label label9;
        private Label lblInt;
        private Label label11;
        private GroupBox charInfo;
        private Label lbCharLv;
        private Cos.CosController cosController1;
    }
}
