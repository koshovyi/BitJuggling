using System;

namespace BitJuggling
{

	public class Math
	{

		public const int BASE_BIN = 2;

		public const int BASE_OCT = 8;

		public const int BASE_HEX = 16;

		#region To Dec

		public static int ConvertDecFromBin(string binValue)
		{
			return Convert.ToInt32(binValue, BASE_BIN);
		}

		public static int ConvertDecFromOct(string octValue)
		{
			return Convert.ToInt32(octValue, BASE_OCT);
		}

		public static int ConvertDecFromHex(string hexValue)
		{
			return Convert.ToInt32(hexValue, BASE_HEX);
		}

		#endregion

		#region From Dec

		public static string ConvertBinFromDec(int decimalValue)
		{
			return Convert.ToString(decimalValue, BASE_BIN);
		}

		public static string ConvertOctFromDec(int decimalValue)
		{
			return Convert.ToString(decimalValue, BASE_OCT);
		}

		public static string ConvertHexFromDec(int decimalValue)
		{
			return Convert.ToString(decimalValue, BASE_HEX);
		}

		#endregion

	}

}
