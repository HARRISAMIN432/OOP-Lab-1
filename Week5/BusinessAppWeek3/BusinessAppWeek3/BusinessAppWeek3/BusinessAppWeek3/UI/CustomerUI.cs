using BusinessAppWeek3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAppWeek3.UI
{
	internal class CustomerUI
	{
		public static Customer TakeCustomerInformation()
		{
			Console.Write("Enter your name: ");
			string Name = Console.ReadLine();
			Customer obj = new Customer(Name);
			return obj;
		}

		public static OrderedItems TakeOrderItem()
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("Enter name of product: ");
			string Name = Console.ReadLine();
			Console.SetCursorPosition(35, 21);
			Console.Write("Enter quantity: ");
			string Quantity = Console.ReadLine();
			while(!Program.IntegerCheck(Quantity))
			{
				Console.SetCursorPosition(35, 20);
				Console.Write("Enter numeric quantity: ");
				Quantity = Console.ReadLine();
			}
			double Q = double.Parse(Quantity);
			OrderedItems obj = new OrderedItems(Name, Q);
			return obj;
		}

		public static void OrderCompleted()
		{
			Console.Write("Your order have been taken!");
		}

		public static void ItemNotInList()
		{
			Console.Write("There is no such item in the order list!");
		}

		public static void ItemRemovedMessage()
		{
			Console.Write("Item removed");
		}

		public static void OrderStatus(Customer obj)
		{
			Console.SetCursorPosition(15, 20);
			Console.Write("Name");
			Console.SetCursorPosition(50, 20);
			Console.Write("Price");
			Console.SetCursorPosition(85, 20);
			Console.Write("Quantity");
			int Y = 21;
			foreach(var i in obj.OrdersList)
			{
				Console.SetCursorPosition(15, Y);
				Console.Write(i.Name);
				Console.SetCursorPosition(50, Y);
				Console.Write(i.Price);
				Console.SetCursorPosition(85, Y);
				Console.Write(i.Quantity);
				Y++;
			}
			Console.SetCursorPosition(50, Y + 5);
			Console.Write("Bill: " + obj.Bill);
		}

		public static void OrderCancelMessage()
		{
			Console.WriteLine("Order cancelled!");
		}
	}
}
