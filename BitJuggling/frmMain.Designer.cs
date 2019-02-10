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
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tlpMenu = new System.Windows.Forms.MenuStrip();
			this.tlpMenuMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMain = new System.Windows.Forms.ToolStrip();
			this.tlpMainClean = new System.Windows.Forms.ToolStripButton();
			this.tlpMainInputA = new System.Windows.Forms.ToolStripSplitButton();
			this.tlpMainInputB = new System.Windows.Forms.ToolStripSplitButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlSettings = new System.Windows.Forms.Panel();
			this.lblShiftNValue = new System.Windows.Forms.Label();
			this.lblShiftN = new System.Windows.Forms.Label();
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
			this.barTrackShiftN.Location = new System.Drawing.Point(3, 20);
			this.barTrackShiftN.Maximum = 16;
			this.barTrackShiftN.Minimum = -16;
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
            this.toolStripStatusLabel1});
			this.tlpStatus.Location = new System.Drawing.Point(0, 802);
			this.tlpStatus.Name = "tlpStatus";
			this.tlpStatus.Size = new System.Drawing.Size(793, 25);
			this.tlpStatus.TabIndex = 4;
			this.tlpStatus.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(30, 20);
			this.toolStripStatusLabel1.Text = "Bit:";
			// 
			// tlpMenu
			// 
			this.tlpMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tlpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpMenuMenu,
            this.tlpMenuAbout});
			this.tlpMenu.Location = new System.Drawing.Point(0, 0);
			this.tlpMenu.Name = "tlpMenu";
			this.tlpMenu.Size = new System.Drawing.Size(793, 28);
			this.tlpMenu.TabIndex = 5;
			this.tlpMenu.Text = "menuStrip1";
			// 
			// tlpMenuMenu
			// 
			this.tlpMenuMenu.Name = "tlpMenuMenu";
			this.tlpMenuMenu.Size = new System.Drawing.Size(58, 24);
			this.tlpMenuMenu.Text = "&Menu";
			// 
			// tlpMenuAbout
			// 
			this.tlpMenuAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tlpMenuAbout.Name = "tlpMenuAbout";
			this.tlpMenuAbout.Size = new System.Drawing.Size(62, 24);
			this.tlpMenuAbout.Text = "&About";
			// 
			// tlpMain
			// 
			this.tlpMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tlpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpMainClean,
            this.tlpMainInputA,
            this.tlpMainInputB});
			this.tlpMain.Location = new System.Drawing.Point(0, 28);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.Size = new System.Drawing.Size(793, 27);
			this.tlpMain.TabIndex = 6;
			this.tlpMain.Text = "toolStrip1";
			// 
			// tlpMainClean
			// 
			this.tlpMainClean.Image = ((System.Drawing.Image)(resources.GetObject("tlpMainClean.Image")));
			this.tlpMainClean.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlpMainClean.Name = "tlpMainClean";
			this.tlpMainClean.Size = new System.Drawing.Size(70, 24);
			this.tlpMainClean.Text = "Clean";
			// 
			// tlpMainInputA
			// 
			this.tlpMainInputA.Image = ((System.Drawing.Image)(resources.GetObject("tlpMainInputA.Image")));
			this.tlpMainInputA.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlpMainInputA.Name = "tlpMainInputA";
			this.tlpMainInputA.Size = new System.Drawing.Size(58, 24);
			this.tlpMainInputA.Text = "A";
			// 
			// tlpMainInputB
			// 
			this.tlpMainInputB.Image = ((System.Drawing.Image)(resources.GetObject("tlpMainInputB.Image")));
			this.tlpMainInputB.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlpMainInputB.Name = "tlpMainInputB";
			this.tlpMainInputB.Size = new System.Drawing.Size(57, 24);
			this.tlpMainInputB.Text = "B";
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
			this.pnlSettings.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlSettings.Controls.Add(this.lblShiftNValue);
			this.pnlSettings.Controls.Add(this.lblShiftN);
			this.pnlSettings.Controls.Add(this.barTrackShiftN);
			this.pnlSettings.Location = new System.Drawing.Point(528, 82);
			this.pnlSettings.Name = "pnlSettings";
			this.pnlSettings.Size = new System.Drawing.Size(256, 225);
			this.pnlSettings.TabIndex = 12;
			// 
			// lblShiftNValue
			// 
			this.lblShiftNValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblShiftNValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblShiftNValue.Location = new System.Drawing.Point(209, 0);
			this.lblShiftNValue.Name = "lblShiftNValue";
			this.lblShiftNValue.Size = new System.Drawing.Size(40, 17);
			this.lblShiftNValue.TabIndex = 11;
			this.lblShiftNValue.Text = "0";
			this.lblShiftNValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblShiftN
			// 
			this.lblShiftN.AutoSize = true;
			this.lblShiftN.Location = new System.Drawing.Point(3, 0);
			this.lblShiftN.Name = "lblShiftN";
			this.lblShiftN.Size = new System.Drawing.Size(102, 17);
			this.lblShiftN.TabIndex = 10;
			this.lblShiftN.Text = "Shift value (N):";
			// 
			// input2
			// 
			this.input2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.input2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.input2.Location = new System.Drawing.Point(270, 82);
			this.input2.Name = "input2";
			this.input2.Size = new System.Drawing.Size(256, 225);
			this.input2.TabIndex = 11;
			this.input2.Title = "Input B:";
			this.input2.Value = 0;
			this.input2.DecValueChanged += new System.EventHandler<BitJuggling.DecValueChangedEvent>(this.input_DecValueChanged);
			// 
			// input1
			// 
			this.input1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.input1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.input1.Location = new System.Drawing.Point(12, 82);
			this.input1.Name = "input1";
			this.input1.Size = new System.Drawing.Size(256, 225);
			this.input1.TabIndex = 10;
			this.input1.Title = "Input A:";
			this.input1.Value = 0;
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
			this.bitResult6.ValueA = 0;
			this.bitResult6.ValueB = 0;
			this.bitResult6.ValueN = 0;
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
			this.bitResult5.ValueA = 0;
			this.bitResult5.ValueB = 0;
			this.bitResult5.ValueN = 0;
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
			this.bitResult4.ValueA = 0;
			this.bitResult4.ValueB = 0;
			this.bitResult4.ValueN = 0;
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
			this.bitResult3.ValueA = 0;
			this.bitResult3.ValueB = 0;
			this.bitResult3.ValueN = 0;
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
			this.bitResult2.ValueA = 0;
			this.bitResult2.ValueB = 0;
			this.bitResult2.ValueN = 0;
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
			this.bitResult1.ValueA = 0;
			this.bitResult1.ValueB = 0;
			this.bitResult1.ValueN = 0;
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
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BitJuggling - bit calculator";
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
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private BitResult bitResult1;
		private BitResult bitResult6;
		private BitResult bitResult5;
		private BitResult bitResult4;
		private BitResult bitResult3;
		private BitResult bitResult2;
		private System.Windows.Forms.ToolStrip tlpMain;
		private System.Windows.Forms.ToolStripButton tlpMainClean;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Input input1;
		private Input input2;
		private System.Windows.Forms.Panel pnlSettings;
		private System.Windows.Forms.Label lblShiftN;
		private System.Windows.Forms.ToolStripSplitButton tlpMainInputA;
		private System.Windows.Forms.ToolStripSplitButton tlpMainInputB;
		private System.Windows.Forms.Label lblShiftNValue;
	}
}

