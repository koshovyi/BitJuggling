namespace BitJuggling
{
	partial class Input
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
			this.converter1 = new BitJuggling.Converter();
			this.bitViewer1 = new BitJuggling.BitViewer();
			this.lblTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// converter1
			// 
			this.converter1.BackColor = System.Drawing.Color.White;
			this.converter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.converter1.Location = new System.Drawing.Point(2, 148);
			this.converter1.Name = "converter1";
			this.converter1.Size = new System.Drawing.Size(248, 69);
			this.converter1.TabIndex = 0;
			this.converter1.Value = 0;
			// 
			// bitViewer1
			// 
			this.bitViewer1.Location = new System.Drawing.Point(2, 68);
			this.bitViewer1.LockCheckBoxes = true;
			this.bitViewer1.Name = "bitViewer1";
			this.bitViewer1.Size = new System.Drawing.Size(248, 74);
			this.bitViewer1.TabIndex = 1;
			this.bitViewer1.Value = 0;
			this.bitViewer1.BitsValueChanged += new System.EventHandler<BitJuggling.BitsValueChangedEvent>(this.bitViewer1_BitsValueChanged);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Consolas", 28.2F);
			this.lblTitle.Location = new System.Drawing.Point(3, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(154, 56);
			this.lblTitle.TabIndex = 10;
			this.lblTitle.Text = "Input";
			// 
			// Input
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.bitViewer1);
			this.Controls.Add(this.converter1);
			this.Name = "Input";
			this.Size = new System.Drawing.Size(252, 221);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Converter converter1;
		private BitViewer bitViewer1;
		private System.Windows.Forms.Label lblTitle;
	}
}
