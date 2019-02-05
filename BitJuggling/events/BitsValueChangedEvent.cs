namespace BitJuggling
{

	public class BitsValueChangedEvent
	{

		public bool[] Bits { get; set; }

		public int DecimalValue { get; set; }

		public BitsValueChangedEvent(bool[] bits)
		{
			this.Bits = bits;
			this.DecimalValue = 0;
		}

	}

}
