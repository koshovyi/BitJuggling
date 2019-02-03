using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitJuggling
{

	public enum BitOperations : uint
	{
		UNKNOWN = 0,
		AND = 1,
		OR = 2,
		XOR = 3,
		LEFTSHIFT = 4,
		RIGHTSHIFT = 5,
		ONESCOMPLEMENT = 6,
	}

}
