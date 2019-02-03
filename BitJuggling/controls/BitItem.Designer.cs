namespace BitJuggling
{
	partial class BitItem
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
			this.chkBit = new System.Windows.Forms.CheckBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// chkBit
			// 
			this.chkBit.AutoSize = true;
			this.chkBit.Location = new System.Drawing.Point(4, 28);
			this.chkBit.Name = "chkBit";
			this.chkBit.Size = new System.Drawing.Size(18, 17);
			this.chkBit.TabIndex = 1;
			this.chkBit.UseVisualStyleBackColor = true;
			this.chkBit.CheckedChanged += new System.EventHandler(this.chkBit_CheckedChanged);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTitle.Location = new System.Drawing.Point(3, 6);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(18, 20);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "1";
			// 
			// BitItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.chkBit);
			this.Name = "BitItem";
			this.Size = new System.Drawing.Size(24, 49);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkBit;
		private System.Windows.Forms.Label lblTitle;
	}
}
