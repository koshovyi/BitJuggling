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

		private int _a, _b, _n;

		private BitOperations _bitOperations;

		public BitOperations BitOperations
		{
			get { return this._bitOperations; }
			set
			{
				this._bitOperations = value;
				this.SetTitle();
				this.Calculate();
			}
		}

		public int ValueA
		{
			get { return this._a; }
			set
			{
				this._a = value;
				this.Calculate();
			}
		}

		public int ValueB
		{
			get { return this._b; }
			set
			{
				this._b = value;
				this.Calculate();
			}
		}

		public int ValueN
		{
			get { return this._n; }
			set
			{
				this._n = value;
				this.Calculate();
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

		private void Calculate()
		{
			int result = this.CalculateResult();
			this.bitConverter.Value = result;
			this.bitViewer1.Value = result;
		}

		private int CalculateResult()
		{
			switch (this.BitOperations)
			{
				default:
				case BitOperations.AND:
					return this._a & this._b;
				case BitOperations.OR:
					return this._a | this._b;
				case BitOperations.XOR:
					return this._a ^ this._b;
				case BitOperations.LEFTSHIFT:
					return this._a << this._n;
				case BitOperations.RIGHTSHIFT:
					return this._a >> this._n;
				case BitOperations.ONESCOMPLEMENT:
					return ~ this._a;
			}
		}

	}
}
