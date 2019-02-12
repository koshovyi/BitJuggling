using System;
using System.Windows.Forms;

namespace BitJuggling
{
	public partial class Calculator : UserControl
	{

		private byte _value;

		private bool _update;

		public byte Value
		{
			get { return this._value; }
			set
			{
				this._value = value;
				this.Calculate(value);
			}
		}

		public Calculator()
		{
			InitializeComponent();
		}

		private void optNumeralSystem_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radio = (RadioButton)sender;
			this.NumeralSystemChecked(radio.Text);
		}

		private void NumeralSystemChecked(string current)
		{
			bool oct = false, dec = false, bin = false, hex = false;
			switch (current)
			{
				case "dec":
					dec = true;
					break;
				case "hex":
					hex = true;
					break;
				case "bin":
					bin = true;
					break;
				case "oct":
					oct = true;
					break;
			}
			this.txtBin.Enabled = bin;
			this.numOct.Enabled = oct;
			this.txtHex.Enabled = hex;
			this.numDec.Enabled = dec;
		}

		private void numDec_ValueChanged(object sender, EventArgs e)
		{
			this.Calculate((int)numDec.Value, dec: false);
		}

		private void txtBin_TextChanged(object sender, EventArgs e)
		{
			this.Calculate(Math.ConvertDecFromBin(txtBin.Text), bin: false);
		}

		private void txtHex_TextChanged(object sender, EventArgs e)
		{
			this.Calculate(Math.ConvertDecFromHex(txtHex.Text), hex: false);
		}

		private void numOct_ValueChanged(object sender, EventArgs e)
		{
			this.Calculate(Math.ConvertDecFromOct(numOct.Value.ToString()), oct: false);
		}

		private void Calculate(int decValue, bool dec = true, bool hex = true, bool bin = true, bool oct = true)
		{
			if (!this._update)
			{
				this._update = true;
				if (decValue < 0)
					decValue = 0;
				else if (decValue > 255)
					decValue = 255;
				if(dec)
					this.numDec.Value = decValue;
				if(oct)
					this.numOct.Value = Convert.ToInt32(Math.ConvertOctFromDec(decValue));
				if(bin)
					this.txtBin.Text = Math.ConvertBinFromDec(decValue);
				if(hex)
					this.txtHex.Text = Math.ConvertHexFromDec(decValue);
				this._value = (byte)decValue;
				this._update = false;
			}
		}

		private void txtBin_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = CheckKeysExist(e.KeyChar, '0', '1', '\b');
		}

		private void txtHex_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = CheckKeysExist(e.KeyChar, '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', '\b');
		}

		private bool CheckKeysExist(char key, params char[] keys)
		{
			foreach (char c in keys)
				if (c == key)
					return false;
			return true;
		}

	}
}
