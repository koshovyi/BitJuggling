namespace BitJuggling
{

	public class BitInputChangedEvent
	{

		public int Value { get; private set; }

		public BitInputChangedEvent(int value)
		{
			this.Value = value;
		}

	}

}
