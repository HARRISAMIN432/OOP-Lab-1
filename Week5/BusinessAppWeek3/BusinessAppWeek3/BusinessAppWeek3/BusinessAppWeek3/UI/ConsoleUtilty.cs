using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAppWeek3.UI
{
	internal class ConsoleUtilty
	{
		public static void PrintHeader()
		{
			Console.Clear();
			int y = 2;
			Console.SetCursorPosition(35, y);
			y++;
			Console.WriteLine("| ____  _ |");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("||  _ \\| |__   __ _ _ __ _ __ ___   __ _  ___ _   _            |");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("|| |_) | '_ \\ / _` | '__| '_ ` _ \\ / _` |/ __| | | |           |");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("||  __/| | | | (_| | |  | | | | | | (_| | (__| |_| |           |");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("||_|  _|_| |_|\\__,_|_|  |_| |_| |_|\\__,_|\\___|\\__, |       _   |");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("||  \\/  | __ _ _ __   __ _  __ _  ___ _ __ ___|___/_ _ __ | |_ |");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("|| |\\/| |/ _` | '_ \\ / _` |/ _` |/ _ \\ '_ ` _ \\ / _ \\ '_ \\| __||");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("|| |  | | (_| | | | | (_| | (_| |  __/ | | | | |  __/ | | | |_ |");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("||_|__|_|\\__,_|_| |_|\\__,_|\\__, |\\___|_| |_| |_|\\___|_| |_|\\__||");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("|/ ___| _   _ ___| |_ ___ _|___/__                             |");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("|\\___ \\| | | / __| __/ _ \\ '_ ` _ \\                            |");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("| ___) | |_| \\__ \\ ||  __/ | | | | |                           |");
			Console.SetCursorPosition(35, y);
			y++;
			Console.Write("||____/ \\__, |___/\\__\\___|_| |_| |_|                           |");
			Console.SetCursorPosition(35, y);
			Console.Write("|       |___/                                                  |");
		}

		public static void EnterCorrectOption()
		{
			Console.WriteLine("Enter correct option!");
		}

		public static string Menu()
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("1- Sign In: ");
			Console.SetCursorPosition(35, 22);
			Console.Write("2- Sign Up: ");
			Console.SetCursorPosition(35, 24);
			Console.Write("3- Exit");
			Console.SetCursorPosition(35, 26);
			Console.Write("Select your option: ");
			string Option = Console.ReadLine();
			return Option;
		}

		public static void PressAnyFingerToContinue()
		{
			Console.Write("Press any key to continue...");
		}

		public static string AdminMenu()
		{
			Console.SetCursorPosition(25, 20);
			Console.Write("1-   Enter data of medicines");
			Console.SetCursorPosition(25, 21);
			Console.Write("2-   Enter data of skin care products");
			Console.SetCursorPosition(25, 22);
			Console.Write("3-   Enter data of eye care products");
			Console.SetCursorPosition(25, 23);
			Console.Write("4-   Enter data of medical devices");
			Console.SetCursorPosition(25, 24);
			Console.Write("5-   Remove data of medicines");
			Console.SetCursorPosition(25, 25);
			Console.Write("6-   Remove data of skin care products");
			Console.SetCursorPosition(25, 26);
			Console.Write("7-   Remove data of eye care products");
			Console.SetCursorPosition(25, 27);
			Console.Write("8-   Remove data of medical devices");
			Console.SetCursorPosition(90, 20);
			Console.Write("9-   Discounts");
			Console.SetCursorPosition(90, 21);
			Console.Write("10-   View data of customers");
			Console.SetCursorPosition(90, 22);
			Console.Write("11-   Search items");
			Console.SetCursorPosition(90, 23);
			Console.Write("12-   View the list of items with prices");
			Console.SetCursorPosition(90, 24);
			Console.Write("13-   Update Prices");
			Console.SetCursorPosition(90, 25);
			Console.Write("14-   View Feedback of customers");
			Console.SetCursorPosition(90, 26);
			Console.Write("15-   Exit");
			Console.SetCursorPosition(90, 28);
			Console.Write("Select an option...");
			string Option = Console.ReadLine();
			return Option;
		}

		public static string CustomerMenu()
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("1-   Order Medicines");
			Console.SetCursorPosition(35, 21);
			Console.Write("2-   Order Skin Care products");
			Console.SetCursorPosition(35, 22);
			Console.Write("3-   Order Eye Care Products");
			Console.SetCursorPosition(35, 23);
			Console.Write("4-   Order Medical Devices");
			Console.SetCursorPosition(35, 24);
			Console.Write("5-   Remove items from order");
			Console.SetCursorPosition(35, 25);
			Console.Write("6-   Order Status");
			Console.SetCursorPosition(35, 26);
			Console.Write("7-   View Items and their prices");
			Console.SetCursorPosition(35, 27);
			Console.Write("8-   Feedback");
			Console.SetCursorPosition(35, 28);
			Console.Write("9-  Cancel order");
			Console.SetCursorPosition(35, 29);
			Console.Write("10-  Payment");
			Console.SetCursorPosition(35, 30);
			Console.Write("11-  Exit");
			Console.SetCursorPosition(35, 32);
			Console.Write("Select an Option: ");
			string Option = Console.ReadLine();
			return Option;
		}

	}
}
