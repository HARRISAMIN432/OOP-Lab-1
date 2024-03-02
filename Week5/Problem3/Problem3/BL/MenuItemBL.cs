using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.BL
{
	internal class MenuItemBL
	{
		public string Name;
		public string Type;
		public int Price;

		public MenuItemBL(string n, string t, int p)
		{
			Name = n;
			Type = t;
			Price = p;
		}

		public MenuItemBL()
		{

		}
	}
}
