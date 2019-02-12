namespace BitJuggling
{
	partial class Calculator
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
			this.optDec = new System.Windows.Forms.RadioButton();
			this.numDec = new System.Windows.Forms.NumericUpDown();
			this.optBin = new System.Windows.Forms.RadioButton();
			this.txtBin = new System.Windows.Forms.TextBox();
			this.txtHex = new System.Windows.Forms.TextBox();
			this.optHex = new System.Windows.Forms.RadioButton();
			this.numOct = new System.Windows.Forms.NumericUpDown();
			this.optOct = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.numDec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numOct)).BeginInit();
			this.SuspendLayout();
			// 
			// optDec
			// 
			this.optDec.AutoSize = true;
			this.optDec.Checked = true;
			this.optDec.Location = new System.Drawing.Point(3, 4);
			this.optDec.Name = "optDec";
			this.optDec.Size = new System.Drawing.Size(52, 21);
			this.optDec.TabIndex = 0;
			this.optDec.TabStop = true;
			this.optDec.Text = "dec";
			this.optDec.UseVisualStyleBackColor = true;
			this.optDec.CheckedChanged += new System.EventHandler(this.optNumeralSystem_CheckedChanged);
			// 
			// numDec
			// 
			this.numDec.Location = new System.Drawing.Point(75, 4);
			this.numDec.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numDec.Name = "numDec";
			this.numDec.Size = new System.Drawing.Size(98, 22);
			this.numDec.TabIndex = 1;
			this.numDec.ValueChanged += new System.EventHandler(this.numDec_ValueChanged);
			// 
			// optBin
			// 
			this.optBin.AutoSize = true;
			this.optBin.Location = new System.Drawing.Point(3, 31);
			this.optBin.Name = "optBin";
			this.optBin.Size = new System.Drawing.Size(48, 21);
			this.optBin.TabIndex = 2;
			this.optBin.Text = "bin";
			this.optBin.UseVisualStyleBackColor = true;
			this.optBin.CheckedChanged += new System.EventHandler(this.optNumeralSystem_CheckedChanged);
			// 
			// txtBin
			// 
			this.txtBin.Enabled = false;
			this.txtBin.Location = new System.Drawing.Point(75, 30);
			this.txtBin.Name = "txtBin";
			this.txtBin.Size = new System.Drawing.Size(98, 22);
			this.txtBin.TabIndex = 3;
			this.txtBin.TextChanged += new System.EventHandler(this.txtBin_TextChanged);
			this.txtBin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBin_KeyPress);
			// 
			// txtHex
			// 
			this.txtHex.Enabled = false;
			this.txtHex.Location = new System.Drawing.Point(75, 58);
			this.txtHex.Name = "txtHex";
			this.txtHex.Size = new System.Drawing.Size(98, 22);
			this.txtHex.TabIndex = 5;
			this.txtHex.TextChanged += new System.EventHandler(this.txtHex_TextChanged);
			this.txtHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex_KeyPress);
			// 
			// optHex
			// 
			this.optHex.AutoSize = true;
			this.optHex.Location = new System.Drawing.Point(3, 59);
			this.optHex.Name = "optHex";
			this.optHex.Size = new System.Drawing.Size(51, 21);
			this.optHex.TabIndex = 4;
			this.optHex.Text = "hex";
			this.optHex.UseVisualStyleBackColor = true;
			this.optHex.CheckedChanged += new System.EventHandler(this.optNumeralSystem_CheckedChanged);
			// 
			// numOct
			// 
			this.numOct.Enabled = false;
			this.numOct.Location = new System.Drawing.Point(75, 86);
			this.numOct.Maximum = new decimal(new int[] {
            377,
            0,
            0,
            0});
			this.numOct.Name = "numOct";
			this.numOct.Size = new System.Drawing.Size(98, 22);
			this.numOct.TabIndex = 7;
			this.numOct.ValueChanged += new System.EventHandler(this.numOct_ValueChanged);
			// 
			// optOct
			// 
			this.optOct.AutoSize = true;
			this.optOct.Location = new System.Drawing.Point(3, 86);
			this.optOct.Name = "optOct";
			this.optOct.Size = new System.Drawing.Size(48, 21);
			this.optOct.TabIndex = 6;
			this.optOct.Text = "oct";
			this.optOct.UseVisualStyleBackColor = true;
			this.optOct.CheckedChanged += new System.EventHandler(this.optNumeralSystem_CheckedChanged);
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numOct);
			this.Controls.Add(this.optOct);
			this.Controls.Add(this.txtHex);
			this.Controls.Add(this.optHex);
			this.Controls.Add(this.txtBin);
			this.Controls.Add(this.optBin);
			this.Controls.Add(this.numDec);
			this.Controls.Add(this.optDec);
			this.Name = "Calculator";
			this.Size = new System.Drawing.Size(178, 112);
			((System.ComponentModel.ISupportInitialize)(this.numDec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numOct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton optDec;
		private System.Windows.Forms.NumericUpDown numDec;
		private System.Windows.Forms.RadioButton optBin;
		private System.Windows.Forms.TextBox txtBin;
		private System.Windows.Forms.TextBox txtHex;
		private System.Windows.Forms.RadioButton optHex;
		private System.Windows.Forms.NumericUpDown numOct;
		private System.Windows.Forms.RadioButton optOct;
	}
}
