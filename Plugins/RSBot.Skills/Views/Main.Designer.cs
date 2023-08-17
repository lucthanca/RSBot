﻿using System.Windows.Forms;

namespace RSBot.Skills.Views
{
    partial class Main
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
            groupBox1 = new SDUI.Controls.GroupBox();
            panel6 = new Panel();
            listAttackingSkills = new SDUI.Controls.ListView();
            columnName = new ColumnHeader();
            columnLevel = new ColumnHeader();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnRemoveAttackSkill = new SDUI.Controls.Button();
            btnMoveAttackSkillUp = new SDUI.Controls.Button();
            btnMoveAttackSkillDown = new SDUI.Controls.Button();
            panel4 = new Panel();
            panel5 = new Panel();
            checkBoxNoAttack = new CheckBox();
            checkUseSkillsInOrder = new CheckBox();
            label2 = new SDUI.Controls.Label();
            comboMonsterType = new SDUI.Controls.ComboBox();
            groupBox2 = new SDUI.Controls.GroupBox();
            listBuffs = new SDUI.Controls.ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnMoveBuffSkillDown = new SDUI.Controls.Button();
            comboImbue = new SDUI.Controls.ComboBox();
            btnMoveBuffSkillUp = new SDUI.Controls.Button();
            label1 = new SDUI.Controls.Label();
            btnRemoveBuffSkill = new SDUI.Controls.Button();
            tabControl1 = new SDUI.Controls.TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tabPage2 = new TabPage();
            groupWarlockMode = new SDUI.Controls.GroupBox();
            comboTeleportSkill = new SDUI.Controls.ComboBox();
            checkUseTeleportSkill = new SDUI.Controls.CheckBox();
            checkUseDefaultAttack = new SDUI.Controls.CheckBox();
            checkWarlockMode = new SDUI.Controls.CheckBox();
            grpMasteryLearn = new SDUI.Controls.GroupBox();
            checkLearnMasteryBotStopped = new SDUI.Controls.CheckBox();
            label4 = new SDUI.Controls.Label();
            numMasteryGap = new SDUI.Controls.NumUpDown();
            comboLearnMastery = new SDUI.Controls.ComboBox();
            checkLearnMastery = new SDUI.Controls.CheckBox();
            groupBox3 = new SDUI.Controls.GroupBox();
            comboResurrectionSkill = new SDUI.Controls.ComboBox();
            checkAcceptResurrection = new SDUI.Controls.CheckBox();
            label3 = new SDUI.Controls.Label();
            checkResurrectParty = new SDUI.Controls.CheckBox();
            groupBox4 = new SDUI.Controls.GroupBox();
            checkCastBuffsDuringWalkBack = new SDUI.Controls.CheckBox();
            checkCastBuffsInTowns = new SDUI.Controls.CheckBox();
            tabPage5 = new TabPage();
            groupBox5_1 = new SDUI.Controls.GroupBox();
            lbMagBalanc = new Label();
            tbMagBalanc = new TextBox();
            tabControl2 = new SDUI.Controls.TabControl();
            tabPage3 = new TabPage();
            listSkills = new SDUI.Controls.ListView();
            colName = new ColumnHeader();
            colLevel = new ColumnHeader();
            skillContextMenu = new SDUI.Controls.ContextMenuStrip();
            skillContextMenuAddAttackSkill = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            skillContextMenuAddBuffSkill = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            useToolStripMenuItem = new ToolStripMenuItem();
            useToPartyMemberToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new SDUI.Controls.Panel();
            panel2 = new SDUI.Controls.Panel();
            checkHideLowerLevelSkills = new CheckBox();
            checkShowAttacks = new CheckBox();
            checkShowBuffs = new CheckBox();
            tabPage4 = new TabPage();
            listActiveBuffs = new SDUI.Controls.ListView();
            colActiveName = new ColumnHeader();
            colActiveLevel = new ColumnHeader();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            groupBox1.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupWarlockMode.SuspendLayout();
            grpMasteryLearn.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage5.SuspendLayout();
            groupBox5_1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            skillContextMenu.SuspendLayout();
            panel1.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(panel4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 10, 3, 3);
            groupBox1.Radius = 10;
            groupBox1.ShadowDepth = 4;
            groupBox1.Size = new System.Drawing.Size(363, 214);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Attacking skills";
            // 
            // panel6
            // 
            panel6.Controls.Add(listAttackingSkills);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new System.Drawing.Point(3, 26);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10, 10, 0, 10);
            panel6.Size = new System.Drawing.Size(307, 145);
            panel6.TabIndex = 13;
            // 
            // listAttackingSkills
            // 
            listAttackingSkills.BackColor = System.Drawing.Color.White;
            listAttackingSkills.Columns.AddRange(new ColumnHeader[] { columnName, columnLevel });
            listAttackingSkills.Dock = DockStyle.Fill;
            listAttackingSkills.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            listAttackingSkills.FullRowSelect = true;
            listAttackingSkills.HeaderStyle = ColumnHeaderStyle.None;
            listAttackingSkills.Location = new System.Drawing.Point(10, 10);
            listAttackingSkills.Name = "listAttackingSkills";
            listAttackingSkills.Size = new System.Drawing.Size(297, 125);
            listAttackingSkills.TabIndex = 8;
            listAttackingSkills.UseCompatibleStateImageBehavior = false;
            listAttackingSkills.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 248;
            // 
            // columnLevel
            // 
            columnLevel.Text = "Level";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnRemoveAttackSkill);
            flowLayoutPanel1.Controls.Add(btnMoveAttackSkillUp);
            flowLayoutPanel1.Controls.Add(btnMoveAttackSkillDown);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new System.Drawing.Point(310, 26);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(9, 10, 9, 10);
            flowLayoutPanel1.Size = new System.Drawing.Size(50, 145);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // btnRemoveAttackSkill
            // 
            btnRemoveAttackSkill.Color = System.Drawing.Color.Transparent;
            btnRemoveAttackSkill.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRemoveAttackSkill.Location = new System.Drawing.Point(9, 10);
            btnRemoveAttackSkill.Margin = new Padding(0);
            btnRemoveAttackSkill.Name = "btnRemoveAttackSkill";
            btnRemoveAttackSkill.Radius = 6;
            btnRemoveAttackSkill.ShadowDepth = 4F;
            btnRemoveAttackSkill.Size = new System.Drawing.Size(32, 32);
            btnRemoveAttackSkill.TabIndex = 1;
            btnRemoveAttackSkill.Text = "r";
            btnRemoveAttackSkill.UseVisualStyleBackColor = true;
            btnRemoveAttackSkill.Click += btnRemoveAttackSkill_Click;
            // 
            // btnMoveAttackSkillUp
            // 
            btnMoveAttackSkillUp.Color = System.Drawing.Color.Transparent;
            btnMoveAttackSkillUp.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMoveAttackSkillUp.Location = new System.Drawing.Point(9, 52);
            btnMoveAttackSkillUp.Margin = new Padding(0, 10, 0, 0);
            btnMoveAttackSkillUp.Name = "btnMoveAttackSkillUp";
            btnMoveAttackSkillUp.Radius = 6;
            btnMoveAttackSkillUp.ShadowDepth = 4F;
            btnMoveAttackSkillUp.Size = new System.Drawing.Size(32, 32);
            btnMoveAttackSkillUp.TabIndex = 1;
            btnMoveAttackSkillUp.Text = "5";
            btnMoveAttackSkillUp.UseVisualStyleBackColor = true;
            btnMoveAttackSkillUp.Click += btnMoveAttackSkillUp_Click;
            // 
            // btnMoveAttackSkillDown
            // 
            btnMoveAttackSkillDown.Color = System.Drawing.Color.Transparent;
            btnMoveAttackSkillDown.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMoveAttackSkillDown.Location = new System.Drawing.Point(9, 94);
            btnMoveAttackSkillDown.Margin = new Padding(0, 10, 0, 0);
            btnMoveAttackSkillDown.Name = "btnMoveAttackSkillDown";
            btnMoveAttackSkillDown.Radius = 6;
            btnMoveAttackSkillDown.ShadowDepth = 4F;
            btnMoveAttackSkillDown.Size = new System.Drawing.Size(32, 32);
            btnMoveAttackSkillDown.TabIndex = 1;
            btnMoveAttackSkillDown.Text = "6";
            btnMoveAttackSkillDown.UseVisualStyleBackColor = true;
            btnMoveAttackSkillDown.Click += btnMoveAttackSkillDown_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(comboMonsterType);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new System.Drawing.Point(3, 171);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(357, 40);
            panel4.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.Controls.Add(checkBoxNoAttack);
            panel5.Controls.Add(checkUseSkillsInOrder);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new System.Drawing.Point(237, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(120, 40);
            panel5.TabIndex = 0;
            // 
            // checkBoxNoAttack
            // 
            checkBoxNoAttack.AutoEllipsis = true;
            checkBoxNoAttack.BackColor = System.Drawing.Color.Transparent;
            checkBoxNoAttack.Location = new System.Drawing.Point(10, 1);
            checkBoxNoAttack.Margin = new Padding(0);
            checkBoxNoAttack.Name = "checkBoxNoAttack";
            checkBoxNoAttack.Padding = new Padding(0, 2, 0, 0);
            checkBoxNoAttack.Size = new System.Drawing.Size(109, 19);
            checkBoxNoAttack.TabIndex = 9;
            checkBoxNoAttack.Text = "No Attack";
            checkBoxNoAttack.UseVisualStyleBackColor = true;
            checkBoxNoAttack.CheckedChanged += checkBoxNoAttack_CheckedChanged;
            // 
            // checkUseSkillsInOrder
            // 
            checkUseSkillsInOrder.AutoEllipsis = true;
            checkUseSkillsInOrder.BackColor = System.Drawing.Color.Transparent;
            checkUseSkillsInOrder.Location = new System.Drawing.Point(10, 20);
            checkUseSkillsInOrder.Margin = new Padding(0);
            checkUseSkillsInOrder.Name = "checkUseSkillsInOrder";
            checkUseSkillsInOrder.Size = new System.Drawing.Size(109, 19);
            checkUseSkillsInOrder.TabIndex = 10;
            checkUseSkillsInOrder.Text = "Use in order";
            checkUseSkillsInOrder.UseVisualStyleBackColor = true;
            checkUseSkillsInOrder.CheckedChanged += checkUseSkillsInOrder_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.ApplyGradient = false;
            label2.AutoEllipsis = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label2.Gradient = new System.Drawing.Color[] { System.Drawing.Color.Gray, System.Drawing.Color.Black };
            label2.GradientAnimation = false;
            label2.Location = new System.Drawing.Point(10, 10);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 2, 0, 0);
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Type:";
            // 
            // comboMonsterType
            // 
            comboMonsterType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboMonsterType.DrawMode = DrawMode.OwnerDrawFixed;
            comboMonsterType.DropDownHeight = 100;
            comboMonsterType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMonsterType.FormattingEnabled = true;
            comboMonsterType.IntegralHeight = false;
            comboMonsterType.ItemHeight = 18;
            comboMonsterType.Items.AddRange(new object[] { "General (Default)", "Champion", "Giant", "General (Party)", "Champion (Party)", "Giant (Party)", "Elite", "Strong", "Unique", "Event" });
            comboMonsterType.Location = new System.Drawing.Point(65, 8);
            comboMonsterType.Margin = new Padding(5, 0, 5, 0);
            comboMonsterType.Name = "comboMonsterType";
            comboMonsterType.Radius = 5;
            comboMonsterType.ShadowDepth = 4F;
            comboMonsterType.Size = new System.Drawing.Size(160, 24);
            comboMonsterType.TabIndex = 2;
            comboMonsterType.SelectedIndexChanged += comboMonsterType_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.Controls.Add(listBuffs);
            groupBox2.Controls.Add(btnMoveBuffSkillDown);
            groupBox2.Controls.Add(comboImbue);
            groupBox2.Controls.Add(btnMoveBuffSkillUp);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnRemoveBuffSkill);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(0, 214);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 10, 3, 3);
            groupBox2.Radius = 10;
            groupBox2.ShadowDepth = 4;
            groupBox2.Size = new System.Drawing.Size(363, 215);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buffing skills";
            // 
            // listBuffs
            // 
            listBuffs.BackColor = System.Drawing.Color.White;
            listBuffs.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listBuffs.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            listBuffs.FullRowSelect = true;
            listBuffs.HeaderStyle = ColumnHeaderStyle.None;
            listBuffs.Location = new System.Drawing.Point(6, 27);
            listBuffs.Name = "listBuffs";
            listBuffs.Size = new System.Drawing.Size(315, 138);
            listBuffs.TabIndex = 8;
            listBuffs.UseCompatibleStateImageBehavior = false;
            listBuffs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 248;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Level";
            // 
            // btnMoveBuffSkillDown
            // 
            btnMoveBuffSkillDown.Color = System.Drawing.Color.Transparent;
            btnMoveBuffSkillDown.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMoveBuffSkillDown.Location = new System.Drawing.Point(327, 87);
            btnMoveBuffSkillDown.Name = "btnMoveBuffSkillDown";
            btnMoveBuffSkillDown.Radius = 6;
            btnMoveBuffSkillDown.ShadowDepth = 4F;
            btnMoveBuffSkillDown.Size = new System.Drawing.Size(24, 24);
            btnMoveBuffSkillDown.TabIndex = 8;
            btnMoveBuffSkillDown.Text = "6";
            btnMoveBuffSkillDown.UseVisualStyleBackColor = true;
            btnMoveBuffSkillDown.Click += btnMoveBuffSkillDown_Click;
            // 
            // comboImbue
            // 
            comboImbue.DrawMode = DrawMode.OwnerDrawFixed;
            comboImbue.DropDownHeight = 100;
            comboImbue.DropDownStyle = ComboBoxStyle.DropDownList;
            comboImbue.FormattingEnabled = true;
            comboImbue.IntegralHeight = false;
            comboImbue.ItemHeight = 17;
            comboImbue.Location = new System.Drawing.Point(54, 171);
            comboImbue.Name = "comboImbue";
            comboImbue.Radius = 5;
            comboImbue.ShadowDepth = 4F;
            comboImbue.Size = new System.Drawing.Size(267, 23);
            comboImbue.TabIndex = 7;
            comboImbue.SelectedIndexChanged += comboImbue_SelectedIndexChanged;
            // 
            // btnMoveBuffSkillUp
            // 
            btnMoveBuffSkillUp.Color = System.Drawing.Color.Transparent;
            btnMoveBuffSkillUp.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMoveBuffSkillUp.Location = new System.Drawing.Point(327, 57);
            btnMoveBuffSkillUp.Name = "btnMoveBuffSkillUp";
            btnMoveBuffSkillUp.Radius = 6;
            btnMoveBuffSkillUp.ShadowDepth = 4F;
            btnMoveBuffSkillUp.Size = new System.Drawing.Size(24, 24);
            btnMoveBuffSkillUp.TabIndex = 9;
            btnMoveBuffSkillUp.Text = "5";
            btnMoveBuffSkillUp.UseVisualStyleBackColor = true;
            btnMoveBuffSkillUp.Click += btnMoveBuffSkillUp_Click;
            // 
            // label1
            // 
            label1.ApplyGradient = false;
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label1.Gradient = new System.Drawing.Color[] { System.Drawing.Color.Gray, System.Drawing.Color.Black };
            label1.GradientAnimation = false;
            label1.Location = new System.Drawing.Point(9, 174);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Imbue:";
            // 
            // btnRemoveBuffSkill
            // 
            btnRemoveBuffSkill.Color = System.Drawing.Color.Transparent;
            btnRemoveBuffSkill.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRemoveBuffSkill.Location = new System.Drawing.Point(327, 27);
            btnRemoveBuffSkill.Name = "btnRemoveBuffSkill";
            btnRemoveBuffSkill.Radius = 6;
            btnRemoveBuffSkill.ShadowDepth = 4F;
            btnRemoveBuffSkill.Size = new System.Drawing.Size(24, 24);
            btnRemoveBuffSkill.TabIndex = 5;
            btnRemoveBuffSkill.Text = "r";
            btnRemoveBuffSkill.UseVisualStyleBackColor = true;
            btnRemoveBuffSkill.Click += btnRemoveBuffSkill_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new System.Drawing.Size(80, 24);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Radius = new Padding(4);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(377, 467);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.White;
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new System.Drawing.Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new System.Drawing.Size(369, 435);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General setup";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(363, 429);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.White;
            tabPage2.Controls.Add(groupWarlockMode);
            tabPage2.Controls.Add(grpMasteryLearn);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new System.Drawing.Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new System.Drawing.Size(369, 435);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Advanced setup";
            // 
            // groupWarlockMode
            // 
            groupWarlockMode.BackColor = System.Drawing.Color.Transparent;
            groupWarlockMode.Controls.Add(comboTeleportSkill);
            groupWarlockMode.Controls.Add(checkUseTeleportSkill);
            groupWarlockMode.Controls.Add(checkUseDefaultAttack);
            groupWarlockMode.Controls.Add(checkWarlockMode);
            groupWarlockMode.Location = new System.Drawing.Point(8, 313);
            groupWarlockMode.Name = "groupWarlockMode";
            groupWarlockMode.Padding = new Padding(3, 10, 3, 3);
            groupWarlockMode.Radius = 10;
            groupWarlockMode.ShadowDepth = 4;
            groupWarlockMode.Size = new System.Drawing.Size(367, 123);
            groupWarlockMode.TabIndex = 14;
            groupWarlockMode.TabStop = false;
            groupWarlockMode.Text = "Advanced setup";
            // 
            // comboTeleportSkill
            // 
            comboTeleportSkill.DrawMode = DrawMode.OwnerDrawFixed;
            comboTeleportSkill.DropDownHeight = 100;
            comboTeleportSkill.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTeleportSkill.FormattingEnabled = true;
            comboTeleportSkill.IntegralHeight = false;
            comboTeleportSkill.ItemHeight = 16;
            comboTeleportSkill.Location = new System.Drawing.Point(141, 88);
            comboTeleportSkill.Name = "comboTeleportSkill";
            comboTeleportSkill.Radius = 5;
            comboTeleportSkill.ShadowDepth = 4F;
            comboTeleportSkill.Size = new System.Drawing.Size(208, 22);
            comboTeleportSkill.TabIndex = 9;
            comboTeleportSkill.SelectedIndexChanged += comboTeleportSkill_SelectedIndexChanged;
            // 
            // checkUseTeleportSkill
            // 
            checkUseTeleportSkill.AutoSize = true;
            checkUseTeleportSkill.BackColor = System.Drawing.Color.Transparent;
            checkUseTeleportSkill.Depth = 0;
            checkUseTeleportSkill.Location = new System.Drawing.Point(15, 84);
            checkUseTeleportSkill.Margin = new Padding(0);
            checkUseTeleportSkill.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseTeleportSkill.Name = "checkUseTeleportSkill";
            checkUseTeleportSkill.Ripple = true;
            checkUseTeleportSkill.Size = new System.Drawing.Size(123, 30);
            checkUseTeleportSkill.TabIndex = 2;
            checkUseTeleportSkill.Text = "Use teleport skill:";
            checkUseTeleportSkill.UseVisualStyleBackColor = false;
            checkUseTeleportSkill.CheckedChanged += checkUseTeleportSkill_CheckedChanged;
            // 
            // checkUseDefaultAttack
            // 
            checkUseDefaultAttack.AutoSize = true;
            checkUseDefaultAttack.BackColor = System.Drawing.Color.Transparent;
            checkUseDefaultAttack.Depth = 0;
            checkUseDefaultAttack.Location = new System.Drawing.Point(15, 58);
            checkUseDefaultAttack.Margin = new Padding(0);
            checkUseDefaultAttack.MouseLocation = new System.Drawing.Point(-1, -1);
            checkUseDefaultAttack.Name = "checkUseDefaultAttack";
            checkUseDefaultAttack.Ripple = true;
            checkUseDefaultAttack.Size = new System.Drawing.Size(242, 30);
            checkUseDefaultAttack.TabIndex = 1;
            checkUseDefaultAttack.Text = "Use normal attack if no skill is available";
            checkUseDefaultAttack.UseVisualStyleBackColor = false;
            checkUseDefaultAttack.CheckedChanged += checkUseDefaultAttack_CheckedChanged;
            // 
            // checkWarlockMode
            // 
            checkWarlockMode.AutoSize = true;
            checkWarlockMode.BackColor = System.Drawing.Color.Transparent;
            checkWarlockMode.Depth = 0;
            checkWarlockMode.Location = new System.Drawing.Point(15, 31);
            checkWarlockMode.Margin = new Padding(0);
            checkWarlockMode.MouseLocation = new System.Drawing.Point(-1, -1);
            checkWarlockMode.Name = "checkWarlockMode";
            checkWarlockMode.Ripple = true;
            checkWarlockMode.Size = new System.Drawing.Size(177, 30);
            checkWarlockMode.TabIndex = 0;
            checkWarlockMode.Text = "Change target after 2 DoTs";
            checkWarlockMode.UseVisualStyleBackColor = false;
            checkWarlockMode.CheckedChanged += checkWarlockMode_CheckedChanged;
            // 
            // grpMasteryLearn
            // 
            grpMasteryLearn.BackColor = System.Drawing.Color.Transparent;
            grpMasteryLearn.Controls.Add(checkLearnMasteryBotStopped);
            grpMasteryLearn.Controls.Add(label4);
            grpMasteryLearn.Controls.Add(numMasteryGap);
            grpMasteryLearn.Controls.Add(comboLearnMastery);
            grpMasteryLearn.Controls.Add(checkLearnMastery);
            grpMasteryLearn.Location = new System.Drawing.Point(8, 218);
            grpMasteryLearn.Name = "grpMasteryLearn";
            grpMasteryLearn.Padding = new Padding(3, 10, 3, 3);
            grpMasteryLearn.Radius = 10;
            grpMasteryLearn.ShadowDepth = 4;
            grpMasteryLearn.Size = new System.Drawing.Size(367, 89);
            grpMasteryLearn.TabIndex = 13;
            grpMasteryLearn.TabStop = false;
            grpMasteryLearn.Text = "Mastery update";
            // 
            // checkLearnMasteryBotStopped
            // 
            checkLearnMasteryBotStopped.AutoSize = true;
            checkLearnMasteryBotStopped.BackColor = System.Drawing.Color.Transparent;
            checkLearnMasteryBotStopped.Depth = 0;
            checkLearnMasteryBotStopped.Location = new System.Drawing.Point(15, 56);
            checkLearnMasteryBotStopped.Margin = new Padding(0);
            checkLearnMasteryBotStopped.MouseLocation = new System.Drawing.Point(-1, -1);
            checkLearnMasteryBotStopped.Name = "checkLearnMasteryBotStopped";
            checkLearnMasteryBotStopped.Ripple = true;
            checkLearnMasteryBotStopped.Size = new System.Drawing.Size(165, 30);
            checkLearnMasteryBotStopped.TabIndex = 25;
            checkLearnMasteryBotStopped.Text = "Enabled if bot is stopped";
            checkLearnMasteryBotStopped.UseVisualStyleBackColor = false;
            checkLearnMasteryBotStopped.CheckedChanged += checkLearnMasteryBotStopped_CheckedChanged;
            // 
            // label4
            // 
            label4.ApplyGradient = false;
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label4.Gradient = new System.Drawing.Color[] { System.Drawing.Color.Gray, System.Drawing.Color.Black };
            label4.GradientAnimation = false;
            label4.Location = new System.Drawing.Point(243, 36);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Gap";
            // 
            // numMasteryGap
            // 
            numMasteryGap.BackColor = System.Drawing.Color.Transparent;
            numMasteryGap.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numMasteryGap.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            numMasteryGap.Location = new System.Drawing.Point(277, 32);
            numMasteryGap.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numMasteryGap.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numMasteryGap.MinimumSize = new System.Drawing.Size(80, 25);
            numMasteryGap.Name = "numMasteryGap";
            numMasteryGap.Size = new System.Drawing.Size(80, 25);
            numMasteryGap.TabIndex = 2;
            numMasteryGap.Value = new decimal(new int[] { 0, 0, 0, 0 });
            numMasteryGap.ValueChanged += numMasteryGap_ValueChanged;
            // 
            // comboLearnMastery
            // 
            comboLearnMastery.DrawMode = DrawMode.OwnerDrawFixed;
            comboLearnMastery.DropDownHeight = 100;
            comboLearnMastery.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLearnMastery.FormattingEnabled = true;
            comboLearnMastery.IntegralHeight = false;
            comboLearnMastery.ItemHeight = 17;
            comboLearnMastery.Location = new System.Drawing.Point(91, 33);
            comboLearnMastery.Name = "comboLearnMastery";
            comboLearnMastery.Radius = 5;
            comboLearnMastery.ShadowDepth = 4F;
            comboLearnMastery.Size = new System.Drawing.Size(141, 23);
            comboLearnMastery.TabIndex = 1;
            comboLearnMastery.SelectedIndexChanged += comboLearnMastery_SelectedIndexChanged;
            // 
            // checkLearnMastery
            // 
            checkLearnMastery.AutoSize = true;
            checkLearnMastery.BackColor = System.Drawing.Color.Transparent;
            checkLearnMastery.Depth = 0;
            checkLearnMastery.Location = new System.Drawing.Point(15, 29);
            checkLearnMastery.Margin = new Padding(0);
            checkLearnMastery.MouseLocation = new System.Drawing.Point(-1, -1);
            checkLearnMastery.Name = "checkLearnMastery";
            checkLearnMastery.Ripple = true;
            checkLearnMastery.Size = new System.Drawing.Size(73, 30);
            checkLearnMastery.TabIndex = 0;
            checkLearnMastery.Text = "Mastery";
            checkLearnMastery.UseVisualStyleBackColor = false;
            checkLearnMastery.CheckedChanged += checkLearnMastery_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.Transparent;
            groupBox3.Controls.Add(comboResurrectionSkill);
            groupBox3.Controls.Add(checkAcceptResurrection);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(checkResurrectParty);
            groupBox3.Location = new System.Drawing.Point(8, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 10, 3, 3);
            groupBox3.Radius = 10;
            groupBox3.ShadowDepth = 4;
            groupBox3.Size = new System.Drawing.Size(367, 119);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "General";
            // 
            // comboResurrectionSkill
            // 
            comboResurrectionSkill.DrawMode = DrawMode.OwnerDrawFixed;
            comboResurrectionSkill.DropDownHeight = 100;
            comboResurrectionSkill.DropDownStyle = ComboBoxStyle.DropDownList;
            comboResurrectionSkill.FormattingEnabled = true;
            comboResurrectionSkill.IntegralHeight = false;
            comboResurrectionSkill.ItemHeight = 17;
            comboResurrectionSkill.Location = new System.Drawing.Point(86, 32);
            comboResurrectionSkill.Name = "comboResurrectionSkill";
            comboResurrectionSkill.Radius = 5;
            comboResurrectionSkill.ShadowDepth = 4F;
            comboResurrectionSkill.Size = new System.Drawing.Size(255, 23);
            comboResurrectionSkill.TabIndex = 8;
            comboResurrectionSkill.SelectedIndexChanged += comboResurrectionSkill_SelectedIndexChanged;
            // 
            // checkAcceptResurrection
            // 
            checkAcceptResurrection.AutoSize = true;
            checkAcceptResurrection.BackColor = System.Drawing.Color.Transparent;
            checkAcceptResurrection.Depth = 0;
            checkAcceptResurrection.Location = new System.Drawing.Point(86, 84);
            checkAcceptResurrection.Margin = new Padding(0);
            checkAcceptResurrection.MouseLocation = new System.Drawing.Point(-1, -1);
            checkAcceptResurrection.Name = "checkAcceptResurrection";
            checkAcceptResurrection.Ripple = true;
            checkAcceptResurrection.Size = new System.Drawing.Size(163, 30);
            checkAcceptResurrection.TabIndex = 9;
            checkAcceptResurrection.Text = "Auto accept resurrection";
            checkAcceptResurrection.UseVisualStyleBackColor = false;
            checkAcceptResurrection.CheckedChanged += checkAcceptResurrection_CheckedChanged;
            // 
            // label3
            // 
            label3.ApplyGradient = false;
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label3.Gradient = new System.Drawing.Color[] { System.Drawing.Color.Gray, System.Drawing.Color.Black };
            label3.GradientAnimation = false;
            label3.Location = new System.Drawing.Point(26, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Res. skill:";
            // 
            // checkResurrectParty
            // 
            checkResurrectParty.AutoSize = true;
            checkResurrectParty.BackColor = System.Drawing.Color.Transparent;
            checkResurrectParty.Depth = 0;
            checkResurrectParty.Location = new System.Drawing.Point(86, 59);
            checkResurrectParty.Margin = new Padding(0);
            checkResurrectParty.MouseLocation = new System.Drawing.Point(-1, -1);
            checkResurrectParty.Name = "checkResurrectParty";
            checkResurrectParty.Ripple = true;
            checkResurrectParty.Size = new System.Drawing.Size(193, 30);
            checkResurrectParty.TabIndex = 6;
            checkResurrectParty.Text = "Auto resurrect party members";
            checkResurrectParty.UseVisualStyleBackColor = false;
            checkResurrectParty.CheckedChanged += checkResurrectParty_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = System.Drawing.Color.Transparent;
            groupBox4.Controls.Add(checkCastBuffsDuringWalkBack);
            groupBox4.Controls.Add(checkCastBuffsInTowns);
            groupBox4.Location = new System.Drawing.Point(8, 131);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 10, 3, 3);
            groupBox4.Radius = 10;
            groupBox4.ShadowDepth = 4;
            groupBox4.Size = new System.Drawing.Size(367, 81);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Advanced buff configuration";
            // 
            // checkCastBuffsDuringWalkBack
            // 
            checkCastBuffsDuringWalkBack.AutoSize = true;
            checkCastBuffsDuringWalkBack.BackColor = System.Drawing.Color.Transparent;
            checkCastBuffsDuringWalkBack.Depth = 0;
            checkCastBuffsDuringWalkBack.Location = new System.Drawing.Point(15, 48);
            checkCastBuffsDuringWalkBack.Margin = new Padding(0);
            checkCastBuffsDuringWalkBack.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCastBuffsDuringWalkBack.Name = "checkCastBuffsDuringWalkBack";
            checkCastBuffsDuringWalkBack.Ripple = true;
            checkCastBuffsDuringWalkBack.Size = new System.Drawing.Size(173, 30);
            checkCastBuffsDuringWalkBack.TabIndex = 10;
            checkCastBuffsDuringWalkBack.Text = "Cast buffs while walk-back";
            checkCastBuffsDuringWalkBack.UseVisualStyleBackColor = false;
            checkCastBuffsDuringWalkBack.CheckedChanged += checkCastBuffsWhenWalkBack_CheckedChanged;
            // 
            // checkCastBuffsInTowns
            // 
            checkCastBuffsInTowns.AutoSize = true;
            checkCastBuffsInTowns.BackColor = System.Drawing.Color.Transparent;
            checkCastBuffsInTowns.Depth = 0;
            checkCastBuffsInTowns.Location = new System.Drawing.Point(15, 26);
            checkCastBuffsInTowns.Margin = new Padding(0);
            checkCastBuffsInTowns.MouseLocation = new System.Drawing.Point(-1, -1);
            checkCastBuffsInTowns.Name = "checkCastBuffsInTowns";
            checkCastBuffsInTowns.Ripple = true;
            checkCastBuffsInTowns.Size = new System.Drawing.Size(133, 30);
            checkCastBuffsInTowns.TabIndex = 10;
            checkCastBuffsInTowns.Text = "Cast buffs in towns";
            checkCastBuffsInTowns.UseVisualStyleBackColor = false;
            checkCastBuffsInTowns.CheckedChanged += checkCastBuffsInTowns_CheckedChanged;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = System.Drawing.Color.White;
            tabPage5.Controls.Add(groupBox5_1);
            tabPage5.Location = new System.Drawing.Point(4, 28);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new System.Drawing.Size(369, 435);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Cast Skill Setting";
            // 
            // groupBox5_1
            // 
            groupBox5_1.BackColor = System.Drawing.Color.Transparent;
            groupBox5_1.Controls.Add(lbMagBalanc);
            groupBox5_1.Controls.Add(tbMagBalanc);
            groupBox5_1.Location = new System.Drawing.Point(6, 3);
            groupBox5_1.Name = "groupBox5_1";
            groupBox5_1.Padding = new Padding(3, 8, 3, 3);
            groupBox5_1.Radius = 10;
            groupBox5_1.ShadowDepth = 4;
            groupBox5_1.Size = new System.Drawing.Size(372, 101);
            groupBox5_1.TabIndex = 0;
            groupBox5_1.TabStop = false;
            groupBox5_1.Text = "General Setting";
            // 
            // lbMagBalanc
            // 
            lbMagBalanc.AutoSize = true;
            lbMagBalanc.Location = new System.Drawing.Point(6, 30);
            lbMagBalanc.Name = "lbMagBalanc";
            lbMagBalanc.Size = new System.Drawing.Size(84, 15);
            lbMagBalanc.TabIndex = 1;
            lbMagBalanc.Text = "Magic Balance";
            // 
            // tbMagBalanc
            // 
            tbMagBalanc.Location = new System.Drawing.Point(96, 27);
            tbMagBalanc.Name = "tbMagBalanc";
            tbMagBalanc.Size = new System.Drawing.Size(54, 23);
            tbMagBalanc.TabIndex = 0;
            tbMagBalanc.TextChanged += tbMagBalanc_TextChanged;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.ItemSize = new System.Drawing.Size(80, 24);
            tabControl2.Location = new System.Drawing.Point(0, 0);
            tabControl2.Margin = new Padding(0);
            tabControl2.Name = "tabControl2";
            tabControl2.Radius = new Padding(4);
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(377, 467);
            tabControl2.TabIndex = 6;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.White;
            tabPage3.Controls.Add(listSkills);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new System.Drawing.Point(4, 28);
            tabPage3.Margin = new Padding(0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(369, 435);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Player skills";
            // 
            // listSkills
            // 
            listSkills.BackColor = System.Drawing.Color.White;
            listSkills.BorderStyle = BorderStyle.None;
            listSkills.Columns.AddRange(new ColumnHeader[] { colName, colLevel });
            listSkills.ContextMenuStrip = skillContextMenu;
            listSkills.Dock = DockStyle.Fill;
            listSkills.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            listSkills.FullRowSelect = true;
            listSkills.HeaderStyle = ColumnHeaderStyle.None;
            listSkills.Location = new System.Drawing.Point(0, 0);
            listSkills.Name = "listSkills";
            listSkills.Size = new System.Drawing.Size(369, 395);
            listSkills.TabIndex = 5;
            listSkills.UseCompatibleStateImageBehavior = false;
            listSkills.View = System.Windows.Forms.View.Details;
            listSkills.MouseDoubleClick += listSkills_MouseDoubleClick;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 226;
            // 
            // colLevel
            // 
            colLevel.Text = "";
            colLevel.Width = 69;
            // 
            // skillContextMenu
            // 
            skillContextMenu.Items.AddRange(new ToolStripItem[] { skillContextMenuAddAttackSkill, toolStripSeparator1, skillContextMenuAddBuffSkill, toolStripSeparator2, useToolStripMenuItem, useToPartyMemberToolStripMenuItem });
            skillContextMenu.Name = "skillContextMenu";
            skillContextMenu.Size = new System.Drawing.Size(186, 104);
            skillContextMenu.Opening += skillContextMenu_Opening;
            // 
            // skillContextMenuAddAttackSkill
            // 
            skillContextMenuAddAttackSkill.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            skillContextMenuAddAttackSkill.Name = "skillContextMenuAddAttackSkill";
            skillContextMenuAddAttackSkill.Size = new System.Drawing.Size(185, 22);
            skillContextMenuAddAttackSkill.Text = "Add To Attacks";
            skillContextMenuAddAttackSkill.Click += menuAddAttack_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // skillContextMenuAddBuffSkill
            // 
            skillContextMenuAddBuffSkill.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            skillContextMenuAddBuffSkill.Name = "skillContextMenuAddBuffSkill";
            skillContextMenuAddBuffSkill.Size = new System.Drawing.Size(185, 22);
            skillContextMenuAddBuffSkill.Text = "Add To Buffs";
            skillContextMenuAddBuffSkill.Click += menuAddBuff_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // useToolStripMenuItem
            // 
            useToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            useToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            useToolStripMenuItem.Name = "useToolStripMenuItem";
            useToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            useToolStripMenuItem.Text = "Use";
            useToolStripMenuItem.Click += useToolStripMenuItem_Click;
            // 
            // useToPartyMemberToolStripMenuItem
            // 
            useToPartyMemberToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            useToPartyMemberToolStripMenuItem.Name = "useToPartyMemberToolStripMenuItem";
            useToPartyMemberToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            useToPartyMemberToolStripMenuItem.Text = "Use to party member";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Border = new Padding(0, 1, 0, 0);
            panel1.BorderColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(checkHideLowerLevelSkills);
            panel1.Controls.Add(checkShowAttacks);
            panel1.Controls.Add(checkShowBuffs);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 395);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Radius = 0;
            panel1.ShadowDepth = 4F;
            panel1.Size = new System.Drawing.Size(369, 40);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.Border = new Padding(0, 0, 0, 0);
            panel2.BorderColor = System.Drawing.Color.Transparent;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Radius = 1;
            panel2.ShadowDepth = 4F;
            panel2.Size = new System.Drawing.Size(369, 1);
            panel2.TabIndex = 9;
            // 
            // checkHideLowerLevelSkills
            // 
            checkHideLowerLevelSkills.Anchor = AnchorStyles.Right;
            checkHideLowerLevelSkills.AutoEllipsis = true;
            checkHideLowerLevelSkills.BackColor = System.Drawing.Color.Transparent;
            checkHideLowerLevelSkills.Location = new System.Drawing.Point(219, 10);
            checkHideLowerLevelSkills.Margin = new Padding(0);
            checkHideLowerLevelSkills.Name = "checkHideLowerLevelSkills";
            checkHideLowerLevelSkills.Padding = new Padding(5, 2, 0, 0);
            checkHideLowerLevelSkills.Size = new System.Drawing.Size(150, 20);
            checkHideLowerLevelSkills.TabIndex = 6;
            checkHideLowerLevelSkills.Text = "Hide lower level skills";
            checkHideLowerLevelSkills.UseVisualStyleBackColor = false;
            checkHideLowerLevelSkills.CheckedChanged += Filter_CheckedChanged;
            // 
            // checkShowAttacks
            // 
            checkShowAttacks.Anchor = AnchorStyles.Left;
            checkShowAttacks.AutoEllipsis = true;
            checkShowAttacks.BackColor = System.Drawing.Color.Transparent;
            checkShowAttacks.Checked = true;
            checkShowAttacks.CheckState = CheckState.Checked;
            checkShowAttacks.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            checkShowAttacks.FlatAppearance.BorderSize = 0;
            checkShowAttacks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkShowAttacks.Location = new System.Drawing.Point(10, 10);
            checkShowAttacks.Margin = new Padding(0);
            checkShowAttacks.Name = "checkShowAttacks";
            checkShowAttacks.Padding = new Padding(5, 2, 0, 0);
            checkShowAttacks.Size = new System.Drawing.Size(100, 20);
            checkShowAttacks.TabIndex = 7;
            checkShowAttacks.Text = "Attacks 22 2 222";
            checkShowAttacks.UseVisualStyleBackColor = false;
            checkShowAttacks.CheckedChanged += Filter_CheckedChanged;
            // 
            // checkShowBuffs
            // 
            checkShowBuffs.Anchor = AnchorStyles.Left;
            checkShowBuffs.AutoEllipsis = true;
            checkShowBuffs.BackColor = System.Drawing.Color.Transparent;
            checkShowBuffs.Checked = true;
            checkShowBuffs.CheckState = CheckState.Checked;
            checkShowBuffs.Location = new System.Drawing.Point(110, 10);
            checkShowBuffs.Margin = new Padding(0);
            checkShowBuffs.Name = "checkShowBuffs";
            checkShowBuffs.Padding = new Padding(5, 2, 0, 0);
            checkShowBuffs.Size = new System.Drawing.Size(100, 20);
            checkShowBuffs.TabIndex = 8;
            checkShowBuffs.Text = "Buffs lorem ausm";
            checkShowBuffs.UseVisualStyleBackColor = false;
            checkShowBuffs.CheckedChanged += Filter_CheckedChanged;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = System.Drawing.Color.White;
            tabPage4.Controls.Add(listActiveBuffs);
            tabPage4.Location = new System.Drawing.Point(4, 28);
            tabPage4.Margin = new Padding(0);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new System.Drawing.Size(369, 435);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Active buffs";
            // 
            // listActiveBuffs
            // 
            listActiveBuffs.BackColor = System.Drawing.Color.White;
            listActiveBuffs.BorderStyle = BorderStyle.None;
            listActiveBuffs.Columns.AddRange(new ColumnHeader[] { colActiveName, colActiveLevel });
            listActiveBuffs.Dock = DockStyle.Fill;
            listActiveBuffs.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            listActiveBuffs.FullRowSelect = true;
            listActiveBuffs.HeaderStyle = ColumnHeaderStyle.None;
            listActiveBuffs.Location = new System.Drawing.Point(3, 3);
            listActiveBuffs.Margin = new Padding(0);
            listActiveBuffs.Name = "listActiveBuffs";
            listActiveBuffs.Size = new System.Drawing.Size(363, 429);
            listActiveBuffs.TabIndex = 6;
            listActiveBuffs.UseCompatibleStateImageBehavior = false;
            listActiveBuffs.View = System.Windows.Forms.View.Details;
            listActiveBuffs.MouseDoubleClick += listActiveBuffs_MouseDoubleClick;
            // 
            // colActiveName
            // 
            colActiveName.Text = "Name";
            colActiveName.Width = 226;
            // 
            // colActiveLevel
            // 
            colActiveLevel.Text = "";
            colActiveLevel.Width = 69;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tabControl2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(754, 467);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(377, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(377, 467);
            panel3.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Main";
            Size = new System.Drawing.Size(754, 467);
            groupBox1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupWarlockMode.ResumeLayout(false);
            groupWarlockMode.PerformLayout();
            grpMasteryLearn.ResumeLayout(false);
            grpMasteryLearn.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage5.ResumeLayout(false);
            groupBox5_1.ResumeLayout(false);
            groupBox5_1.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            skillContextMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SDUI.Controls.GroupBox groupBox1;
        private SDUI.Controls.GroupBox groupBox2;
        private SDUI.Controls.Button btnRemoveAttackSkill;
        private SDUI.Controls.Button btnMoveAttackSkillDown;
        private SDUI.Controls.Button btnMoveAttackSkillUp;
        private SDUI.Controls.ComboBox comboImbue;
        private SDUI.Controls.Label label1;
        private SDUI.Controls.Button btnRemoveBuffSkill;
        private SDUI.Controls.Label label2;
        private SDUI.Controls.ComboBox comboMonsterType;
        private SDUI.Controls.TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SDUI.Controls.ComboBox comboResurrectionSkill;
        private SDUI.Controls.Label label3;
        private SDUI.Controls.CheckBox checkResurrectParty;
        private SDUI.Controls.CheckBox checkAcceptResurrection;
        private SDUI.Controls.CheckBox checkCastBuffsInTowns;
        private SDUI.Controls.GroupBox groupBox3;
        private SDUI.Controls.GroupBox groupBox5_1;
        private SDUI.Controls.GroupBox groupBox4;
        private SDUI.Controls.CheckBox checkCastBuffsDuringWalkBack;
        private SDUI.Controls.TabControl tabControl2;
        private TabPage tabPage3;
        private CheckBox checkShowAttacks;

        private SDUI.Controls.ListView listSkills;
        private ColumnHeader colName;
        private ColumnHeader colLevel;
        private TabPage tabPage4;
        private SDUI.Controls.ListView listActiveBuffs;
        private ColumnHeader colActiveName;
        private ColumnHeader colActiveLevel;
        private SDUI.Controls.Button btnMoveBuffSkillDown;
        private SDUI.Controls.Button btnMoveBuffSkillUp;
        private SDUI.Controls.Panel panel1;
        private SDUI.Controls.Panel panel2;
        private SDUI.Controls.ListView listAttackingSkills;
        private ColumnHeader columnName;
        private ColumnHeader columnLevel;
        private SDUI.Controls.ListView listBuffs;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private SDUI.Controls.ContextMenuStrip skillContextMenu;

        private ToolStripMenuItem skillContextMenuAddBuffSkill;
        private ToolStripMenuItem skillContextMenuAddAttackSkill;
        private ToolStripSeparator toolStripSeparator1;
        private SDUI.Controls.GroupBox grpMasteryLearn;
        private SDUI.Controls.Label label4;
        private SDUI.Controls.NumUpDown numMasteryGap;
        private SDUI.Controls.ComboBox comboLearnMastery;
        private SDUI.Controls.CheckBox checkLearnMastery;
        private SDUI.Controls.CheckBox checkLearnMasteryBotStopped;
        private SDUI.Controls.GroupBox groupWarlockMode;
        private SDUI.Controls.CheckBox checkWarlockMode;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem useToolStripMenuItem;
        private ToolStripMenuItem useToPartyMemberToolStripMenuItem;
        private SDUI.Controls.CheckBox checkUseDefaultAttack;
        private CheckBox checkUseSkillsInOrder;
        private SDUI.Controls.ComboBox comboTeleportSkill;
        private SDUI.Controls.CheckBox checkUseTeleportSkill;
        private TabPage tabPage5;
        private TextBox textBox1;
        private Label lbMagBalanc;
        private TextBox tbMagBalanc;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private CheckBox checkHideLowerLevelSkills;
        private CheckBox checkShowBuffs;
        private CheckBox checkBoxNoAttack;
        private Panel panel4;
        private Panel panel5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel6;
    }
}
