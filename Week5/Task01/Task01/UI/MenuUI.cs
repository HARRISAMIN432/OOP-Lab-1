using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.UI
{
	internal class MenuUI
	{
		public static void Header()
		{
			Console.WriteLine("***************************************************");
			Console.WriteLine("                     UAMS                          ");
			Console.WriteLine("***************************************************");
		}

		public static string MainMenu()
		{
			Console.WriteLine("1-  Add Student");
			Console.WriteLine("2-  Add degree program");
			Console.WriteLine("3-  Generate merit");
			Console.WriteLine("4-  View registered students");
			Console.WriteLine("5-  View Students of a degree program");
			Console.WriteLine("6-  Register students for a particular program");
			Console.WriteLine("7-  Calculate fees for all registered students");
			Console.WriteLine("8-  Exit");
			Console.Write("Enter the option: ");
			string option = Console.ReadLine();
			return option;
		}

		public static void PressAnyKeyToContinue()
		{
			Console.WriteLine("Press any key to continue...");
		}
	}
}
