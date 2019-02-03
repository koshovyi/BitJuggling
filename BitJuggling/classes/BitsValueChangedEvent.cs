using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
