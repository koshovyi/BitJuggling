using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BitJuggling.Cmd
{

	public class Parser
	{

		private static char[] operations = new char[] { '&', '|', '^', '<', '>', '~' };

		public static void Calculate(string command)
		{
			if (IsStatement(command))
				CalculateStack(command);
			else
				IsByte(command);
		}

		private static bool IsStatement(string command)
		{
			foreach (char c in operations)
			{
				if (command.Contains(c))
					return true;
			}
			return false;
		}

		private static void CalculateStack(string command)
		{
		}

		private static byte? IsByte(string command)
		{
			byte? result = null;

			if(byte.TryParse(command, out byte b))
				result = b;

			//HEX
			else if (Regex.IsMatch(command, "0[xX][0-9a-fA-F]+"))
				result = (byte)Common.Math.ConvertDecFromHex(command);
			else if (Regex.IsMatch(command, "0[hH][0-9a-fA-F]+"))
				result = (byte)Common.Math.ConvertDecFromHex(command.Substring(2));
			else if (Regex.IsMatch(command, "[0-9a-fA-F]+h"))
				result = (byte)Common.Math.ConvertDecFromHex(command.Substring(0, command.Length - 1));

			//BIN
			else if (Regex.IsMatch(command, "0[bB][01]+"))
				result = (byte)Common.Math.ConvertDecFromBin(command.Substring(2));
			else if (Regex.IsMatch(command, "([01]+)b|B"))
				result = (byte)Common.Math.ConvertDecFromBin(command.Substring(0, command.Length - 1));

			//OCT
			else if (Regex.IsMatch(command, "0[oO][01234567]+"))
				result = (byte)Common.Math.ConvertDecFromOct(command.Substring(2));
			else if (Regex.IsMatch(command, "([01234567]+)o|O"))
				result = (byte)Common.Math.ConvertDecFromOct(command.Substring(0, command.Length - 1));

			if (result.HasValue)
				Program.DrawByte(result.Value);
			else
				Program.DrawError("Problem with parsing data: " + command);

			return result;
		}

	}

}
