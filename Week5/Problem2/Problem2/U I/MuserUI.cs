using Problem2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem2.U_I
{
	internal class MuserUI
	{
		public static MUSER TakeUserInput()
		{
			Console.WriteLine("Enter the name: ");
			string Name = Console.ReadLine();
			Console.WriteLine("Enter the password: ");
			string Password = Console.ReadLine();
			Console.WriteLine("Enter the Role: ");
			string Role = Console.ReadLine();
			Console.WriteLine("Enter the email: ");
			string email = Console.ReadLine();
			Console.WriteLine("Enter the Address: ");
			string Address = Console.ReadLine();
			Console.WriteLine("Enter the Contact number: ");
			string CN = Console.ReadLine();
			MUSER obj = new MUSER(Name, Password, Role,email,CN,Address);
			return obj;
		}

		public static void SignInInput(ref string Name, ref string Password)
		{
			Console.WriteLine("Enter the name: ");
			Name = Console.ReadLine();
			Console.WriteLine("Enter the password: ");
			Password = Console.ReadLine();
		}

		public static void DisplayUserInformation(MUSER obj)
		{
			Console.WriteLine("Name: " + obj.Name);
			Console.WriteLine("Password: " + obj.Password);
			Console.WriteLine("Email: " + obj.email);
			Console.WriteLine("Contact Number: " + obj.ContactNumber);
			Console.WriteLine("Address: " + obj.Address);
		}
	}
}
