using System;
using System.Windows.Forms;

namespace BitJuggling
{
	public partial class Input : UserControl
	{

		private byte _value;

		public event EventHandler<DecValueChangedEvent> DecValueChanged;

		public string Title
		{
			get { return this.lblTitle.Text; }
			set { this.lblTitle.Text = value; }
		}

		public byte Value
		{
			get { return this._value; }
			set
			{
				this._value = value;
				this.Calculate();
			}
		}

		public Input()
		{
			InitializeComponent();
		}

		private void Calculate()
		{
			this.converter1.Value = this._value;
			this.bitViewer1.Value = this._value;
			this.DecValueChanged?.Invoke(this, new DecValueChangedEvent(this._value));
		}

		private void bitViewer1_BitsValueChanged(object sender, BitsValueChangedEvent e)
		{
			this.Value = (byte)e.DecimalValue;
		}

	}
}
