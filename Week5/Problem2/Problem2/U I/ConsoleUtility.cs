using Problem2.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.UI
{
	internal class ConsoleUtility
	{
		public static string UserMenu()
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

		public static string AdminMenu()
		{
			Console.WriteLine("1.Add Product.");
			Console.WriteLine("2.View All Products.");
			Console.WriteLine("3.Find Product with Highest Unit Price");
			Console.WriteLine("4.View Sales Tax of All Products.");
			Console.WriteLine("5.Products to be Ordered. (less than threshold");
			Console.WriteLine("6.View Profile(Username, Password");
			Console.WriteLine("7.Exit");
			Console.Write("Enter the option...");
			string Option = Console.ReadLine(); 
			return Option;
		}

		public static string SignMenu()
		{
			Console.WriteLine("1-  Sign Up");
			Console.WriteLine("2-  Sign In");
			Console.WriteLine("3-  Exit");
			Console.WriteLine("Enter the option...");
			string Option = Console.ReadLine();
			return Option;
		}
	}
}
