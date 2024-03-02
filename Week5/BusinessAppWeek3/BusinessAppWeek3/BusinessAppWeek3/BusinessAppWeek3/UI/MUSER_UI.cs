using BusinessAppWeek3.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessAppWeek3.UI
{
	internal class MUSER_UI
	{
		public static MUSER SignUp()
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("Enter the user name: ");
			string name = Console.ReadLine();
			while (Program.CheckSpecialCharacters(name) || name.Count() < 5)
			{
				Console.Clear();
				Console.SetCursorPosition(35, 26);
				Console.Write("username cannot contain special characters and cannot be 5 characters short.");
				Console.ReadKey();
				Console.SetCursorPosition(35, 22);
				Console.Write("Enter the user name: ");
				name = Console.ReadLine();
			}
			Console.SetCursorPosition(35, 22);
			Console.Write("Enter the password: ");
			Console.SetCursorPosition(35, 23);
			Console.Write("Password must be 8 characters long: ");
			string password = Console.ReadLine();
			while (password.Count() < 8)
			{
				Console.Clear();
				Console.SetCursorPosition(35, 26);
				Console.Write("Password not valid!");
				Console.ReadKey();
				Console.SetCursorPosition(35, 22);
				Console.Write("Re-enter your password: ");
				password = Console.ReadLine();
			}
			Console.SetCursorPosition(35, 25);
			Console.Write("Enter your role: ");
			string role = Console.ReadLine();
			while (role != "admin" && role != "customer")
			{
				Console.Clear();
				Console.SetCursorPosition(35, 26);
				Console.Write("role not valid!");
				Console.ReadKey();
				Console.SetCursorPosition(35, 22);
				Console.Write("Re-enter your role: ");
				role = Console.ReadLine();
			}
			MUSER obj = new MUSER(name, password, role);
			return obj;
		}

		public static void AlreadyRegisteredMessage()
		{
			Console.Write("Already registered");
		}

		public static void SuccessfullySignedMessage()
		{
			Console.WriteLine("Successfully Registered!");
		}

		public static void UnsuccessfulSignIn()
		{
			Console.Write("Username or password is incorrect");
		}

		public static void TakeUserInput(ref string Name, ref string Password)
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("Enter the user name: ");
			Name = Console.ReadLine();
			Console.SetCursorPosition(35, 22);
			Console.Write("Enter the password: ");
			Password = Console.ReadLine();
		}

		public static void PrintSerialNumbers(int c)
		{
			Console.Write(c);
		}
	}
}
