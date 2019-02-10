using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace BitJuggling
{
	public partial class frmAbout : Form
	{
		public frmAbout()
		{
			InitializeComponent();
		}

		private void frmAbout_Load(object sender, EventArgs e)
		{
			this.Text = "About " + AssemblyTitle;
			this.lblName.Text = AssemblyTitle + " " + AssemblyVersion;
			this.lblAuthor.Text = AssemblyCompany;
			this.lblDescription.Text = AssemblyDescription;
			this.lblCopyright.Text = AssemblyCopyright;
		}

		#region Assembly Attribute Accessors

		public static string AssemblyTitle
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					if (titleAttribute.Title != "")
					{
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public static string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		public string AssemblyDescription
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public static string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public static string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public static string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion

		private void lnkLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.RedirectToUrl(lnkLink.Text);
		}

		private void lnkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.RedirectToUrl("https://github.com/devellloper/BitJuggling");
		}

		private void RedirectToUrl(string url)
		{
			try
			{
				Process.Start(url);
			}
			catch { }
		}

	}
}
