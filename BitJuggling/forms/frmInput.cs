using System;
using System.Windows.Forms;

namespace BitJuggling
{
	public partial class frmInput : Form
	{

		public int ValueA
		{
			get { return this.calculator1.Value; }
			set { this.calculator1.Value = value; }
		}

		public int ValueB
		{
			get { return this.calculator2.Value; }
			set { this.calculator2.Value = value; }
		}

		public frmInput(int inputA, int inputB)
		{
			InitializeComponent();
			this.calculator1.Value = inputA;
			this.calculator2.Value = inputB;
		}

		private void butCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void butOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void frmInput_Load(object sender, EventArgs e)
		{

		}

	}
}
