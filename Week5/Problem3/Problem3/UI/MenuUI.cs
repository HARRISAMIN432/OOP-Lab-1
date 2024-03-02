﻿using Problem3.BL;
using Problem3.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.UI
{
	internal class MenuUI
	{
		public static string Menu()
		{
			Console.WriteLine("1.  Add a Menu item");
			Console.WriteLine("2.  Add a Coffee Shop");
			Console.WriteLine("3.  View the Cheapest Item in the menu from a specific coffee shop");
			Console.WriteLine("4.  View the Drink’s Menu from a specific coffee shop");
			Console.WriteLine("5.  View the Food’s Menu from a specific coffee shop");
			Console.WriteLine("6.  Add Order in a specific coffee shop");
			Console.WriteLine("7.  Fulfill the Order in a specific coffee shop");
			Console.WriteLine("8.  View the Orders’s List from a specific coffee shop");
			Console.WriteLine("9.  Total Payable Amount from a specific coffee shop");
			Console.WriteLine("10. Exit");
			Console.Write("Enter the option...");
			string option = Console.ReadLine();
			return option;
		}

		public static MenuItemBL AddMenu()
		{
			Console.WriteLine("Enter the name of item: ");
			string Name = Console.ReadLine();
			Console.WriteLine("Enter the type of item: ");
			string Type = Console.ReadLine();
			Console.WriteLine("Enter the price of item: ");
			int Price = int.Parse(Console.ReadLine());
			MenuItemBL obj = new MenuItemBL(Name, Type, Price);
			return obj;
		}
	}
}
