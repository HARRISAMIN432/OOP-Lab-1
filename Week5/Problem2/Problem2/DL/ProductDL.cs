using Problem2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.DL
{
	internal class ProductDL
	{
		public static List<Product> ProductList = new List<Product>();

		public static void AddProductToList(Product obj)
		{
			ProductList.Add(obj);
		}

		public static string ProductHighestPrice()
		{
			List<double> Prices = new List<double>();
			foreach (var i in ProductList)
				Prices.Add(i.Price);
			double Max = Prices.Max();
			foreach(var i in ProductList)
			{
				if (i.Price == Max)
					return i.NameOfProduct;
			}
			return "";
		}

		public static Product ReturnObject(string Name)
		{
			Product obj = new Product("", "", 0, 0, 0);
			foreach (var i in ProductList)
				if (Name == i.NameOfProduct)
					return i;
			return obj;
		}
	}
}
