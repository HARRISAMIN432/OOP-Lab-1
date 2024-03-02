using Problem3.BL;
using Problem3.DL;
using Problem3.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MenuDL.ParseData();
			while (true)
			{
				Console.Clear();
				string Option = MenuUI.Menu();
				if (Option == "1")
				{
					Console.Clear();
					string name = CoffeeShopUI.NameOfCoffeeShop();
					foreach (var i in CoffeeShopDL.CoffeeShopList)
					{
						if (i.name == name)
						{
							MenuItemBL obj = i.AddMenuInput();
							i.AddMenuToList(obj);
						}
					}
				}
				if (Option == "2")
				{
					Console.Clear();
					CoffeeShopBL obj = CoffeeShopUI.AddCoffeeShop();
					CoffeeShopDL.AddCoffeeShopDetailsToList(obj);
				}
				if (Option == "3")
				{
					Console.Clear();
					string CoffeeShop = CoffeeShopUI.NameOfCoffeeShop();
					foreach (var i in CoffeeShopDL.CoffeeShopList)
						if (i.name == CoffeeShop)
							i.ViewCheapestItem();
				}
				if (Option == "4")
				{
					Console.Clear();
					string CoffeeShop = CoffeeShopUI.NameOfCoffeeShop();
					foreach (var i in CoffeeShopDL.CoffeeShopList)
						if (i.name == CoffeeShop)
							i.DisplayDrinksMenu();
				}
				if (Option == "5")
				{
					Console.Clear();
					string CoffeeShop = CoffeeShopUI.NameOfCoffeeShop();
					foreach (var i in CoffeeShopDL.CoffeeShopList)
						if (i.name == CoffeeShop)
							i.DisplayFoodMenu();
				}
				if(Option == "6")
				{
					Console.Clear();
					string CoffeeShop = CoffeeShopUI.NameOfCoffeeShop();
					CoffeeShopUI.AddOrder(CoffeeShop);
				}
				if(Option == "7")
				{
					Console.Clear();
					string Coffee = CoffeeShopUI.NameOfCoffeeShop();
					foreach(var i in CoffeeShopDL.CoffeeShopList)
					{
						if (i.name == Coffee)
							i.FulFillOrder();
					}
				}
				if(Option == "8")
				{
					Console.Clear();
					string Coffee = Console.ReadLine();
					foreach (var i in CoffeeShopDL.CoffeeShopList)
					{
						if (i.name == Coffee)
							i.ViewOrders();
					}
				}
				if(Option == "9")
				{
					int amount = 0;
					Console.Clear();
					string CoffeeShop = CoffeeShopUI.NameOfCoffeeShop();
					foreach (var i in CoffeeShopDL.CoffeeShopList)
						if (i.name == CoffeeShop)
							 amount = i.DueAmount();
					CoffeeShopUI.PrintDueAmount(amount);
				}
				if(Option == "10")
				{
					break;
				}
				Console.ReadKey();
			}
		}
	}
}

