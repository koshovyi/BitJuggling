namespace BitJuggling
{
	partial class BitViewer
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpBits = new System.Windows.Forms.GroupBox();
			this.bitItem8 = new BitJuggling.BitItem();
			this.bitItem7 = new BitJuggling.BitItem();
			this.bitItem6 = new BitJuggling.BitItem();
			this.bitItem5 = new BitJuggling.BitItem();
			this.bitItem4 = new BitJuggling.BitItem();
			this.bitItem3 = new BitJuggling.BitItem();
			this.bitItem2 = new BitJuggling.BitItem();
			this.bitItem1 = new BitJuggling.BitItem();
			this.grpBits.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpBits
			// 
			this.grpBits.Controls.Add(this.bitItem8);
			this.grpBits.Controls.Add(this.bitItem7);
			this.grpBits.Controls.Add(this.bitItem6);
			this.grpBits.Controls.Add(this.bitItem5);
			this.grpBits.Controls.Add(this.bitItem4);
			this.grpBits.Controls.Add(this.bitItem3);
			this.grpBits.Controls.Add(this.bitItem2);
			this.grpBits.Controls.Add(this.bitItem1);
			this.grpBits.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpBits.Location = new System.Drawing.Point(0, 0);
			this.grpBits.Name = "grpBits";
			this.grpBits.Size = new System.Drawing.Size(248, 74);
			this.grpBits.TabIndex = 15;
			this.grpBits.TabStop = false;
			this.grpBits.Text = "Bits";
			// 
			// bitItem8
			// 
			this.bitItem8.AutoCheck = true;
			this.bitItem8.Checked = false;
			this.bitItem8.Location = new System.Drawing.Point(216, 19);
			this.bitItem8.Name = "bitItem8";
			this.bitItem8.Size = new System.Drawing.Size(24, 49);
			this.bitItem8.TabIndex = 7;
			this.bitItem8.BitStateChanged += new System.EventHandler<BitJuggling.BitStateChangedEvent>(this.bitItem_BitStateChanged);
			// 
			// bitItem7
			// 
			this.bitItem7.AutoCheck = true;
			this.bitItem7.Checked = false;
			this.bitItem7.Location = new System.Drawing.Point(186, 19);
			this.bitItem7.Name = "bitItem7";
			this.bitItem7.Size = new System.Drawing.Size(24, 49);
			this.bitItem7.TabIndex = 6;
			this.bitItem7.BitStateChanged += new System.EventHandler<BitJuggling.BitStateChangedEvent>(this.bitItem_BitStateChanged);
			// 
			// bitItem6
			// 
			this.bitItem6.AutoCheck = true;
			this.bitItem6.Checked = false;
			this.bitItem6.Location = new System.Drawing.Point(156, 19);
			this.bitItem6.Name = "bitItem6";
			this.bitItem6.Size = new System.Drawing.Size(24, 49);
			this.bitItem6.TabIndex = 5;
			this.bitItem6.BitStateChanged += new System.EventHandler<BitJuggling.BitStateChangedEvent>(this.bitItem_BitStateChanged);
			// 
			// bitItem5
			// 
			this.bitItem5.AutoCheck = true;
			this.bitItem5.Checked = false;
			this.bitItem5.Location = new System.Drawing.Point(126, 19);
			this.bitItem5.Name = "bitItem5";
			this.bitItem5.Size = new System.Drawing.Size(24, 49);
			this.bitItem5.TabIndex = 4;
			this.bitItem5.BitStateChanged += new System.EventHandler<BitJuggling.BitStateChangedEvent>(this.bitItem_BitStateChanged);
			// 
			// bitItem4
			// 
			this.bitItem4.AutoCheck = true;
			this.bitItem4.Checked = false;
			this.bitItem4.Location = new System.Drawing.Point(96, 19);
			this.bitItem4.Name = "bitItem4";
			this.bitItem4.Size = new System.Drawing.Size(24, 49);
			this.bitItem4.TabIndex = 3;
			this.bitItem4.BitStateChanged += new System.EventHandler<BitJuggling.BitStateChangedEvent>(this.bitItem_BitStateChanged);
			// 
			// bitItem3
			// 
			this.bitItem3.AutoCheck = true;
			this.bitItem3.Checked = false;
			this.bitItem3.Location = new System.Drawing.Point(66, 19);
			this.bitItem3.Name = "bitItem3";
			this.bitItem3.Size = new System.Drawing.Size(24, 49);
			this.bitItem3.TabIndex = 2;
			this.bitItem3.BitStateChanged += new System.EventHandler<BitJuggling.BitStateChangedEvent>(this.bitItem_BitStateChanged);
			// 
			// bitItem2
			// 
			this.bitItem2.AutoCheck = true;
			this.bitItem2.Checked = false;
			this.bitItem2.Location = new System.Drawing.Point(36, 19);
			this.bitItem2.Name = "bitItem2";
			this.bitItem2.Size = new System.Drawing.Size(24, 49);
			this.bitItem2.TabIndex = 1;
			this.bitItem2.BitStateChanged += new System.EventHandler<BitJuggling.BitStateChangedEvent>(this.bitItem_BitStateChanged);
			// 
			// bitItem1
			// 
			this.bitItem1.AutoCheck = true;
			this.bitItem1.Checked = false;
			this.bitItem1.Location = new System.Drawing.Point(6, 19);
			this.bitItem1.Name = "bitItem1";
			this.bitItem1.Size = new System.Drawing.Size(24, 49);
			this.bitItem1.TabIndex = 0;
			this.bitItem1.BitStateChanged += new System.EventHandler<BitJuggling.BitStateChangedEvent>(this.bitItem_BitStateChanged);
			// 
			// BitViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpBits);
			this.Name = "BitViewer";
			this.Size = new System.Drawing.Size(248, 74);
			this.grpBits.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpBits;
		private BitItem bitItem8;
		private BitItem bitItem7;
		private BitItem bitItem6;
		private BitItem bitItem5;
		private BitItem bitItem4;
		private BitItem bitItem3;
		private BitItem bitItem2;
		private BitItem bitItem1;
	}
}
