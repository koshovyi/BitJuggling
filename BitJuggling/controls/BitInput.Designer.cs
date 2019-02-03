namespace BitJuggling
{
	partial class BitInput
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
			this.grpInput = new System.Windows.Forms.GroupBox();
			this.bitViewer1 = new BitJuggling.BitViewer();
			this.optOct = new System.Windows.Forms.RadioButton();
			this.optHex = new System.Windows.Forms.RadioButton();
			this.optBin = new System.Windows.Forms.RadioButton();
			this.optDec = new System.Windows.Forms.RadioButton();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.lblInput = new System.Windows.Forms.Label();
			this.converter1 = new BitJuggling.Converter();
			this.grpInput.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpInput
			// 
			this.grpInput.Controls.Add(this.converter1);
			this.grpInput.Controls.Add(this.bitViewer1);
			this.grpInput.Controls.Add(this.optOct);
			this.grpInput.Controls.Add(this.optHex);
			this.grpInput.Controls.Add(this.optBin);
			this.grpInput.Controls.Add(this.optDec);
			this.grpInput.Controls.Add(this.txtInput);
			this.grpInput.Controls.Add(this.lblInput);
			this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpInput.Location = new System.Drawing.Point(0, 0);
			this.grpInput.Name = "grpInput";
			this.grpInput.Size = new System.Drawing.Size(433, 127);
			this.grpInput.TabIndex = 2;
			this.grpInput.TabStop = false;
			this.grpInput.Text = "Input";
			// 
			// bitViewer1
			// 
			this.bitViewer1.Location = new System.Drawing.Point(179, 47);
			this.bitViewer1.Name = "bitViewer1";
			this.bitViewer1.Size = new System.Drawing.Size(248, 74);
			this.bitViewer1.TabIndex = 14;
			// 
			// optOct
			// 
			this.optOct.AutoSize = true;
			this.optOct.Location = new System.Drawing.Point(348, 25);
			this.optOct.Name = "optOct";
			this.optOct.Size = new System.Drawing.Size(48, 21);
			this.optOct.TabIndex = 5;
			this.optOct.Text = "oct";
			this.optOct.UseVisualStyleBackColor = true;
			// 
			// optHex
			// 
			this.optHex.AutoSize = true;
			this.optHex.Location = new System.Drawing.Point(291, 25);
			this.optHex.Name = "optHex";
			this.optHex.Size = new System.Drawing.Size(51, 21);
			this.optHex.TabIndex = 4;
			this.optHex.Text = "hex";
			this.optHex.UseVisualStyleBackColor = true;
			// 
			// optBin
			// 
			this.optBin.AutoSize = true;
			this.optBin.Location = new System.Drawing.Point(237, 25);
			this.optBin.Name = "optBin";
			this.optBin.Size = new System.Drawing.Size(48, 21);
			this.optBin.TabIndex = 3;
			this.optBin.Text = "bin";
			this.optBin.UseVisualStyleBackColor = true;
			// 
			// optDec
			// 
			this.optDec.AutoSize = true;
			this.optDec.Checked = true;
			this.optDec.Location = new System.Drawing.Point(179, 25);
			this.optDec.Name = "optDec";
			this.optDec.Size = new System.Drawing.Size(52, 21);
			this.optDec.TabIndex = 2;
			this.optDec.TabStop = true;
			this.optDec.Text = "dec";
			this.optDec.UseVisualStyleBackColor = true;
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(66, 25);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(101, 22);
			this.txtInput.TabIndex = 1;
			// 
			// lblInput
			// 
			this.lblInput.AutoSize = true;
			this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblInput.Location = new System.Drawing.Point(6, 30);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(19, 17);
			this.lblInput.TabIndex = 0;
			this.lblInput.Text = "-:";
			// 
			// converter1
			// 
			this.converter1.Location = new System.Drawing.Point(7, 51);
			this.converter1.Name = "converter1";
			this.converter1.Size = new System.Drawing.Size(140, 71);
			this.converter1.TabIndex = 15;
			// 
			// BitInput
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpInput);
			this.Name = "BitInput";
			this.Size = new System.Drawing.Size(433, 127);
			this.Load += new System.EventHandler(this.BitInput_Load);
			this.grpInput.ResumeLayout(false);
			this.grpInput.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpInput;
		private System.Windows.Forms.RadioButton optHex;
		private System.Windows.Forms.RadioButton optBin;
		private System.Windows.Forms.RadioButton optDec;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lblInput;
		private System.Windows.Forms.RadioButton optOct;
		private BitViewer bitViewer1;
		private Converter converter1;
	}
}
