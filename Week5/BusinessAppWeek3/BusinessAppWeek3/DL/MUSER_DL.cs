using BusinessAppWeek3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessAppWeek3.DL
{
	internal class MUSER_DL
	{
		public static List<MUSER> UsersList = new List<MUSER>();

		public static bool AlreadySigned(string Name)
		{
			foreach (var i in UsersList)
				if (Name == i.name)
					return true;
			return false;
		}

		public static void AddUserToList(MUSER obj)
		{
			UsersList.Add(obj);
		}

		public static string SignIn(string Name, string Password)
		{
			foreach (var User in UsersList)
				if (User.name == Name && User.password == Password)
					return User.role;
			return null;
		}
	}
}
