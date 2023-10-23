using RSBot.Views.Controls;
using System.Windows.Forms;

namespace RSBot.Views
{
    partial class MainLegacy
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLegacy));
            stripStatus = new StatusStrip();
            lblIngameStatus = new ToolStripStatusLabel();
            menuCurrentProfile = new ToolStripMenuItem();
            bottomPanel = new Panel();
            buttonConfig = new SDUI.Controls.Button();
            comboServer = new SDUI.Controls.ComboBox();
            comboDivision = new SDUI.Controls.ComboBox();
            btnSave = new SDUI.Controls.Button();
            btnStartStop = new SDUI.Controls.Button();
            pSidebar = new Panel();
            tabList = new ListView();
            tabTitle = new ColumnHeader();
            tabMain = new SDUI.Controls.TabControl();
            botbase1ToolStripMenuItem1 = new ToolStripMenuItem();
            botbase1ToolStripMenuItem = new ToolStripMenuItem();
            notifyIcon = new NotifyIcon(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuSelectProfile = new ToolStripMenuItem();
            networkConfigToolStripMenuItem = new ToolStripMenuItem();
            menuItemExit = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            menuSidebar = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            menuScriptRecorder = new ToolStripMenuItem();
            menuPlugins = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            thisToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new SDUI.Controls.MenuStrip();
            botsToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            autoToolStripMenuItem = new ToolStripMenuItem();
            coloredToolStripMenuItem = new ToolStripMenuItem();
            separator = new SDUI.Controls.Separator();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            stripStatus.SuspendLayout();
            bottomPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // stripStatus
            // 
            stripStatus.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            stripStatus.GripMargin = new Padding(2, 2, 0, 2);
            stripStatus.ImageScalingSize = new System.Drawing.Size(17, 17);
            stripStatus.Items.AddRange(new ToolStripItem[] { lblIngameStatus, menuCurrentProfile });
            stripStatus.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            stripStatus.Location = new System.Drawing.Point(0, 739);
            stripStatus.Margin = new Padding(0, 5, 0, 0);
            stripStatus.Name = "stripStatus";
            stripStatus.Size = new System.Drawing.Size(984, 22);
            stripStatus.TabIndex = 0;
            stripStatus.Tag = "private";
            // 
            // lblIngameStatus
            // 
            lblIngameStatus.BackColor = System.Drawing.Color.Transparent;
            lblIngameStatus.ForeColor = System.Drawing.Color.White;
            lblIngameStatus.Name = "lblIngameStatus";
            lblIngameStatus.Size = new System.Drawing.Size(73, 17);
            lblIngameStatus.Text = "Not in game";
            // 
            // menuCurrentProfile
            // 
            menuCurrentProfile.Alignment = ToolStripItemAlignment.Right;
            menuCurrentProfile.ForeColor = System.Drawing.Color.White;
            menuCurrentProfile.Name = "menuCurrentProfile";
            menuCurrentProfile.Size = new System.Drawing.Size(97, 22);
            menuCurrentProfile.Text = "Profile: Default";
            menuCurrentProfile.Click += menuSelectProfile_Click;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = System.Drawing.Color.Transparent;
            bottomPanel.Controls.Add(buttonConfig);
            bottomPanel.Controls.Add(comboServer);
            bottomPanel.Controls.Add(comboDivision);
            bottomPanel.Controls.Add(btnSave);
            bottomPanel.Controls.Add(btnStartStop);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new System.Drawing.Point(0, 702);
            bottomPanel.Margin = new Padding(3, 3, 3, 5);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(5);
            bottomPanel.Size = new System.Drawing.Size(984, 37);
            bottomPanel.TabIndex = 2;
            // 
            // buttonConfig
            // 
            buttonConfig.Color = System.Drawing.Color.Transparent;
            buttonConfig.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonConfig.Location = new System.Drawing.Point(243, 8);
            buttonConfig.Name = "buttonConfig";
            buttonConfig.Radius = 6;
            buttonConfig.ShadowDepth = 4F;
            buttonConfig.Size = new System.Drawing.Size(25, 23);
            buttonConfig.TabIndex = 12;
            buttonConfig.Text = "@";
            buttonConfig.UseVisualStyleBackColor = true;
            buttonConfig.Click += buttonConfig_Click;
            // 
            // comboServer
            // 
            comboServer.DrawMode = DrawMode.OwnerDrawFixed;
            comboServer.DropDownHeight = 100;
            comboServer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboServer.FormattingEnabled = true;
            comboServer.IntegralHeight = false;
            comboServer.ItemHeight = 17;
            comboServer.Location = new System.Drawing.Point(105, 8);
            comboServer.Name = "comboServer";
            comboServer.Radius = 5;
            comboServer.ShadowDepth = 4F;
            comboServer.Size = new System.Drawing.Size(132, 23);
            comboServer.TabIndex = 11;
            comboServer.SelectedIndexChanged += comboServer_SelectedIndexChanged;
            // 
            // comboDivision
            // 
            comboDivision.DrawMode = DrawMode.OwnerDrawFixed;
            comboDivision.DropDownHeight = 100;
            comboDivision.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDivision.FormattingEnabled = true;
            comboDivision.IntegralHeight = false;
            comboDivision.ItemHeight = 17;
            comboDivision.Location = new System.Drawing.Point(8, 8);
            comboDivision.Name = "comboDivision";
            comboDivision.Radius = 5;
            comboDivision.ShadowDepth = 4F;
            comboDivision.Size = new System.Drawing.Size(91, 23);
            comboDivision.TabIndex = 10;
            comboDivision.SelectedIndexChanged += comboDivision_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Color = System.Drawing.Color.FromArgb(56, 155, 90);
            btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(754, 5);
            btnSave.Name = "btnSave";
            btnSave.Radius = 20;
            btnSave.ShadowDepth = 4F;
            btnSave.Size = new System.Drawing.Size(95, 27);
            btnSave.TabIndex = 1;
            btnSave.TabStop = false;
            btnSave.Tag = "private";
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartStop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStartStop.BackColor = System.Drawing.Color.Transparent;
            btnStartStop.Color = System.Drawing.Color.FromArgb(33, 150, 243);
            btnStartStop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnStartStop.ForeColor = System.Drawing.Color.White;
            btnStartStop.Location = new System.Drawing.Point(881, 5);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Radius = 20;
            btnStartStop.ShadowDepth = 4F;
            btnStartStop.Size = new System.Drawing.Size(95, 27);
            btnStartStop.TabIndex = 0;
            btnStartStop.TabStop = false;
            btnStartStop.Tag = "private";
            btnStartStop.Text = "START BOT";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // pSidebar
            // 
            pSidebar.BackColor = System.Drawing.Color.Transparent;
            pSidebar.Dock = DockStyle.Right;
            pSidebar.Location = new System.Drawing.Point(744, 30);
            pSidebar.Margin = new Padding(5, 0, 0, 0);
            pSidebar.Name = "pSidebar";
            pSidebar.Padding = new Padding(5);
            pSidebar.Size = new System.Drawing.Size(240, 672);
            pSidebar.TabIndex = 6;
            // 
            // tabList
            // 
            tabList.Columns.AddRange(new ColumnHeader[] { tabTitle });
            tabList.Dock = DockStyle.Fill;
            tabList.FullRowSelect = true;
            tabList.HeaderStyle = ColumnHeaderStyle.None;
            tabList.Location = new System.Drawing.Point(0, 0);
            tabList.MultiSelect = false;
            tabList.Name = "tabList";
            tabList.Size = new System.Drawing.Size(76, 672);
            tabList.TabIndex = 1;
            tabList.UseCompatibleStateImageBehavior = false;
            tabList.View = View.Details;
            tabList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabTitle
            // 
            tabTitle.Text = "Title";
            tabTitle.Width = 120;
            // 
            // tabMain
            // 
            tabMain.Dock = DockStyle.Fill;
            tabMain.ItemSize = new System.Drawing.Size(80, 24);
            tabMain.Location = new System.Drawing.Point(5, 5);
            tabMain.Margin = new Padding(0);
            tabMain.Name = "tabMain";
            tabMain.Radius = new Padding(4);
            tabMain.SelectedIndex = 0;
            tabMain.Size = new System.Drawing.Size(712, 651);
            tabMain.TabIndex = 3;
            tabMain.Selecting += tabMain_Selecting;
            // 
            // botbase1ToolStripMenuItem1
            // 
            botbase1ToolStripMenuItem1.Name = "botbase1ToolStripMenuItem1";
            botbase1ToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            botbase1ToolStripMenuItem1.Text = "Botbase #2";
            // 
            // botbase1ToolStripMenuItem
            // 
            botbase1ToolStripMenuItem.Name = "botbase1ToolStripMenuItem";
            botbase1ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            botbase1ToolStripMenuItem.Text = "Botbase #1";
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = "RSBot is currently running in the system tray.";
            notifyIcon.BalloonTipTitle = "RSBot";
            notifyIcon.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "RSBot";
            notifyIcon.Visible = true;
            notifyIcon.Click += notifyIcon_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSelectProfile, networkConfigToolStripMenuItem, menuItemExit });
            fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            fileToolStripMenuItem.Text = "File";
            // 
            // menuSelectProfile
            // 
            menuSelectProfile.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            menuSelectProfile.Name = "menuSelectProfile";
            menuSelectProfile.Size = new System.Drawing.Size(160, 22);
            menuSelectProfile.Text = "Select Profile...";
            menuSelectProfile.Click += menuSelectProfile_Click;
            // 
            // networkConfigToolStripMenuItem
            // 
            networkConfigToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            networkConfigToolStripMenuItem.Name = "networkConfigToolStripMenuItem";
            networkConfigToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            networkConfigToolStripMenuItem.Text = "Proxy Config";
            networkConfigToolStripMenuItem.Click += networkConfigToolStripMenuItem_Click;
            // 
            // menuItemExit
            // 
            menuItemExit.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            menuItemExit.Name = "menuItemExit";
            menuItemExit.Size = new System.Drawing.Size(160, 22);
            menuItemExit.Text = "Exit";
            menuItemExit.Click += menuItemExit_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSidebar });
            viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            viewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            viewToolStripMenuItem.Text = "View";
            // 
            // menuSidebar
            // 
            menuSidebar.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            menuSidebar.Name = "menuSidebar";
            menuSidebar.Size = new System.Drawing.Size(121, 22);
            menuSidebar.Text = "Sidebar";
            menuSidebar.Click += menuSidebar_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuScriptRecorder });
            toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // menuScriptRecorder
            // 
            menuScriptRecorder.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            menuScriptRecorder.Name = "menuScriptRecorder";
            menuScriptRecorder.Size = new System.Drawing.Size(167, 22);
            menuScriptRecorder.Text = "Script Recorder";
            menuScriptRecorder.Click += menuScriptRecorder_Click;
            // 
            // menuPlugins
            // 
            menuPlugins.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuPlugins.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            menuPlugins.Name = "menuPlugins";
            menuPlugins.Size = new System.Drawing.Size(61, 21);
            menuPlugins.Text = "Plugins";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thisToolStripMenuItem });
            aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            aboutToolStripMenuItem.Text = "About";
            // 
            // thisToolStripMenuItem
            // 
            thisToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            thisToolStripMenuItem.Name = "thisToolStripMenuItem";
            thisToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            thisToolStripMenuItem.Text = "This";
            thisToolStripMenuItem.Click += menuItemThis_Click;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = System.Drawing.Color.Transparent;
            menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, menuPlugins, botsToolStripMenuItem, languageToolStripMenuItem, themeToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(6, 4, 6, 4);
            menuStrip.Size = new System.Drawing.Size(984, 29);
            menuStrip.TabIndex = 10;
            menuStrip.MouseDown += menuStrip_MouseDown;
            // 
            // botsToolStripMenuItem
            // 
            botsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            botsToolStripMenuItem.Name = "botsToolStripMenuItem";
            botsToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            botsToolStripMenuItem.Text = "Bots";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            languageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            languageToolStripMenuItem.Text = "Language";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem, autoToolStripMenuItem, coloredToolStripMenuItem });
            themeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            themeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            lightToolStripMenuItem.Text = "Light";
            lightToolStripMenuItem.Click += lightToolStripMenuItem_Click;
            // 
            // autoToolStripMenuItem
            // 
            autoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            autoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            autoToolStripMenuItem.Text = "Auto";
            autoToolStripMenuItem.Click += autoToolStripMenuItem_Click;
            // 
            // coloredToolStripMenuItem
            // 
            coloredToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            coloredToolStripMenuItem.Name = "coloredToolStripMenuItem";
            coloredToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            coloredToolStripMenuItem.Text = "Choose a color";
            coloredToolStripMenuItem.Click += coloredToolStripMenuItem_Click;
            // 
            // separator
            // 
            separator.Dock = DockStyle.Top;
            separator.IsVertical = false;
            separator.Location = new System.Drawing.Point(0, 29);
            separator.Name = "separator";
            separator.Size = new System.Drawing.Size(984, 1);
            separator.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new Padding(0, 0, 10, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new System.Drawing.Size(663, 672);
            panel1.TabIndex = 12;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 30);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabList);
            splitContainer1.Panel1MinSize = 74;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2MinSize = 600;
            splitContainer1.Size = new System.Drawing.Size(744, 672);
            splitContainer1.SplitterDistance = 76;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // MainLegacy
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            ClientSize = new System.Drawing.Size(984, 761);
            Controls.Add(splitContainer1);
            Controls.Add(pSidebar);
            Controls.Add(bottomPanel);
            Controls.Add(separator);
            Controls.Add(menuStrip);
            Controls.Add(stripStatus);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.Black;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MinimumSize = new System.Drawing.Size(1000, 800);
            Name = "MainLegacy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RSBot";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            Resize += Main_Resize;
            stripStatus.ResumeLayout(false);
            stripStatus.PerformLayout();
            bottomPanel.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip stripStatus;
        private Panel bottomPanel;
        private Panel pSidebar;
        private ToolStripStatusLabel lblIngameStatus;
        private SDUI.Controls.Button btnStartStop;
        private SDUI.Controls.Button btnSave;
        private SDUI.Controls.ComboBox comboServer;
        private SDUI.Controls.ComboBox comboDivision;
        private ToolStripMenuItem botbase1ToolStripMenuItem1;
        private ToolStripMenuItem botbase1ToolStripMenuItem;
        private NotifyIcon notifyIcon;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuItemExit;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem menuSidebar;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem menuScriptRecorder;
        private ToolStripMenuItem menuPlugins;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem thisToolStripMenuItem;
        private SDUI.Controls.MenuStrip menuStrip;
        private SDUI.Controls.TabControl tabMain;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem coloredToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private SDUI.Controls.Separator separator;
        private ToolStripMenuItem menuSelectProfile;
        private ToolStripMenuItem menuCurrentProfile;
        private ToolStripMenuItem botsToolStripMenuItem;
        private ToolStripMenuItem autoToolStripMenuItem;
        private SDUI.Controls.Button buttonConfig;
        private ToolStripMenuItem networkConfigToolStripMenuItem;
        private Panel panel1;
        private ListView tabList;
        private ColumnHeader tabTitle;
        private SplitContainer splitContainer1;
    }
}

