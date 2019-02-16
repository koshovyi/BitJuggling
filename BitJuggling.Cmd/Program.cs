using System;
using System.Reflection;
using System.Text;

namespace BitJuggling.Cmd
{

	class Program
	{

		static void Main(string[] args)
		{
			Console.Title = "Big Juggling " + AssemblyVersion;
			CreateTitle();
			CommandsLoop();
		}

		private static void CommandsLoop()
		{
			string command = string.Empty;
			do
			{
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("[BJ]: ");
				Console.ResetColor();
				command = Console.ReadLine().Trim();
				ParseLine(command);
			}
			while (command != "exit");
		}

		private static void CreateTitle()
		{
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("Big Juggling " + AssemblyVersion + ". Console mode.");
			Console.ResetColor();
			Console.WriteLine("Enter 'exit' for exit and 'help' for help :)");
		}

		private static void ParseLine(string commands)
		{
			switch (commands)
			{
				case "exit":
					break;
				case "clear":
					Console.Clear();
					CreateTitle();
					break;
				case "help":
					CommandHelp();
					break;
				case "about":
					CommandAbout();
					break;
				default:
					ParseCommands(commands);
					break;
			}
		}

		private static void ParseCommands(string commands)
		{
			string[] c = commands.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if(c.Length > 0)
				Program.EmptyLine();
			foreach (string command in c)
			{
				if(!string.IsNullOrEmpty(command))
					Parser.Calculate(command);
			}
		}

		#region Drawing

		public static void DrawByte(byte b)
		{
			bool[] bits = Common.Math.GetBitsFromDec(b);
			Console.Write(" byte: " + b.ToString("000"));
			Separator();
			Console.Write("bits [");
			foreach (bool bit in bits)
			{
				if(bit)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(" 1 ");
					Console.ResetColor();
				}
				else
					Console.Write(" 0 ");
			}
			Console.Write("]");
			Separator();
			Console.Write("\t\t");
			Console.Write("hex: 0x" + Common.Math.ConvertHexFromDec(b) + "\t");
			Console.Write("oct: " + Common.Math.ConvertOctFromDec(b) + "\t");
			Console.WriteLine();
		}

		public static void Separator()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(" ||| ");
			Console.ResetColor();
		}

		public static void EmptyLine()
		{
			Console.WriteLine();
		}

		public static void DrawError(string message)
		{
			Console.WriteLine(" error: " + message);
		}

		#endregion

		#region Information

		private static void CommandHelp()
		{
			Console.WriteLine();
			Console.WriteLine(" All supported commands:");
			Console.WriteLine();
			CommandHelp("help", "this page :)");
			CommandHelp("about", "about the bitwise juggling application");
			CommandHelp("clear", "clear all console output log");
		}

		private static void CommandHelp(string command, string description)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(' ' + command);
			Console.ResetColor();
			Console.WriteLine(" - " + description);
		}

		private static void CommandAbout()
		{
			Console.WriteLine();
			Console.WriteLine(" Bit Juggling " + AssemblyVersion);
			Console.WriteLine(" Author: Koshovyi Dmytro");
			Console.WriteLine(" https://www.koshovyi.com");
			Console.WriteLine(" Copyright (c) 2019");
		}

		#endregion

		private static string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

	}

}
