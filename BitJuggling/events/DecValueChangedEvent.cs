namespace BitJuggling
{

	public class DecValueChangedEvent
	{

		public int DecimalValue { get; private set; }

		public DecValueChangedEvent(int decValue)
		{
			this.DecimalValue = decValue;
		}

	}

}
