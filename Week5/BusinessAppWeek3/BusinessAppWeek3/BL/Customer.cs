using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAppWeek3.BL
{
	internal class Customer
	{
		public string Name;
		public double Bill;
		public List<OrderedItems> OrdersList = new List<OrderedItems>();

		public Customer(string Name)
		{
			this.Name = Name;
		}

		public bool CheckOrderItem(string Name)
		{
			foreach (var i in OrdersList)
				if (i.Name == Name)
					return true;
			return false;
		}

		public void RemoveOrder(string Name)
		{
			int Counter = 0;
			foreach (var i in OrdersList)
			{
				if (i.Name == Name)
					OrdersList.RemoveAt(Counter);
				Counter++;
			}
		}

		public void CancelOrder()
		{
			OrdersList.Clear();
		}
	}
}
