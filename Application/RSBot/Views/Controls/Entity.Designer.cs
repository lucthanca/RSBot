using System.Windows.Forms;
namespace RSBot.Views.Controls
{
    partial class Entity
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
            lblType = new SDUI.Controls.Label();
            lblEntityName = new SDUI.Controls.Label();
            progressHP = new SDUI.Controls.ProgressBar();
            lbHP = new SDUI.Controls.Label();
            SuspendLayout();
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblType.ApplyGradient = false;
            lblType.AutoEllipsis = true;
            lblType.BackColor = System.Drawing.Color.Transparent;
            lblType.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblType.Gradient = new System.Drawing.Color[] { System.Drawing.Color.Gray, System.Drawing.Color.Black };
            lblType.GradientAnimation = false;
            lblType.Location = new System.Drawing.Point(3, 44);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(244, 19);
            lblType.TabIndex = 18;
            lblType.Text = "<none>";
            lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntityName
            // 
            lblEntityName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEntityName.ApplyGradient = false;
            lblEntityName.AutoEllipsis = true;
            lblEntityName.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lblEntityName.Gradient = new System.Drawing.Color[] { System.Drawing.Color.Gray, System.Drawing.Color.Black };
            lblEntityName.GradientAnimation = false;
            lblEntityName.Location = new System.Drawing.Point(3, 3);
            lblEntityName.Margin = new Padding(3, 3, 3, 0);
            lblEntityName.Name = "lblEntityName";
            lblEntityName.Size = new System.Drawing.Size(244, 15);
            lblEntityName.TabIndex = 16;
            lblEntityName.Text = "No entity selected";
            lblEntityName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressHP
            // 
            progressHP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressHP.BackColor = System.Drawing.Color.Transparent;
            progressHP.DrawHatch = false;
            progressHP.ForeColor = System.Drawing.Color.Firebrick;
            progressHP.Gradient = new System.Drawing.Color[] { System.Drawing.Color.Maroon, System.Drawing.Color.Red };
            progressHP.HatchType = System.Drawing.Drawing2D.HatchStyle.Percent10;
            progressHP.Location = new System.Drawing.Point(3, 21);
            progressHP.Maximum = 100L;
            progressHP.MaxPercentShowValue = 100F;
            progressHP.Name = "progressHP";
            progressHP.PercentIndices = 2;
            progressHP.Radius = 6;
            progressHP.ShowAsPercent = true;
            progressHP.ShowValue = true;
            progressHP.Size = new System.Drawing.Size(244, 20);
            progressHP.TabIndex = 15;
            progressHP.Text = "0.00%";
            progressHP.Value = 0L;
            // 
            // lbHP
            // 
            lbHP.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbHP.ApplyGradient = false;
            lbHP.AutoSize = true;
            lbHP.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lbHP.Gradient = new System.Drawing.Color[] { System.Drawing.Color.Gray, System.Drawing.Color.Black };
            lbHP.GradientAnimation = false;
            lbHP.Location = new System.Drawing.Point(218, 69);
            lbHP.Name = "lbHP";
            lbHP.Size = new System.Drawing.Size(29, 15);
            lbHP.TabIndex = 19;
            lbHP.Text = "N/A";
            lbHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Entity
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(lbHP);
            Controls.Add(lblType);
            Controls.Add(lblEntityName);
            Controls.Add(progressHP);
            Margin = new Padding(0);
            MinimumSize = new System.Drawing.Size(250, 76);
            Name = "Entity";
            Size = new System.Drawing.Size(250, 88);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SDUI.Controls.ProgressBar progressHP;
        private SDUI.Controls.Label lblType;
        private SDUI.Controls.Label lblEntityName;
        private SDUI.Controls.Label lbHP;
    }
}
