using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
	internal class MUSER
	{
		public MUSER(string name, string password, string role, string email, string ContactNumber, string Address)
		{
			Name = name;
			Password = password;
			Role = role;
			this.email = email;
			this.ContactNumber = ContactNumber;
			this.Address = Address;
		}

		public string Name;
		public string Password;
		public string Role;
		public string email;
		public string ContactNumber;
		public string Address;
		public List<Product> ProductsList = new List<Product>();

		public void AddOrder(Product obj)
		{
			ProductsList.Add(obj);
		}

		public void GenerateInvoice()
		{
			double Bill = 0;
			foreach(var i in ProductsList)
			{
				Bill += i.Price ;
			}
			Console.Write("Total bill: " + Bill);
		}
	}
}
