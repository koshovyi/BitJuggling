using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
