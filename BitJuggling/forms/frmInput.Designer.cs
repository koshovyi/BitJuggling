namespace BitJuggling
{
	partial class frmInput
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
			this.grpInputA = new System.Windows.Forms.GroupBox();
			this.calculator1 = new BitJuggling.Calculator();
			this.butOK = new System.Windows.Forms.Button();
			this.butCancel = new System.Windows.Forms.Button();
			this.grpInputB = new System.Windows.Forms.GroupBox();
			this.calculator2 = new BitJuggling.Calculator();
			this.grpInputA.SuspendLayout();
			this.grpInputB.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpInputA
			// 
			this.grpInputA.Controls.Add(this.calculator1);
			this.grpInputA.Location = new System.Drawing.Point(12, 12);
			this.grpInputA.Name = "grpInputA";
			this.grpInputA.Size = new System.Drawing.Size(186, 137);
			this.grpInputA.TabIndex = 0;
			this.grpInputA.TabStop = false;
			this.grpInputA.Text = "Input A:";
			// 
			// calculator1
			// 
			this.calculator1.Location = new System.Drawing.Point(6, 21);
			this.calculator1.Name = "calculator1";
			this.calculator1.Size = new System.Drawing.Size(178, 112);
			this.calculator1.TabIndex = 0;
			this.calculator1.Value = 0;
			// 
			// butOK
			// 
			this.butOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butOK.Location = new System.Drawing.Point(234, 158);
			this.butOK.Name = "butOK";
			this.butOK.Size = new System.Drawing.Size(75, 23);
			this.butOK.TabIndex = 0;
			this.butOK.Text = "&OK";
			this.butOK.UseVisualStyleBackColor = true;
			this.butOK.Click += new System.EventHandler(this.butOK_Click);
			// 
			// butCancel
			// 
			this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.butCancel.Location = new System.Drawing.Point(315, 158);
			this.butCancel.Name = "butCancel";
			this.butCancel.Size = new System.Drawing.Size(75, 23);
			this.butCancel.TabIndex = 1;
			this.butCancel.Text = "&Cancel";
			this.butCancel.UseVisualStyleBackColor = true;
			this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
			// 
			// grpInputB
			// 
			this.grpInputB.Controls.Add(this.calculator2);
			this.grpInputB.Location = new System.Drawing.Point(204, 12);
			this.grpInputB.Name = "grpInputB";
			this.grpInputB.Size = new System.Drawing.Size(186, 137);
			this.grpInputB.TabIndex = 2;
			this.grpInputB.TabStop = false;
			this.grpInputB.Text = "Input B:";
			// 
			// calculator2
			// 
			this.calculator2.Location = new System.Drawing.Point(6, 21);
			this.calculator2.Name = "calculator2";
			this.calculator2.Size = new System.Drawing.Size(178, 112);
			this.calculator2.TabIndex = 0;
			this.calculator2.Value = 0;
			// 
			// frmInput
			// 
			this.AcceptButton = this.butOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.butCancel;
			this.ClientSize = new System.Drawing.Size(402, 193);
			this.Controls.Add(this.grpInputB);
			this.Controls.Add(this.butOK);
			this.Controls.Add(this.butCancel);
			this.Controls.Add(this.grpInputA);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "frmInput";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Input Data";
			this.Load += new System.EventHandler(this.frmInput_Load);
			this.grpInputA.ResumeLayout(false);
			this.grpInputB.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpInputA;
		private System.Windows.Forms.Button butOK;
		private System.Windows.Forms.Button butCancel;
		private Calculator calculator1;
		private System.Windows.Forms.GroupBox grpInputB;
		private Calculator calculator2;
	}
}