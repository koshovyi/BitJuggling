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
	public partial class Converter : UserControl
	{

		private int _value = 0;

		public int Value
		{
			get { return this._value; }
			set
			{
				this._value = value;
				this.Calculate();
			}
		}

		public Converter()
		{
			InitializeComponent();
		}

		private void Calculate()
		{
			this.lblDec2.Text = this._value.ToString();
			this.lblBin2.Text = Math.ConvertBinFromDec(this._value);
			this.lblHex2.Text = Math.ConvertHexFromDec(this._value);
			this.lblOct2.Text = Math.ConvertOctFromDec(this._value);
		}

	}
}
