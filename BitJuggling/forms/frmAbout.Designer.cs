namespace BitJuggling
{
	partial class frmAbout
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
			this.grpAbout = new System.Windows.Forms.GroupBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.lnkLink = new System.Windows.Forms.LinkLabel();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.lnkGitHub = new System.Windows.Forms.LinkLabel();
			this.grpAbout.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpAbout
			// 
			this.grpAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpAbout.Controls.Add(this.lnkGitHub);
			this.grpAbout.Controls.Add(this.lblCopyright);
			this.grpAbout.Controls.Add(this.lblDescription);
			this.grpAbout.Controls.Add(this.lnkLink);
			this.grpAbout.Controls.Add(this.lblAuthor);
			this.grpAbout.Controls.Add(this.lblName);
			this.grpAbout.Location = new System.Drawing.Point(12, 11);
			this.grpAbout.Name = "grpAbout";
			this.grpAbout.Size = new System.Drawing.Size(347, 130);
			this.grpAbout.TabIndex = 0;
			this.grpAbout.TabStop = false;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(6, 18);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 17);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Title";
			// 
			// lblAuthor
			// 
			this.lblAuthor.AutoSize = true;
			this.lblAuthor.Location = new System.Drawing.Point(6, 52);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(50, 17);
			this.lblAuthor.TabIndex = 2;
			this.lblAuthor.Text = "Author";
			// 
			// lnkLink
			// 
			this.lnkLink.AutoSize = true;
			this.lnkLink.Location = new System.Drawing.Point(6, 69);
			this.lnkLink.Name = "lnkLink";
			this.lnkLink.Size = new System.Drawing.Size(167, 17);
			this.lnkLink.TabIndex = 3;
			this.lnkLink.TabStop = true;
			this.lnkLink.Text = "https://www.koshovyi.com";
			this.lnkLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLink_LinkClicked);
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(6, 35);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(79, 17);
			this.lblDescription.TabIndex = 4;
			this.lblDescription.Text = "Description";
			// 
			// lblCopyright
			// 
			this.lblCopyright.AutoSize = true;
			this.lblCopyright.Location = new System.Drawing.Point(6, 103);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(68, 17);
			this.lblCopyright.TabIndex = 5;
			this.lblCopyright.Text = "Copyright";
			// 
			// lnkGitHub
			// 
			this.lnkGitHub.AutoSize = true;
			this.lnkGitHub.Location = new System.Drawing.Point(6, 86);
			this.lnkGitHub.Name = "lnkGitHub";
			this.lnkGitHub.Size = new System.Drawing.Size(99, 17);
			this.lnkGitHub.TabIndex = 6;
			this.lnkGitHub.TabStop = true;
			this.lnkGitHub.Text = "GitHub project";
			this.lnkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHub_LinkClicked);
			// 
			// frmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 156);
			this.Controls.Add(this.grpAbout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "frmAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About BitJuggling";
			this.Load += new System.EventHandler(this.frmAbout_Load);
			this.grpAbout.ResumeLayout(false);
			this.grpAbout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpAbout;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.LinkLabel lnkLink;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblCopyright;
		private System.Windows.Forms.LinkLabel lnkGitHub;
	}
}