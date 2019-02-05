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
	public partial class BitInput : UserControl
	{

		private int _value = 0;

		private string _inputName;

		public string InputName
		{
			get { return this._inputName; }
			set
			{
				this._inputName = value;
				this.lblInput.Text = $"{this._inputName}:";
				this.grpInput.Text = $"Input {this._inputName}";
			}
		}

		public BitInput()
		{
			InitializeComponent();
		}

		private void BitInput_Load(object sender, EventArgs e)
		{

		}

		private void txtInput_TextChanged(object sender, EventArgs e)
		{
			int value = this.ReadValue();
			bitViewer1.Value = value;
			converter1.Value = value;
		}

		private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeysPressValidation(e);
		}

		private int ReadValue()
		{
			int result = 0;
			string input = txtInput.Text;
			if (optDec.Checked)
			{
				if (!int.TryParse(input, out result))
					result = 0;
			}

			return result;
		}

		private void KeysPressValidation(KeyPressEventArgs e)
		{
			char[] symbols = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'a', 'b', 'c', 'd', 'e', 'f', '\b' };
			bool handled = true;
			foreach (char symbol in symbols)
			{
				if (e.KeyChar == symbol)
				{
					handled = false;
					break;
				}
			}
			e.Handled = handled;
		}

	}
}
