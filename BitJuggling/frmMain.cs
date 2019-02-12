using System;
using System.Diagnostics;
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
			this.LoadForm();
		}

		private void LoadForm()
		{
			this.Text += " " + frmAbout.AssemblyVersion;
		}

		#region Calculating

		private void input_DecValueChanged(object sender, DecValueChangedEvent e)
		{
			this.Calculate();
		}

		private void Calculate()
		{
			this.bitResult1.ValueA = this.input1.Value;
			this.bitResult1.ValueB = this.input2.Value;
			this.bitResult1.ValueN = (short)this.barTrackShiftN.Value;
			this.bitResult2 .ValueA = this.input1.Value;
			this.bitResult2.ValueB = this.input2.Value;
			this.bitResult2.ValueN = (short)this.barTrackShiftN.Value;
			this.bitResult3.ValueA = this.input1.Value;
			this.bitResult3.ValueB = this.input2.Value;
			this.bitResult3.ValueN = (short)this.barTrackShiftN.Value;
			this.bitResult4.ValueA = this.input1.Value;
			this.bitResult4.ValueB = this.input2.Value;
			this.bitResult4.ValueN = (short)this.barTrackShiftN.Value;
			this.bitResult5.ValueA = this.input1.Value;
			this.bitResult5.ValueB = this.input2.Value;
			this.bitResult5.ValueN = (short)this.barTrackShiftN.Value;
			this.bitResult6.ValueA = this.input1.Value;
			this.bitResult6.ValueB = this.input2.Value;
			this.bitResult6.ValueN = (short)this.barTrackShiftN.Value;
		}

 		private void barTrackShiftN_Scroll(object sender, EventArgs e)
		{
			this.lblShiftNValue.Text = barTrackShiftN.Value.ToString();
			this.Calculate();
		}

		#endregion

		#region Menu

		private void tlpMenuMenuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tlpMenuAbout_Click(object sender, EventArgs e)
		{
			this.ShowAboutForm();
		}

		private void ShowAboutForm()
		{
			using(frmAbout f = new frmAbout())
			{
				f.ShowDialog(this);
			}
		}

		#endregion

		#region Operations

		private void tlpMainOperationsSwap_Click(object sender, EventArgs e)
		{
			byte a = input1.Value;
			byte b = input2.Value;
			input1.Value = b;
			input2.Value = a;
		}

		#endregion

		#region A & B

		/*
		 * A
		*/

		private void tlpMainInputAClear_Click(object sender, EventArgs e)
		{
			this.input1.Value = 0;
		}

		private void tlpMainInputAFull_Click(object sender, EventArgs e)
		{
			this.input1.Value = 255;
		}

		private void tlpMainInputAInverse_Click(object sender, EventArgs e)
		{
			this.input1.Value = (byte)~this.input1.Value;
		}

		private void tlpMainInputA1_Click(object sender, EventArgs e)
		{
			this.input1.Value = (byte)(this.input1.Value & this.input2.Value);
		}

		private void tlpMainInputA2_Click(object sender, EventArgs e)
		{
			this.input1.Value = (byte)(this.input1.Value | this.input2.Value);
		}

		private void tlpMainInputA3_Click(object sender, EventArgs e)
		{
			this.input1.Value = (byte)(this.input1.Value ^ this.input2.Value);
		}

		private void tlpMainInputA4_Click(object sender, EventArgs e)
		{
			this.input1.Value = (byte)(this.input1.Value << barTrackShiftN.Value);
		}

		private void tlpMainInputA5_Click(object sender, EventArgs e)
		{
			this.input1.Value = (byte)(this.input1.Value >> barTrackShiftN.Value);
		}

		private void tlpMainInputAEqualsB_Click(object sender, EventArgs e)
		{
			this.input1.Value = this.input2.Value;
		}

		/*
		 * B
		*/

		private void tlpMainInputBClear_Click(object sender, EventArgs e)
		{
			this.input2.Value = 0;
		}

		private void tlpMainInputBFull_Click(object sender, EventArgs e)
		{
			this.input2.Value = 255;
		}

		private void tlpMainInputBInverse_Click(object sender, EventArgs e)
		{
			this.input2.Value = (byte)~this.input2.Value;
		}

		private void tlpMainInputB1_Click(object sender, EventArgs e)
		{
			this.input2.Value = (byte)(this.input1.Value & this.input2.Value);
		}

		private void tlpMainInputB2_Click(object sender, EventArgs e)
		{
			this.input2.Value = (byte)(this.input1.Value | this.input2.Value);
		}

		private void tlpMainInputB3_Click(object sender, EventArgs e)
		{
			this.input2.Value = (byte)(this.input1.Value ^ this.input2.Value);
		}

		private void tlpMainInputB4_Click(object sender, EventArgs e)
		{
			this.input2.Value = (byte)(this.input1.Value << barTrackShiftN.Value);
		}

		private void tlpMainInputB5_Click(object sender, EventArgs e)
		{
			this.input2.Value = (byte)(this.input1.Value >> barTrackShiftN.Value);
		}

		private void tlpMainInputBEqualsA_Click(object sender, EventArgs e)
		{
			this.input2.Value = this.input1.Value;
		}

		#endregion

		#region Input data

		private void tlpMainInput_Click(object sender, EventArgs e)
		{
			this.InputData();
		}

		private void InputData()
		{
			using(frmInput f = new frmInput(this.input1.Value, this.input2.Value))
			{
				if(f.ShowDialog() == DialogResult.OK)
				{
					this.input1.Value = f.ValueA;
					this.input2.Value = f.ValueB;
				}
			}
		}

		#endregion

		#region Status bar

		private void tlpStatusLink_Click(object sender, EventArgs e)
		{
			this.RedirectToLink("https://www.koshovyi.com");
		}

		private void RedirectToLink(string url)
		{
			try
			{
				Process.Start(url);
			}
			catch { }
		}

		#endregion

		#region Wiki

		private void tlpMenuWiki1_Click(object sender, EventArgs e)
		{
			RedirectToLink("https://en.wikipedia.org/wiki/Numeral_system");
		}

		private void tlpMenuWiki2_Click(object sender, EventArgs e)
		{
			RedirectToLink("https://en.wikipedia.org/wiki/List_of_numeral_systems");
		}

		private void tlpMenuWiki3_Click(object sender, EventArgs e)
		{
			RedirectToLink("https://en.wikipedia.org/wiki/Binary_number");
		}

		private void tlpMenuWiki4_Click(object sender, EventArgs e)
		{
			RedirectToLink("https://en.wikipedia.org/wiki/Octal");
		}

		private void tlpMenuWiki5_Click(object sender, EventArgs e)
		{
			RedirectToLink("https://en.wikipedia.org/wiki/Decimal");
		}

		private void tlpMenuWiki6_Click(object sender, EventArgs e)
		{
			RedirectToLink("https://en.wikipedia.org/wiki/Hexadecimal");
		}

		private void tlpMenuWiki7_Click(object sender, EventArgs e)
		{
			RedirectToLink("https://en.wikipedia.org/wiki/Bitwise_operation");
		}

		#endregion

	}
}
