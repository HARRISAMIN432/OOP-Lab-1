using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.UI
{
	internal class ConsoleUtility
	{
		public static string Menu()
		{
			Console.WriteLine("1-  Add Products");
			Console.WriteLine("2-  View ALl Products");
			Console.WriteLine("3-  Find Product with highest unit price");
			Console.WriteLine("4-  View Sales Tax of all Products");
			Console.WriteLine("5-  Products to be ordered");
			Console.Write("Enter the option...");
			string Option = Console.ReadLine();
			return Option;
		}
	}
}
