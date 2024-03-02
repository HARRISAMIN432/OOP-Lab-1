using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
	internal class Product
	{
		public Product(string NameOfProduct, string Category, int Price, int Quantity, int Threshold)
		{
			this.NameOfProduct = NameOfProduct;
			this.Category = Category;
			this.Price = Price;
			this.Quantity = Quantity;
			this.Threshold = Threshold;
		}

		public string NameOfProduct;
		public string Category;
		public double Price;
		public int Quantity;
		public int Threshold;

		public int SalesTax()
		{
			int Tax = 0;
			if (Category == "Fruit" || Category == "Fruits" || Category == "fruit" || Category == "fruits")
				Tax = 5;
			else if (Category == "Product")
				Tax = 10;
			else
				Tax = 15;
			return Tax;
		}

		public bool AddProductStock(int Quantity)
		{
			if (Quantity > 0 && Quantity <= Threshold)
			{
				this.Quantity = Quantity;
				return true;
			}
			return false;
		}
	}
}
