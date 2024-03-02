using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAppWeek3.BL
{
	internal class OrderedItems
	{
		public string Name;
		public double Price;
		public double Quantity;

		public OrderedItems(string Name, double Quantity)
		{
			this.Name = Name;
			this.Quantity = Quantity;
		}
	}
}
