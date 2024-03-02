using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAppWeek3.BL
{
	internal class MUSER
	{
		public MUSER(string name, string password, string role)
		{
			this.name = name;
			this.password = password;
			this.role = role;
		}
		public string name;
		public string password;
		public string role;

		public void PrintName()
		{
			Console.Write(name);
		}
	}
}
