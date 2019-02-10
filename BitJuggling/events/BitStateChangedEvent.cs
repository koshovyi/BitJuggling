namespace BitJuggling
{

	public class BitStateChangedEvent
	{

		public bool NewBitState { get; private set; }

		public BitStateChangedEvent(bool newBitState)
		{
			this.NewBitState = newBitState;
		}

	}

}
