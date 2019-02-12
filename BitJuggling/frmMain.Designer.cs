namespace BitJuggling
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.barTrackShiftN = new System.Windows.Forms.TrackBar();
			this.tlpStatus = new System.Windows.Forms.StatusStrip();
			this.tlpStatusLink = new System.Windows.Forms.ToolStripStatusLabel();
			this.tlpMenu = new System.Windows.Forms.MenuStrip();
			this.tlpMenuMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMenuMenuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMenuWiki = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMenuWiki1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMenuWiki2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpSep5 = new System.Windows.Forms.ToolStripSeparator();
			this.tlpMenuWiki3 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMenuWiki4 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMenuWiki5 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMenuWiki6 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpSep7 = new System.Windows.Forms.ToolStripSeparator();
			this.tlpMenuWiki7 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMain = new System.Windows.Forms.ToolStrip();
			this.tlpMainInput = new System.Windows.Forms.ToolStripButton();
			this.tlpSep3 = new System.Windows.Forms.ToolStripSeparator();
			this.tlpMainInputA = new System.Windows.Forms.ToolStripDropDownButton();
			this.tlpMainInputAClear = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputAFull = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputAEqualsB = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.tlpMainInputA1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputA2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputA3 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputA4 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputA5 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputAInverse = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputB = new System.Windows.Forms.ToolStripDropDownButton();
			this.tlpMainInputBClear = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputBFull = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputBEqualsA = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.tlpMainInputB1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputB2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputB3 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputB4 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputB5 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainInputBInverse = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainOperations = new System.Windows.Forms.ToolStripDropDownButton();
			this.tlpMainOperationsSwap = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpSep4 = new System.Windows.Forms.ToolStripSeparator();
			this.tlpMainConsole = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlSettings = new System.Windows.Forms.Panel();
			this.lblShiftN = new System.Windows.Forms.Label();
			this.lblShiftNValue = new System.Windows.Forms.Label();
			this.input2 = new BitJuggling.Input();
			this.input1 = new BitJuggling.Input();
			this.bitResult6 = new BitJuggling.BitResult();
			this.bitResult5 = new BitJuggling.BitResult();
			this.bitResult4 = new BitJuggling.BitResult();
			this.bitResult3 = new BitJuggling.BitResult();
			this.bitResult2 = new BitJuggling.BitResult();
			this.bitResult1 = new BitJuggling.BitResult();
			((System.ComponentModel.ISupportInitialize)(this.barTrackShiftN)).BeginInit();
			this.tlpStatus.SuspendLayout();
			this.tlpMenu.SuspendLayout();
			this.tlpMain.SuspendLayout();
			this.pnlSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// barTrackShiftN
			// 
			this.barTrackShiftN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.barTrackShiftN.Location = new System.Drawing.Point(2, 80);
			this.barTrackShiftN.Maximum = 8;
			this.barTrackShiftN.Name = "barTrackShiftN";
			this.barTrackShiftN.Size = new System.Drawing.Size(246, 56);
			this.barTrackShiftN.TabIndex = 2;
			this.barTrackShiftN.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.barTrackShiftN.Scroll += new System.EventHandler(this.barTrackShiftN_Scroll);
			// 
			// tlpStatus
			// 
			this.tlpStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tlpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpStatusLink});
			this.tlpStatus.Location = new System.Drawing.Point(0, 802);
			this.tlpStatus.Name = "tlpStatus";
			this.tlpStatus.Size = new System.Drawing.Size(793, 25);
			this.tlpStatus.TabIndex = 4;
			this.tlpStatus.Text = "statusStrip1";
			// 
			// tlpStatusLink
			// 
			this.tlpStatusLink.IsLink = true;
			this.tlpStatusLink.Name = "tlpStatusLink";
			this.tlpStatusLink.Size = new System.Drawing.Size(98, 20);
			this.tlpStatusLink.Text = "koshovyi.com";
			this.tlpStatusLink.Click += new System.EventHandler(this.tlpStatusLink_Click);
			// 
			// tlpMenu
			// 
			this.tlpMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tlpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpMenuMenu,
            this.tlpMenuAbout,
            this.tlpMenuWiki});
			this.tlpMenu.Location = new System.Drawing.Point(0, 0);
			this.tlpMenu.Name = "tlpMenu";
			this.tlpMenu.Size = new System.Drawing.Size(793, 28);
			this.tlpMenu.TabIndex = 5;
			this.tlpMenu.Text = "menuStrip1";
			// 
			// tlpMenuMenu
			// 
			this.tlpMenuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpMenuMenuExit});
			this.tlpMenuMenu.Name = "tlpMenuMenu";
			this.tlpMenuMenu.Size = new System.Drawing.Size(58, 24);
			this.tlpMenuMenu.Text = "&Menu";
			// 
			// tlpMenuMenuExit
			// 
			this.tlpMenuMenuExit.Name = "tlpMenuMenuExit";
			this.tlpMenuMenuExit.Size = new System.Drawing.Size(108, 26);
			this.tlpMenuMenuExit.Text = "Exit";
			this.tlpMenuMenuExit.Click += new System.EventHandler(this.tlpMenuMenuExit_Click);
			// 
			// tlpMenuAbout
			// 
			this.tlpMenuAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tlpMenuAbout.Name = "tlpMenuAbout";
			this.tlpMenuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.tlpMenuAbout.Size = new System.Drawing.Size(62, 24);
			this.tlpMenuAbout.Text = "&About";
			this.tlpMenuAbout.Click += new System.EventHandler(this.tlpMenuAbout_Click);
			// 
			// tlpMenuWiki
			// 
			this.tlpMenuWiki.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpMenuWiki1,
            this.tlpMenuWiki2,
            this.tlpSep5,
            this.tlpMenuWiki3,
            this.tlpMenuWiki4,
            this.tlpMenuWiki5,
            this.tlpMenuWiki6,
            this.tlpSep7,
            this.tlpMenuWiki7});
			this.tlpMenuWiki.Name = "tlpMenuWiki";
			this.tlpMenuWiki.Size = new System.Drawing.Size(50, 24);
			this.tlpMenuWiki.Text = "&Wiki";
			// 
			// tlpMenuWiki1
			// 
			this.tlpMenuWiki1.Name = "tlpMenuWiki1";
			this.tlpMenuWiki1.Size = new System.Drawing.Size(237, 26);
			this.tlpMenuWiki1.Text = "Numeral system";
			this.tlpMenuWiki1.Click += new System.EventHandler(this.tlpMenuWiki1_Click);
			// 
			// tlpMenuWiki2
			// 
			this.tlpMenuWiki2.Name = "tlpMenuWiki2";
			this.tlpMenuWiki2.Size = new System.Drawing.Size(237, 26);
			this.tlpMenuWiki2.Text = "List of numeral systems";
			this.tlpMenuWiki2.Click += new System.EventHandler(this.tlpMenuWiki2_Click);
			// 
			// tlpSep5
			// 
			this.tlpSep5.Name = "tlpSep5";
			this.tlpSep5.Size = new System.Drawing.Size(234, 6);
			// 
			// tlpMenuWiki3
			// 
			this.tlpMenuWiki3.Name = "tlpMenuWiki3";
			this.tlpMenuWiki3.Size = new System.Drawing.Size(237, 26);
			this.tlpMenuWiki3.Text = "Binary";
			this.tlpMenuWiki3.Click += new System.EventHandler(this.tlpMenuWiki3_Click);
			// 
			// tlpMenuWiki4
			// 
			this.tlpMenuWiki4.Name = "tlpMenuWiki4";
			this.tlpMenuWiki4.Size = new System.Drawing.Size(237, 26);
			this.tlpMenuWiki4.Text = "Octal";
			this.tlpMenuWiki4.Click += new System.EventHandler(this.tlpMenuWiki4_Click);
			// 
			// tlpMenuWiki5
			// 
			this.tlpMenuWiki5.Name = "tlpMenuWiki5";
			this.tlpMenuWiki5.Size = new System.Drawing.Size(237, 26);
			this.tlpMenuWiki5.Text = "Decimal";
			this.tlpMenuWiki5.Click += new System.EventHandler(this.tlpMenuWiki5_Click);
			// 
			// tlpMenuWiki6
			// 
			this.tlpMenuWiki6.Name = "tlpMenuWiki6";
			this.tlpMenuWiki6.Size = new System.Drawing.Size(237, 26);
			this.tlpMenuWiki6.Text = "Hexadecimal";
			this.tlpMenuWiki6.Click += new System.EventHandler(this.tlpMenuWiki6_Click);
			// 
			// tlpSep7
			// 
			this.tlpSep7.Name = "tlpSep7";
			this.tlpSep7.Size = new System.Drawing.Size(234, 6);
			// 
			// tlpMenuWiki7
			// 
			this.tlpMenuWiki7.Name = "tlpMenuWiki7";
			this.tlpMenuWiki7.Size = new System.Drawing.Size(237, 26);
			this.tlpMenuWiki7.Text = "Bitwise operation";
			this.tlpMenuWiki7.Click += new System.EventHandler(this.tlpMenuWiki7_Click);
			// 
			// tlpMain
			// 
			this.tlpMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tlpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpMainInput,
            this.tlpSep3,
            this.tlpMainInputA,
            this.tlpMainInputB,
            this.tlpMainOperations,
            this.tlpSep4,
            this.tlpMainConsole});
			this.tlpMain.Location = new System.Drawing.Point(0, 28);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.Size = new System.Drawing.Size(793, 27);
			this.tlpMain.TabIndex = 6;
			this.tlpMain.Text = "toolStrip1";
			// 
			// tlpMainInput
			// 
			this.tlpMainInput.Image = ((System.Drawing.Image)(resources.GetObject("tlpMainInput.Image")));
			this.tlpMainInput.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlpMainInput.Name = "tlpMainInput";
			this.tlpMainInput.Size = new System.Drawing.Size(67, 24);
			this.tlpMainInput.Text = "Input";
			this.tlpMainInput.Click += new System.EventHandler(this.tlpMainInput_Click);
			// 
			// tlpSep3
			// 
			this.tlpSep3.Name = "tlpSep3";
			this.tlpSep3.Size = new System.Drawing.Size(6, 27);
			// 
			// tlpMainInputA
			// 
			this.tlpMainInputA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpMainInputAClear,
            this.tlpMainInputAFull,
            this.tlpMainInputAEqualsB,
            this.tlpSep1,
            this.tlpMainInputA1,
            this.tlpMainInputA2,
            this.tlpMainInputA3,
            this.tlpMainInputA4,
            this.tlpMainInputA5,
            this.tlpMainInputAInverse});
			this.tlpMainInputA.Image = ((System.Drawing.Image)(resources.GetObject("tlpMainInputA.Image")));
			this.tlpMainInputA.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlpMainInputA.Name = "tlpMainInputA";
			this.tlpMainInputA.Size = new System.Drawing.Size(53, 24);
			this.tlpMainInputA.Text = "A";
			// 
			// tlpMainInputAClear
			// 
			this.tlpMainInputAClear.Name = "tlpMainInputAClear";
			this.tlpMainInputAClear.Size = new System.Drawing.Size(158, 26);
			this.tlpMainInputAClear.Text = "A = 0";
			this.tlpMainInputAClear.Click += new System.EventHandler(this.tlpMainInputAClear_Click);
			// 
			// tlpMainInputAFull
			// 
			this.tlpMainInputAFull.Name = "tlpMainInputAFull";
			this.tlpMainInputAFull.Size = new System.Drawing.Size(158, 26);
			this.tlpMainInputAFull.Text = "A = 255";
			this.tlpMainInputAFull.Click += new System.EventHandler(this.tlpMainInputAFull_Click);
			// 
			// tlpMainInputAEqualsB
			// 
			this.tlpMainInputAEqualsB.Name = "tlpMainInputAEqualsB";
			this.tlpMainInputAEqualsB.Size = new System.Drawing.Size(158, 26);
			this.tlpMainInputAEqualsB.Text = "A = B";
			this.tlpMainInputAEqualsB.Click += new System.EventHandler(this.tlpMainInputAEqualsB_Click);
			// 
			// tlpSep1
			// 
			this.tlpSep1.Name = "tlpSep1";
			this.tlpSep1.Size = new System.Drawing.Size(155, 6);
			// 
			// tlpMainInputA1
			// 
			this.tlpMainInputA1.Name = "tlpMainInputA1";
			this.tlpMainInputA1.Size = new System.Drawing.Size(158, 26);
			this.tlpMainInputA1.Text = "A = A && B";
			this.tlpMainInputA1.Click += new System.EventHandler(this.tlpMainInputA1_Click);
			// 
			// tlpMainInputA2
			// 
			this.tlpMainInputA2.Name = "tlpMainInputA2";
			this.tlpMainInputA2.Size = new System.Drawing.Size(158, 26);
			this.tlpMainInputA2.Text = "A = A | B";
			this.tlpMainInputA2.Click += new System.EventHandler(this.tlpMainInputA2_Click);
			// 
			// tlpMainInputA3
			// 
			this.tlpMainInputA3.Name = "tlpMainInputA3";
			this.tlpMainInputA3.Size = new System.Drawing.Size(158, 26);
			this.tlpMainInputA3.Text = "A = A ^ B";
			this.tlpMainInputA3.Click += new System.EventHandler(this.tlpMainInputA3_Click);
			// 
			// tlpMainInputA4
			// 
			this.tlpMainInputA4.Name = "tlpMainInputA4";
			this.tlpMainInputA4.Size = new System.Drawing.Size(158, 26);
			this.tlpMainInputA4.Text = "A = A << n";
			this.tlpMainInputA4.Click += new System.EventHandler(this.tlpMainInputA4_Click);
			// 
			// tlpMainInputA5
			// 
			this.tlpMainInputA5.Name = "tlpMainInputA5";
			this.tlpMainInputA5.Size = new System.Drawing.Size(158, 26);
			this.tlpMainInputA5.Text = "A = A >> n";
			this.tlpMainInputA5.Click += new System.EventHandler(this.tlpMainInputA5_Click);
			// 
			// tlpMainInputAInverse
			// 
			this.tlpMainInputAInverse.Name = "tlpMainInputAInverse";
			this.tlpMainInputAInverse.Size = new System.Drawing.Size(158, 26);
			this.tlpMainInputAInverse.Text = "A = ~A";
			this.tlpMainInputAInverse.Click += new System.EventHandler(this.tlpMainInputAInverse_Click);
			// 
			// tlpMainInputB
			// 
			this.tlpMainInputB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpMainInputBClear,
            this.tlpMainInputBFull,
            this.tlpMainInputBEqualsA,
            this.tlpSep2,
            this.tlpMainInputB1,
            this.tlpMainInputB2,
            this.tlpMainInputB3,
            this.tlpMainInputB4,
            this.tlpMainInputB5,
            this.tlpMainInputBInverse});
			this.tlpMainInputB.Image = ((System.Drawing.Image)(resources.GetObject("tlpMainInputB.Image")));
			this.tlpMainInputB.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlpMainInputB.Name = "tlpMainInputB";
			this.tlpMainInputB.Size = new System.Drawing.Size(52, 24);
			this.tlpMainInputB.Text = "B";
			// 
			// tlpMainInputBClear
			// 
			this.tlpMainInputBClear.Name = "tlpMainInputBClear";
			this.tlpMainInputBClear.Size = new System.Drawing.Size(157, 26);
			this.tlpMainInputBClear.Text = "B = 0";
			this.tlpMainInputBClear.Click += new System.EventHandler(this.tlpMainInputBClear_Click);
			// 
			// tlpMainInputBFull
			// 
			this.tlpMainInputBFull.Name = "tlpMainInputBFull";
			this.tlpMainInputBFull.Size = new System.Drawing.Size(157, 26);
			this.tlpMainInputBFull.Text = "B = 255";
			this.tlpMainInputBFull.Click += new System.EventHandler(this.tlpMainInputBFull_Click);
			// 
			// tlpMainInputBEqualsA
			// 
			this.tlpMainInputBEqualsA.Name = "tlpMainInputBEqualsA";
			this.tlpMainInputBEqualsA.Size = new System.Drawing.Size(157, 26);
			this.tlpMainInputBEqualsA.Text = "B = A";
			this.tlpMainInputBEqualsA.Click += new System.EventHandler(this.tlpMainInputBEqualsA_Click);
			// 
			// tlpSep2
			// 
			this.tlpSep2.Name = "tlpSep2";
			this.tlpSep2.Size = new System.Drawing.Size(154, 6);
			// 
			// tlpMainInputB1
			// 
			this.tlpMainInputB1.Name = "tlpMainInputB1";
			this.tlpMainInputB1.Size = new System.Drawing.Size(157, 26);
			this.tlpMainInputB1.Text = "B = A && B";
			this.tlpMainInputB1.Click += new System.EventHandler(this.tlpMainInputB1_Click);
			// 
			// tlpMainInputB2
			// 
			this.tlpMainInputB2.Name = "tlpMainInputB2";
			this.tlpMainInputB2.Size = new System.Drawing.Size(157, 26);
			this.tlpMainInputB2.Text = "B = A | B";
			this.tlpMainInputB2.Click += new System.EventHandler(this.tlpMainInputB2_Click);
			// 
			// tlpMainInputB3
			// 
			this.tlpMainInputB3.Name = "tlpMainInputB3";
			this.tlpMainInputB3.Size = new System.Drawing.Size(157, 26);
			this.tlpMainInputB3.Text = "B = A ^ B";
			this.tlpMainInputB3.Click += new System.EventHandler(this.tlpMainInputB3_Click);
			// 
			// tlpMainInputB4
			// 
			this.tlpMainInputB4.Name = "tlpMainInputB4";
			this.tlpMainInputB4.Size = new System.Drawing.Size(157, 26);
			this.tlpMainInputB4.Text = "B = A << n";
			this.tlpMainInputB4.Click += new System.EventHandler(this.tlpMainInputB4_Click);
			// 
			// tlpMainInputB5
			// 
			this.tlpMainInputB5.Name = "tlpMainInputB5";
			this.tlpMainInputB5.Size = new System.Drawing.Size(157, 26);
			this.tlpMainInputB5.Text = "B = A >> n";
			this.tlpMainInputB5.Click += new System.EventHandler(this.tlpMainInputB5_Click);
			// 
			// tlpMainInputBInverse
			// 
			this.tlpMainInputBInverse.Name = "tlpMainInputBInverse";
			this.tlpMainInputBInverse.Size = new System.Drawing.Size(157, 26);
			this.tlpMainInputBInverse.Text = "B = ~B";
			this.tlpMainInputBInverse.Click += new System.EventHandler(this.tlpMainInputBInverse_Click);
			// 
			// tlpMainOperations
			// 
			this.tlpMainOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpMainOperationsSwap});
			this.tlpMainOperations.Image = ((System.Drawing.Image)(resources.GetObject("tlpMainOperations.Image")));
			this.tlpMainOperations.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlpMainOperations.Name = "tlpMainOperations";
			this.tlpMainOperations.Size = new System.Drawing.Size(116, 24);
			this.tlpMainOperations.Text = "Operations";
			// 
			// tlpMainOperationsSwap
			// 
			this.tlpMainOperationsSwap.Name = "tlpMainOperationsSwap";
			this.tlpMainOperationsSwap.Size = new System.Drawing.Size(145, 26);
			this.tlpMainOperationsSwap.Text = "A swap B";
			this.tlpMainOperationsSwap.Click += new System.EventHandler(this.tlpMainOperationsSwap_Click);
			// 
			// tlpSep4
			// 
			this.tlpSep4.Name = "tlpSep4";
			this.tlpSep4.Size = new System.Drawing.Size(6, 27);
			// 
			// tlpMainConsole
			// 
			this.tlpMainConsole.Image = ((System.Drawing.Image)(resources.GetObject("tlpMainConsole.Image")));
			this.tlpMainConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlpMainConsole.Name = "tlpMainConsole";
			this.tlpMainConsole.Size = new System.Drawing.Size(86, 24);
			this.tlpMainConsole.Text = "Console";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 317);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Result:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Inputs:";
			// 
			// pnlSettings
			// 
			this.pnlSettings.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlSettings.Controls.Add(this.lblShiftN);
			this.pnlSettings.Controls.Add(this.lblShiftNValue);
			this.pnlSettings.Controls.Add(this.barTrackShiftN);
			this.pnlSettings.Location = new System.Drawing.Point(528, 82);
			this.pnlSettings.Name = "pnlSettings";
			this.pnlSettings.Size = new System.Drawing.Size(256, 225);
			this.pnlSettings.TabIndex = 12;
			// 
			// lblShiftN
			// 
			this.lblShiftN.AutoSize = true;
			this.lblShiftN.Font = new System.Drawing.Font("Consolas", 28.2F);
			this.lblShiftN.Location = new System.Drawing.Point(3, 9);
			this.lblShiftN.Name = "lblShiftN";
			this.lblShiftN.Size = new System.Drawing.Size(232, 56);
			this.lblShiftN.TabIndex = 12;
			this.lblShiftN.Text = "Shift N:";
			// 
			// lblShiftNValue
			// 
			this.lblShiftNValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblShiftNValue.Font = new System.Drawing.Font("Consolas", 28.2F);
			this.lblShiftNValue.Location = new System.Drawing.Point(10, 151);
			this.lblShiftNValue.Name = "lblShiftNValue";
			this.lblShiftNValue.Size = new System.Drawing.Size(225, 57);
			this.lblShiftNValue.TabIndex = 11;
			this.lblShiftNValue.Text = "0";
			this.lblShiftNValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// input2
			// 
			this.input2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.input2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.input2.Location = new System.Drawing.Point(270, 82);
			this.input2.Name = "input2";
			this.input2.Size = new System.Drawing.Size(256, 225);
			this.input2.TabIndex = 11;
			this.input2.Title = "Input B:";
			this.input2.Value = ((byte)(0));
			this.input2.DecValueChanged += new System.EventHandler<BitJuggling.DecValueChangedEvent>(this.input_DecValueChanged);
			// 
			// input1
			// 
			this.input1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.input1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.input1.Location = new System.Drawing.Point(12, 82);
			this.input1.Name = "input1";
			this.input1.Size = new System.Drawing.Size(256, 225);
			this.input1.TabIndex = 10;
			this.input1.Title = "Input A:";
			this.input1.Value = ((byte)(0));
			this.input1.DecValueChanged += new System.EventHandler<BitJuggling.DecValueChangedEvent>(this.input_DecValueChanged);
			// 
			// bitResult6
			// 
			this.bitResult6.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bitResult6.BitOperations = BitJuggling.BitOperations.ONESCOMPLEMENT;
			this.bitResult6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.bitResult6.Location = new System.Drawing.Point(528, 564);
			this.bitResult6.Name = "bitResult6";
			this.bitResult6.Size = new System.Drawing.Size(256, 225);
			this.bitResult6.TabIndex = 5;
			this.bitResult6.ValueA = ((byte)(0));
			this.bitResult6.ValueB = ((byte)(0));
			this.bitResult6.ValueN = ((short)(0));
			// 
			// bitResult5
			// 
			this.bitResult5.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bitResult5.BitOperations = BitJuggling.BitOperations.RIGHTSHIFT;
			this.bitResult5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.bitResult5.Location = new System.Drawing.Point(270, 564);
			this.bitResult5.Name = "bitResult5";
			this.bitResult5.Size = new System.Drawing.Size(256, 225);
			this.bitResult5.TabIndex = 4;
			this.bitResult5.ValueA = ((byte)(0));
			this.bitResult5.ValueB = ((byte)(0));
			this.bitResult5.ValueN = ((short)(0));
			// 
			// bitResult4
			// 
			this.bitResult4.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bitResult4.BitOperations = BitJuggling.BitOperations.LEFTSHIFT;
			this.bitResult4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.bitResult4.Location = new System.Drawing.Point(12, 564);
			this.bitResult4.Name = "bitResult4";
			this.bitResult4.Size = new System.Drawing.Size(256, 225);
			this.bitResult4.TabIndex = 3;
			this.bitResult4.ValueA = ((byte)(0));
			this.bitResult4.ValueB = ((byte)(0));
			this.bitResult4.ValueN = ((short)(0));
			// 
			// bitResult3
			// 
			this.bitResult3.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bitResult3.BitOperations = BitJuggling.BitOperations.XOR;
			this.bitResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.bitResult3.Location = new System.Drawing.Point(528, 337);
			this.bitResult3.Name = "bitResult3";
			this.bitResult3.Size = new System.Drawing.Size(256, 225);
			this.bitResult3.TabIndex = 2;
			this.bitResult3.ValueA = ((byte)(0));
			this.bitResult3.ValueB = ((byte)(0));
			this.bitResult3.ValueN = ((short)(0));
			// 
			// bitResult2
			// 
			this.bitResult2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bitResult2.BitOperations = BitJuggling.BitOperations.OR;
			this.bitResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.bitResult2.Location = new System.Drawing.Point(270, 337);
			this.bitResult2.Name = "bitResult2";
			this.bitResult2.Size = new System.Drawing.Size(256, 225);
			this.bitResult2.TabIndex = 1;
			this.bitResult2.ValueA = ((byte)(0));
			this.bitResult2.ValueB = ((byte)(0));
			this.bitResult2.ValueN = ((short)(0));
			// 
			// bitResult1
			// 
			this.bitResult1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bitResult1.BitOperations = BitJuggling.BitOperations.AND;
			this.bitResult1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.bitResult1.Location = new System.Drawing.Point(12, 337);
			this.bitResult1.Name = "bitResult1";
			this.bitResult1.Size = new System.Drawing.Size(256, 225);
			this.bitResult1.TabIndex = 0;
			this.bitResult1.ValueA = ((byte)(0));
			this.bitResult1.ValueB = ((byte)(0));
			this.bitResult1.ValueN = ((short)(0));
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(793, 827);
			this.Controls.Add(this.pnlSettings);
			this.Controls.Add(this.input2);
			this.Controls.Add(this.input1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tlpMain);
			this.Controls.Add(this.bitResult6);
			this.Controls.Add(this.bitResult5);
			this.Controls.Add(this.bitResult4);
			this.Controls.Add(this.tlpStatus);
			this.Controls.Add(this.bitResult3);
			this.Controls.Add(this.tlpMenu);
			this.Controls.Add(this.bitResult2);
			this.Controls.Add(this.bitResult1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.tlpMenu;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bit Juggling - Bit Calculator";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.barTrackShiftN)).EndInit();
			this.tlpStatus.ResumeLayout(false);
			this.tlpStatus.PerformLayout();
			this.tlpMenu.ResumeLayout(false);
			this.tlpMenu.PerformLayout();
			this.tlpMain.ResumeLayout(false);
			this.tlpMain.PerformLayout();
			this.pnlSettings.ResumeLayout(false);
			this.pnlSettings.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TrackBar barTrackShiftN;
		private System.Windows.Forms.StatusStrip tlpStatus;
		private System.Windows.Forms.MenuStrip tlpMenu;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuMenu;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuAbout;
		private BitResult bitResult1;
		private BitResult bitResult6;
		private BitResult bitResult5;
		private BitResult bitResult4;
		private BitResult bitResult3;
		private BitResult bitResult2;
		private System.Windows.Forms.ToolStrip tlpMain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Input input1;
		private Input input2;
		private System.Windows.Forms.Panel pnlSettings;
		private System.Windows.Forms.Label lblShiftNValue;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuWiki;
		private System.Windows.Forms.ToolStripStatusLabel tlpStatusLink;
		private System.Windows.Forms.ToolStripDropDownButton tlpMainOperations;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuMenuExit;
		private System.Windows.Forms.ToolStripButton tlpMainInput;
		private System.Windows.Forms.ToolStripSeparator tlpSep3;
		private System.Windows.Forms.Label lblShiftN;
		private System.Windows.Forms.ToolStripDropDownButton tlpMainInputA;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputAClear;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputAInverse;
		private System.Windows.Forms.ToolStripDropDownButton tlpMainInputB;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputBClear;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputBInverse;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuWiki1;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuWiki2;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputAFull;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputBFull;
		private System.Windows.Forms.ToolStripSeparator tlpSep1;
		private System.Windows.Forms.ToolStripSeparator tlpSep2;
		private System.Windows.Forms.ToolStripSeparator tlpSep4;
		private System.Windows.Forms.ToolStripButton tlpMainConsole;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputA1;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputA2;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputA3;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputA4;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputA5;
		private System.Windows.Forms.ToolStripMenuItem tlpMainOperationsSwap;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputB1;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputB2;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputB3;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputB4;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputB5;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputAEqualsB;
		private System.Windows.Forms.ToolStripMenuItem tlpMainInputBEqualsA;
		private System.Windows.Forms.ToolStripSeparator tlpSep5;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuWiki3;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuWiki4;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuWiki5;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuWiki6;
		private System.Windows.Forms.ToolStripSeparator tlpSep7;
		private System.Windows.Forms.ToolStripMenuItem tlpMenuWiki7;
	}
}

