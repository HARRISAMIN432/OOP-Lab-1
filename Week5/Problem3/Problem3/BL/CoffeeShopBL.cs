using Problem3.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.BL
{
	internal class CoffeeShopBL
	{
		public CoffeeShopBL(string name, List<MenuItemBL> menuItems)
		{
			this.name = name;
			MenuOfRestaurant = menuItems;
		}

		public string name;
		public List<MenuItemBL> MenuOfRestaurant = new List<MenuItemBL>();
		public List<string> Orders = new List<string>();

		public void AddMenuToList(MenuItemBL obj)
		{
			MenuOfRestaurant.Add(obj);
		}

		public void AddMenuItemToList(MenuItemBL menuItem)
		{
			MenuOfRestaurant.Add(menuItem);
		}

		public void DisplayDrinksMenu()
		{
			Console.WriteLine("Drinks");
			foreach (var i in MenuOfRestaurant)
				if (i.Type == "Drink")
					Console.WriteLine(i.Name);
		}

		public void DisplayFoodMenu()
		{
			Console.WriteLine("Food");
			foreach (var i in MenuDL.MenuItems)
				if (i.Type == "Food")
					Console.WriteLine(i.Name);
		}

		public MenuItemBL AddMenuInput()
		{
			Console.WriteLine("Enter name of food item: ");
			string name = Console.ReadLine();
			Console.WriteLine("Enter the type of item: ");
			string type = Console.ReadLine();
			Console.WriteLine("Enter the price of item: ");
			int Price = int.Parse(Console.ReadLine());
			MenuItemBL obj = new MenuItemBL(name, type, Price);
			return obj;
		}

		public void ViewCheapestItem()
		{
			List<int> Prices = new List<int>();
			foreach(var i in MenuOfRestaurant)
			{
				Prices.Add(i.Price);
			}
			foreach(var i in MenuOfRestaurant)
				if (Prices.Min() == i.Price)
					Console.WriteLine("Cheapest Item in menu: " + i.Name);
		}

		public int DueAmount()
		{
			int Bill = 0;
			foreach(var i in Orders)
			{
				foreach (var j in MenuOfRestaurant)
					if (i == j.Name)
						Bill += j.Price;
			}
			return Bill;
		}

		public void FulFillOrder()
		{
			foreach(var i in Orders)
			{
				Console.WriteLine(i + " is ready!");
			}
			Orders.Clear();
		}

		public void ViewOrders()
		{
			foreach (var i in Orders)
			{
				Console.WriteLine(i);
			}
		}
	}
}
