using Problem2.BL;
using Problem2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.U_I
{
	internal class ProductUI
	{
		public static Product TakeProductInput()
		{
			Console.WriteLine("Enter the name of product: ");
			string Name = Console.ReadLine();
			Console.WriteLine("Enter the name of category: ");
			string Category = Console.ReadLine();
			Console.WriteLine("Enter the price: ");
			int Price = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the Quantity: ");
			int Quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the threshold price: ");
			int Threshold = int.Parse(Console.ReadLine());
			Product obj = new Product(Name, Category, Price, Quantity, Threshold);
			return obj;
		}

		public static void ViewProducts()
		{
			Console.WriteLine("Name\tCategory\tPrice\tQuantity\tThreshold");
			foreach (var i in ProductDL.ProductList)
			{
				Console.Write(i.NameOfProduct + "\t");
				Console.Write(i.Category + "\t");
				Console.Write(i.Price + "\t");
				Console.Write(i.Quantity + "\t");
				Console.Write(i.Threshold + "\t");
				Console.Write("\n");
			}
		}

		public static void NameOfProductWithHighestPrice(string Name)
		{
			Console.WriteLine("The product with highest price: " + Name);
		}

		public static void SalesTax()
		{
			foreach (var i in ProductDL.ProductList)
				Console.WriteLine("Sales tax on product name " + i.NameOfProduct + " is: " + i.SalesTax());
		}

		public static string EnterNameOfProduct()
		{
			Console.WriteLine("Enter the name of product: ");
			string Product = Console.ReadLine();
			return Product;
		}

		public static int AddProductQuantity()
		{
			Console.WriteLine("Enter the quantity to be added: ");
			int Quantity = int.Parse(Console.ReadLine());
			return Quantity;
		}

		
	}
}
