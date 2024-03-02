using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAppWeek3.BL;
using BusinessAppWeek3.DL;

namespace BusinessAppWeek3.UI
{
	internal class ItemsUI
	{
		public static Items InputMedicineData()
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("Enter the name of medicine: ");
			string Medicine = Console.ReadLine();
			Console.SetCursorPosition(35, 21);
			Console.Write("Enter the price of medicine: ");
			string Price = Console.ReadLine();
			while (!Program.IntegerCheck(Price))
			{
				ConsoleUtilty.PrintHeader();
				Console.SetCursorPosition(35, 20);
				Console.Write("Enter the correct price of product: ");
				Price = Console.ReadLine();
			}
			double price = double.Parse(Price);
			Items obj = new Items(Medicine, price);
			return obj;
		}

		public static void AlreadyEnteredItemMessage()
		{
			Console.SetCursorPosition(35, 29);
			Console.Write("You have already entered the item");
		}

		public static Items InputSkinCareData()
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("Enter the name of skin care product: ");
			string Product = Console.ReadLine();
			Console.SetCursorPosition(35, 21);
			Console.WriteLine("Enter the price of product: ");
			string Price = Console.ReadLine();
			while (!Program.IntegerCheck(Price))
			{
				ConsoleUtilty.PrintHeader();
				Console.SetCursorPosition(35, 20);
				Console.Write("Enter the correct price of product: ");
				Price = Console.ReadLine();
			}
			double price = double.Parse(Price);
			Items obj = new Items(Product, price);
			return obj;
		}

		public static Items InputEyeCareData()
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("Enter the name of eye care product: ");
			string Product = Console.ReadLine();
			Console.SetCursorPosition(35, 21);
			Console.Write("Enter the price of product: ");
			string Price = Console.ReadLine();
			while (!Program.IntegerCheck(Price))
			{
				ConsoleUtilty.PrintHeader();
				Console.SetCursorPosition(35, 20);
				Console.WriteLine("Enter the correct price of product: ");
				Price = Console.ReadLine();
			}
			double price = double.Parse(Price);
			Items obj = new Items(Product, price);
			return obj;
		}

		public static Items InputDevicesData()
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("Enter the name of medical device: ");
			string Product = Console.ReadLine();
			Console.SetCursorPosition(35, 21);
			Console.Write("Enter the price of product: ");
			string Price = Console.ReadLine();
			while (!Program.IntegerCheck(Price))
			{
				ConsoleUtilty.PrintHeader();
				Console.SetCursorPosition(35, 20);
				Console.Write("Enter the correct price: ");
				Price = Console.ReadLine();
			}
            double price = double.Parse(Price);
			Items obj = new Items(Product, price);
			return obj;
		}

		public static string EnterMedicineToRemove()
		{
			Console.WriteLine("Enter the name of medicine to remove: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterSkinCareItemToRemove()
		{
			Console.WriteLine("Enter the name of skin care product to remove: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterEyeCareItemToRemove()
		{
			Console.WriteLine("Enter the name of eye care product to remove: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterMedicalDeviceToRemove()
		{
			Console.WriteLine("Enter the name of medical device to remove: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static void MedicineNotInList()
		{
			Console.WriteLine("There is no such medicine in the list!");
		}

		public static void SkinCareNotInList()
		{
			Console.WriteLine("There is no such skin care product in the list!");
		}

		public static void EyeCareNotInList()
		{
			Console.WriteLine("There is no such eye care product in list!");
		}

		public static void MedicalDevicesNotInList()
		{
			Console.WriteLine("There is no such medical device in list!");
		}

		public static void ItemRemoveMessage()
		{
			Console.Write("The item has been removed!");
		}

		public static string EnterMedicineToApplyDiscount()
		{
			Console.Write("Enter the name of medicine to apply discount: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterSkinCareProductToApplyDiscount()
		{
			Console.Write("Enter the name of skin care product to apply discount: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterEyeCareProductToApplyDiscount()
		{
			Console.Write("Enter the name of eye care product to apply discount: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterDeviceToApplyDiscount()
		{
			Console.Write("Enter the name of mrdical device to apply discount: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static double EnterDiscountRate()
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("Enter the discount rate: ");
			string DiscountRate = Console.ReadLine();
			while(!Program.IntegerCheck(DiscountRate))
			{
				ConsoleUtilty.PrintHeader();
				Console.SetCursorPosition(35, 20);
				Console.Write("Enter numeric discount rate: ");
				DiscountRate = Console.ReadLine();
			}
			double Discount = double.Parse(DiscountRate);
			return Discount;
		}

		public static void PriceAfterDiscount(Items obj)
		{
			Console.Write("Price after discount: " + obj.DiscountPrice);
		}

		public static string EnterMedicineToSearch()
		{
			Console.Write("Enter the name of medicine to search: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterSkinCareToSearch()
		{
			Console.Write("Enter the name of skin care product to search: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterEyeCareToSearch()
		{
				Console.Write("Enter the name of medicine to search: ");
				string Item = Console.ReadLine();
				return Item;
		}

		public static string EnterDeviceToSearch()
		{
			Console.Write("Enter the name of medical device to search: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static void ItemDetails(Items obj)
		{
			Console.SetCursorPosition(15, 20);
			Console.Write("Name: " + obj.GetName());
			Console.SetCursorPosition(35, 20);
			Console.Write("Price: " + obj.GetPrice());
			Console.SetCursorPosition(50, 20);
			Console.Write("Discount Rate: " + obj.GetDiscountRate());
			Console.SetCursorPosition(70, 20);
			Console.Write("Discount Price: " + obj.GetDiscountPrice());

		}

		public static string MSEM()
		{
			Console.SetCursorPosition(35, 20);
			Console.Write("On which category you want to apply discount: ");
			Console.SetCursorPosition(35, 21);
			Console.Write("1-   Medicines");
			Console.SetCursorPosition(35, 22);
			Console.Write("2-   Skin Care products");
			Console.SetCursorPosition(35, 23);
			Console.Write("3-   Eye Care products");
			Console.SetCursorPosition(35, 24);
			Console.Write("4-   Medical Devices");
			Console.SetCursorPosition(35, 25);
			Console.Write("Select an option: ");
			string Option = Console.ReadLine();
			return Option;
		}

		public static void ViewProducts()
		{
			int Y = 22;
			Console.SetCursorPosition(45, 20);
			Console.Write("Medicines");
			Console.SetCursorPosition(15, 21);
			Console.Write("Name");
			Console.SetCursorPosition(40, 21);
			Console.Write("Price");
			Console.SetCursorPosition(60, 21);
			Console.Write("Discount Rate");
			Console.SetCursorPosition(80, 21);
			Console.Write("Discount Price");
			foreach(var i in ItemsDL.MedicinesList)
			{
				Console.SetCursorPosition(15, Y);
				Console.Write(i.Name);
				Console.SetCursorPosition(40, Y);
				Console.Write(i.Price);
				Console.SetCursorPosition(60, Y);
				Console.Write(i.DiscountRate);
				Console.SetCursorPosition(80, Y);
				Console.Write(i.DiscountPrice);
				Y++;
			}
			Console.SetCursorPosition(1, Y);
			Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			Console.SetCursorPosition(45, Y + 1);
			Console.Write("Skin Care Products");
			Console.SetCursorPosition(15, Y + 1);
			Console.Write("Name");
			Console.SetCursorPosition(40, Y + 1);
			Console.Write("Price");
			Console.SetCursorPosition(60, Y + 1);
			Console.Write("Discount Rate");
			Console.SetCursorPosition(80, Y + 1);
			Console.Write("Discount Price");
			Y += 2;
			foreach (var i in ItemsDL.SkinCareList)
			{
				Console.SetCursorPosition(15, Y);
				Console.Write(i.Name);
				Console.SetCursorPosition(40, Y);
				Console.Write(i.Price);
				Console.SetCursorPosition(60, Y);
				Console.Write(i.DiscountRate);
				Console.SetCursorPosition(80, Y);
				Console.Write(i.DiscountPrice);
				Y++;
			}
			Console.SetCursorPosition(1, Y);
			Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			Console.SetCursorPosition(45, Y + 1);
			Console.Write("Eye Care Products");
			Console.SetCursorPosition(15, Y + 1);
			Console.Write("Name");
			Console.SetCursorPosition(40, Y + 1);
			Console.Write("Price");
			Console.SetCursorPosition(60, Y + 1);
			Console.Write("Discount Rate");
			Console.SetCursorPosition(80, Y + 1);
			Console.Write("Discount Price");
			Y += 2;
			foreach (var i in ItemsDL.EyeCareList)
			{
				Console.SetCursorPosition(15, Y);
				Console.Write(i.Name);
				Console.SetCursorPosition(40, Y);
				Console.Write(i.Price);
				Console.SetCursorPosition(60, Y);
				Console.Write(i.DiscountRate);
				Console.SetCursorPosition(80, Y);
				Console.Write(i.DiscountPrice);
				Y++;
			}
			Console.SetCursorPosition(1, Y);
			Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			Console.SetCursorPosition(45, Y + 1);
			Console.Write("Medical Devices");
			Console.SetCursorPosition(15, Y + 1);
			Console.Write("Name");
			Console.SetCursorPosition(40, Y + 1);
			Console.Write("Price");
			Console.SetCursorPosition(60, Y + 1);
			Console.Write("Discount Rate");
			Console.SetCursorPosition(80, Y + 1);
			Console.Write("Discount Price");
			Y += 2;
			foreach (var i in ItemsDL.MedicalDevicesList)
			{
				Console.SetCursorPosition(15, Y);
				Console.Write(i.Name);
				Console.SetCursorPosition(40, Y);
				Console.Write(i.Price);
				Console.SetCursorPosition(60, Y);
				Console.Write(i.DiscountRate);
				Console.SetCursorPosition(80, Y);
				Console.Write(i.DiscountPrice);
				Y++;
			}
		}

		public static string EnterMedicineNameToChangePrice()
		{
			Console.Write("Enter the name of medicine of which you want to change price: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterSkinCareToChangePrice()
		{
			Console.Write("Enter the name of skin care product of which you want to change price: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterEyeCareToChangePrice()
		{
			Console.Write("Enter the name of eye care product of which you want to change price: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static string EnterMedicalDeviceToChangePrice()
		{
			Console.Write("Enter the name of device of which you want to change price: ");
			string Item = Console.ReadLine();
			return Item;
		}

		public static double ChangePrice()
		{
			Console.Write("Enter the updated price: ");
			string Price = Console.ReadLine();
			while(!Program.IntegerCheck(Price))
			{
				ConsoleUtilty.PrintHeader();
				Console.SetCursorPosition(35, 20);
				Console.Write("Enter updated price: ");
				Price = Console.ReadLine();
			}
			double P = double.Parse(Price);
			return P;
		}

		public static string EnterItemToRemove()
		{
			Console.Write("Which item would you like to remove from the order: ");
			string Item = Console.ReadLine();
			return Item;
		}
	}
}
