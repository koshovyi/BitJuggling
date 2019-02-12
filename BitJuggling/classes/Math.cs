using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

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
			if (string.IsNullOrEmpty(binValue))
				binValue = "0";
			if (!Regex.IsMatch(binValue, "^[01]+$"))
				binValue = "0";
			return Convert.ToInt32(binValue, BASE_BIN);
		}

		public static int ConvertDecFromOct(string octValue)
		{
			if (string.IsNullOrEmpty(octValue))
				octValue = "0";
			return Convert.ToInt32(octValue, BASE_OCT);
		}

		public static int ConvertDecFromHex(string hexValue)
		{
			if (string.IsNullOrEmpty(hexValue))
				hexValue = "0";
			return Convert.ToInt32(hexValue, BASE_HEX);
		}

		#endregion

		#region From Dec

		public static string ConvertBinFromDec(int decValue)
		{
			return Convert.ToString(decValue, BASE_BIN)
				.PadLeft(8, '0');
		}

		public static string ConvertOctFromDec(int decValue)
		{
			return Convert.ToString(decValue, BASE_OCT);
		}

		public static string ConvertHexFromDec(int decValue)
		{
			return Convert.ToString(decValue, BASE_HEX)
				.ToUpper();
		}

		#endregion

		#region Bits

		public static bool[] GetBitsFromDec(int decValue)
		{
			string s = Convert.ToString(decValue, 2);
			bool[] bits = s.PadLeft(8, '0')
				.Select(c => int.Parse(c.ToString()))
				.ToArray()
				.Select(bit => bit == 1 ? true : false)
				.ToArray();
			return bits;
		}

		public static int GetDecFromBits(bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7, bool b8)
		{
			string s(bool b) => b ? "1" : "0";
			return ConvertDecFromBin(s(b1) + s(b2) + s(b3) + s(b4) + s(b5) + s(b6) + s(b7) + s(b8));
		}

		#endregion

	}

}
