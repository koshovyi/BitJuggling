using BitJuggling.Common;

namespace BitJuggling
{

	public class BitsValueChangedEvent
	{

		public bool[] Bits { get; private set; }

		public int DecimalValue { get; private set; }

		public BitsValueChangedEvent(bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7, bool b8)
		{
			this.Bits = new bool[] { b1, b2, b3, b4, b5, b6, b7, b8 };
			this.DecimalValue = Math.GetDecFromBits(b1, b2, b3, b4, b5, b6, b7, b8);
		}

	}

}
