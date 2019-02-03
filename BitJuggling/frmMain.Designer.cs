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
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tlpStatus = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tlpMain = new System.Windows.Forms.MenuStrip();
			this.tlpMainMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.tlpMainAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.bitResult6 = new BitJuggling.BitResult();
			this.bitResult5 = new BitJuggling.BitResult();
			this.bitResult4 = new BitJuggling.BitResult();
			this.bitResult3 = new BitJuggling.BitResult();
			this.bitResult2 = new BitJuggling.BitResult();
			this.bitResult1 = new BitJuggling.BitResult();
			this.bitInput2 = new BitJuggling.BitInput();
			this.bitInput1 = new BitJuggling.BitInput();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tlpStatus.SuspendLayout();
			this.tlpMain.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(6, 21);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(421, 56);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Location = new System.Drawing.Point(12, 304);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(433, 84);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Shift value";
			// 
			// tlpStatus
			// 
			this.tlpStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tlpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.tlpStatus.Location = new System.Drawing.Point(0, 571);
			this.tlpStatus.Name = "tlpStatus";
			this.tlpStatus.Size = new System.Drawing.Size(1082, 25);
			this.tlpStatus.TabIndex = 4;
			this.tlpStatus.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(30, 20);
			this.toolStripStatusLabel1.Text = "Bit:";
			// 
			// tlpMain
			// 
			this.tlpMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tlpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlpMainMenu,
            this.tlpMainAbout});
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.Size = new System.Drawing.Size(1082, 28);
			this.tlpMain.TabIndex = 5;
			this.tlpMain.Text = "menuStrip1";
			// 
			// tlpMainMenu
			// 
			this.tlpMainMenu.Name = "tlpMainMenu";
			this.tlpMainMenu.Size = new System.Drawing.Size(58, 24);
			this.tlpMainMenu.Text = "&Menu";
			// 
			// tlpMainAbout
			// 
			this.tlpMainAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tlpMainAbout.Name = "tlpMainAbout";
			this.tlpMainAbout.Size = new System.Drawing.Size(62, 24);
			this.tlpMainAbout.Text = "&About";
			// 
			// bitResult6
			// 
			this.bitResult6.BitOperations = BitJuggling.BitOperations.ONESCOMPLEMENT;
			this.bitResult6.Location = new System.Drawing.Point(6, 442);
			this.bitResult6.Name = "bitResult6";
			this.bitResult6.Size = new System.Drawing.Size(599, 78);
			this.bitResult6.TabIndex = 11;
			// 
			// bitResult5
			// 
			this.bitResult5.BitOperations = BitJuggling.BitOperations.RIGHTSHIFT;
			this.bitResult5.Location = new System.Drawing.Point(6, 358);
			this.bitResult5.Name = "bitResult5";
			this.bitResult5.Size = new System.Drawing.Size(599, 78);
			this.bitResult5.TabIndex = 10;
			// 
			// bitResult4
			// 
			this.bitResult4.BitOperations = BitJuggling.BitOperations.LEFTSHIFT;
			this.bitResult4.Location = new System.Drawing.Point(6, 274);
			this.bitResult4.Name = "bitResult4";
			this.bitResult4.Size = new System.Drawing.Size(599, 78);
			this.bitResult4.TabIndex = 9;
			// 
			// bitResult3
			// 
			this.bitResult3.BitOperations = BitJuggling.BitOperations.XOR;
			this.bitResult3.Location = new System.Drawing.Point(6, 190);
			this.bitResult3.Name = "bitResult3";
			this.bitResult3.Size = new System.Drawing.Size(599, 78);
			this.bitResult3.TabIndex = 8;
			// 
			// bitResult2
			// 
			this.bitResult2.BitOperations = BitJuggling.BitOperations.OR;
			this.bitResult2.Location = new System.Drawing.Point(6, 106);
			this.bitResult2.Name = "bitResult2";
			this.bitResult2.Size = new System.Drawing.Size(599, 78);
			this.bitResult2.TabIndex = 7;
			// 
			// bitResult1
			// 
			this.bitResult1.BitOperations = BitJuggling.BitOperations.AND;
			this.bitResult1.Location = new System.Drawing.Point(6, 22);
			this.bitResult1.Name = "bitResult1";
			this.bitResult1.Size = new System.Drawing.Size(599, 78);
			this.bitResult1.TabIndex = 6;
			// 
			// bitInput2
			// 
			this.bitInput2.InputName = "B";
			this.bitInput2.Location = new System.Drawing.Point(12, 171);
			this.bitInput2.Name = "bitInput2";
			this.bitInput2.Size = new System.Drawing.Size(433, 127);
			this.bitInput2.TabIndex = 1;
			// 
			// bitInput1
			// 
			this.bitInput1.InputName = "A";
			this.bitInput1.Location = new System.Drawing.Point(12, 38);
			this.bitInput1.Name = "bitInput1";
			this.bitInput1.Size = new System.Drawing.Size(433, 127);
			this.bitInput1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.bitResult1);
			this.groupBox2.Controls.Add(this.bitResult6);
			this.groupBox2.Controls.Add(this.bitResult2);
			this.groupBox2.Controls.Add(this.bitResult5);
			this.groupBox2.Controls.Add(this.bitResult3);
			this.groupBox2.Controls.Add(this.bitResult4);
			this.groupBox2.Location = new System.Drawing.Point(451, 38);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(619, 527);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Result";
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(12, 396);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(433, 169);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1082, 596);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.tlpStatus);
			this.Controls.Add(this.tlpMain);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.bitInput2);
			this.Controls.Add(this.bitInput1);
			this.MainMenuStrip = this.tlpMain;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BitJuggling - bit calculator";
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tlpStatus.ResumeLayout(false);
			this.tlpStatus.PerformLayout();
			this.tlpMain.ResumeLayout(false);
			this.tlpMain.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BitInput bitInput1;
		private BitInput bitInput2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.StatusStrip tlpStatus;
		private System.Windows.Forms.MenuStrip tlpMain;
		private System.Windows.Forms.ToolStripMenuItem tlpMainMenu;
		private System.Windows.Forms.ToolStripMenuItem tlpMainAbout;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private BitResult bitResult1;
		private BitResult bitResult2;
		private BitResult bitResult3;
		private BitResult bitResult4;
		private BitResult bitResult5;
		private BitResult bitResult6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
	}
}

