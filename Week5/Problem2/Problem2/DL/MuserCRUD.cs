using Problem2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.DL
{
	internal class MuserCRUD
	{
		public static List<MUSER> MUSER_CRUD = new List<MUSER>();
		public static void AddUserToList(MUSER obj)
		{
			MUSER_CRUD.Add(obj);
		}

		public static string SignIn(string Name, string Password)
		{
			foreach (var i in MUSER_CRUD)
				if (i.Name == Name && i.Password == Password)
					return i.Role;
			return "";
		}

		public static MUSER ReturnUserObject(string Name,string Password)
		{
			MUSER obj = new MUSER("", "", "", "", "", "");
			foreach (var i in MUSER_CRUD)
				if (i.Name == Name && i.Password == Password)
					return i;
			return obj;
		}
	}
}
