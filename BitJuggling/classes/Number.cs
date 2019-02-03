using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitJuggling
{

	public class Number
	{

		public int Dec { get; set; }

		public int Oct { get; set; }

		public string Bin { get; set; }

		public string Hex { get; set; }

		internal Number(int decValue)
		{
			this.Dec = decValue;
		}

		public static Number FromDec(int decValue)
		{
			return new Number(decValue);
		}

		public static Number FromHex(string hexValue)
		{
			return new Number(Math.ConvertDecFromHex(hexValue));
		}

		public static Number FromBin(string binValue)
		{
			return new Number(Math.ConvertDecFromBin(binValue));
		}

		public static Number FromOct(string octValue)
		{
			return new Number(Math.ConvertDecFromBin(octValue));
		}

	}

}
