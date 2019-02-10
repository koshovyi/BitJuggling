using System;
using System.Windows.Forms;

namespace BitJuggling
{
	public partial class BitItem : UserControl
	{

		public event EventHandler<BitStateChangedEvent> BitStateChanged;

		public bool Checked
		{
			get { return this.chkBit.Checked; }
			set
			{
				this.chkBit.Checked = value;
				this.SetTitle();
			}
		}

		public bool AutoCheck
		{
			get { return this.chkBit.AutoCheck; }
			set { this.chkBit.AutoCheck = value; }
		}

		public BitItem()
		{
			InitializeComponent();
		}

		private void SetTitle()
		{
			this.lblTitle.Text = this.chkBit.Checked ? "1" : "0";
		}

		private void chkBit_CheckedChanged(object sender, EventArgs e)
		{
			this.BitStateChanged?.Invoke(this, new BitStateChangedEvent(this.Checked));
			this.SetTitle();
		}

	}
}
