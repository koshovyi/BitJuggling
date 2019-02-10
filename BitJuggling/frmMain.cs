using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitJuggling
{
	public partial class frmMain : Form
	{

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{

		}

		private void input_DecValueChanged(object sender, DecValueChangedEvent e)
		{
			this.Calculate();
		}

		private void Calculate()
		{
			this.bitResult1.ValueA = this.input1.Value;
			this.bitResult1.ValueB = this.input2.Value;
			this.bitResult1.ValueN = this.barTrackShiftN.Value;
			this.bitResult2 .ValueA = this.input1.Value;
			this.bitResult2.ValueB = this.input2.Value;
			this.bitResult2.ValueN = this.barTrackShiftN.Value;
			this.bitResult3.ValueA = this.input1.Value;
			this.bitResult3.ValueB = this.input2.Value;
			this.bitResult3.ValueN = this.barTrackShiftN.Value;
			this.bitResult4.ValueA = this.input1.Value;
			this.bitResult4.ValueB = this.input2.Value;
			this.bitResult4.ValueN = this.barTrackShiftN.Value;
			this.bitResult5.ValueA = this.input1.Value;
			this.bitResult5.ValueB = this.input2.Value;
			this.bitResult5.ValueN = this.barTrackShiftN.Value;
			this.bitResult6.ValueA = this.input1.Value;
			this.bitResult6.ValueB = this.input2.Value;
			this.bitResult6.ValueN = this.barTrackShiftN.Value;
		}

 		private void barTrackShiftN_Scroll(object sender, EventArgs e)
		{
			this.lblShiftNValue.Text = barTrackShiftN.Value.ToString();
			this.Calculate();
		}

	}
}
