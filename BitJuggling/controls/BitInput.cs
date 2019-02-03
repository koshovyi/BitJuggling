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

	}
}
