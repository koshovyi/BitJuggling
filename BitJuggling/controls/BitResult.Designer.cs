namespace BitJuggling
{
	partial class BitResult
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.converter1 = new BitJuggling.Converter();
			this.bitViewer1 = new BitJuggling.BitViewer();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Consolas", 28.2F);
			this.lblTitle.Location = new System.Drawing.Point(3, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(180, 56);
			this.lblTitle.TabIndex = 9;
			this.lblTitle.Text = "A && B:";
			// 
			// converter1
			// 
			this.converter1.Location = new System.Drawing.Point(451, 5);
			this.converter1.Name = "converter1";
			this.converter1.Size = new System.Drawing.Size(140, 71);
			this.converter1.TabIndex = 10;
			// 
			// bitViewer1
			// 
			this.bitViewer1.Location = new System.Drawing.Point(197, 3);
			this.bitViewer1.Name = "bitViewer1";
			this.bitViewer1.Size = new System.Drawing.Size(248, 74);
			this.bitViewer1.TabIndex = 8;
			// 
			// BitResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.converter1);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.bitViewer1);
			this.Name = "BitResult";
			this.Size = new System.Drawing.Size(599, 78);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private BitViewer bitViewer1;
		private Converter converter1;
	}
}
