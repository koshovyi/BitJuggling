namespace BitJuggling
{

	public class BitStateChangedEvent
	{

		public bool NewBitState { get; set; }

		public BitStateChangedEvent(bool newBitState)
		{
			this.NewBitState = newBitState;
		}

	}

}
