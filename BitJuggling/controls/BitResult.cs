using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitJuggling
{
	public partial class BitResult : UserControl
	{

		private BitOperations _bitOperations;

		public BitOperations BitOperations
		{
			get { return this._bitOperations; }
			set
			{
				this._bitOperations = value;
				this.SetTitle();
			}
		}

		public BitResult()
		{
			InitializeComponent();
		}

		private void SetTitle()
		{
			this.lblTitle.Text = this.GetTitle();
		}

		private string GetTitle()
		{
			switch (this._bitOperations)
			{
				case BitOperations.AND:
					return "A && B";
				case BitOperations.OR:
					return "A | B";
				case BitOperations.XOR:
					return "A ^ B";
				case BitOperations.ONESCOMPLEMENT:
					return "~ A";
				case BitOperations.LEFTSHIFT:
					return "A << n";
				case BitOperations.RIGHTSHIFT:
					return "A >> n";
				case BitOperations.UNKNOWN:
				default:
					return "-";
			}
		}

	}
}
