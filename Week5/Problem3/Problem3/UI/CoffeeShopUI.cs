using Problem3.BL;
using Problem3.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.UI
{
	internal class CoffeeShopUI
	{
		public static CoffeeShopBL AddCoffeeShop()
		{
			Console.WriteLine("Enter the name of Coffee Shop: ");
			string name = Console.ReadLine();
			CoffeeShopBL obj = new CoffeeShopBL(name, MenuDL.MenuItems);
			return obj;
		}

		public static string NameOfCoffeeShop()
		{
			Console.WriteLine("Enter name of coffee shop: ");
			string CoffeeShop = Console.ReadLine();
			return CoffeeShop;
		}

		public static void AddOrder(string name)
		{
			string order = "onl";
			while(order != "only")
			{
				Console.WriteLine("Enter the order: ");
				order = Console.ReadLine();
				foreach(var i in CoffeeShopDL.CoffeeShopList)
				{
					if (name == i.name)
						i.Orders.Add(order);
				}
			}
		}

		public static void PrintDueAmount(int amount)
		{
			Console.WriteLine("Total amount due: " + amount);
		}
	}
}
