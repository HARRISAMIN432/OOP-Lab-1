using BusinessAppWeek3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAppWeek3.DL
{
	internal class CustomerDL
	{
		public static List<Customer> CustomersList = new List<Customer>(); 

		public static void AddToCustomersList(Customer obj)
		{
			CustomersList.Add(obj);
		}

		public static Customer ReturnCustomer(string Name)
		{
			foreach (var i in CustomersList)
				if (Name == i.Name)
					return i;
			return null;
		}
	}
}
