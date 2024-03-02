using Problem3.BL;
using Problem3.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.DL
{
	internal class CoffeeShopDL
	{
		public static List<CoffeeShopBL> CoffeeShopList = new List<CoffeeShopBL>();

		public static void AddCoffeeShopDetailsToList(CoffeeShopBL obj)
		{
			CoffeeShopList.Add(obj);
		}
	}
}
