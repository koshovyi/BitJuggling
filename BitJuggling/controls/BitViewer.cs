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
	public partial class BitViewer : UserControl
	{

		private int _value = 0;

		public int Value
		{
			get { return this._value; }
			set
			{
				this._value = value;
				this.SetBits();
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

	}
}
