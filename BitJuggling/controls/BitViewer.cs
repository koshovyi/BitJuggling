using System;
using System.Windows.Forms;

namespace BitJuggling
{
	public partial class BitViewer : UserControl
	{

		private byte _value = 0;

		public event EventHandler<BitsValueChangedEvent> BitsValueChanged;

		public byte Value
		{
			get { return this._value; }
			set
			{
				this._value = value;
				this.SetBits();
			}
		}

		public bool LockCheckBoxes
		{
			get { return bitItem1.AutoCheck;  }
			set
			{
				bitItem1.AutoCheck = value;
				bitItem2.AutoCheck = value;
				bitItem3.AutoCheck = value;
				bitItem4.AutoCheck = value;
				bitItem5.AutoCheck = value;
				bitItem6.AutoCheck = value;
				bitItem7.AutoCheck = value;
				bitItem8.AutoCheck = value;
			}
		}

		public BitViewer()
		{
			InitializeComponent();
		}

		private void SetBits()
		{
			bool[] bits = Math.GetBitsFromDec(this._value);
			bitItem1.Checked = bits[0];
			bitItem2.Checked = bits[1];
			bitItem3.Checked = bits[2];
			bitItem4.Checked = bits[3];
			bitItem5.Checked = bits[4];
			bitItem6.Checked = bits[5];
			bitItem7.Checked = bits[6];
			bitItem8.Checked = bits[7];
		}

		private void bitItem_BitStateChanged(object sender, BitStateChangedEvent e)
		{
			this.BitsValueChanged?.Invoke(this, 
				new BitsValueChangedEvent(
					bitItem1.Checked,
					bitItem2.Checked,
					bitItem3.Checked,
					bitItem4.Checked,
					bitItem5.Checked,
					bitItem6.Checked,
					bitItem7.Checked,
					bitItem8.Checked
				));
		}

	}
}
