using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitJuggling.Cmd
{
	class Program
	{
		static void Main(string[] args)
		{
			byte a = 255;
			byte b = (byte)~a;
			Console.WriteLine(b);
			Console.Read();
		}
	}
}
