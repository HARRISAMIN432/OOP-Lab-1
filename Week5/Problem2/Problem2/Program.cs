using Problem2.BL;
using Problem2.DL;
using Problem2.U_I;
using Problem2.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Clear();
				string Option = ConsoleUtility.SignMenu();
				if (Option == "1")
				{
					Console.Clear();
					MUSER obj = MuserUI.TakeUserInput();
					MuserCRUD.AddUserToList(obj);
					Console.ReadKey();
				}
				if (Option == "2")
				{
					Console.Clear();
					string Name = "";
					string Password = "";
					MuserUI.SignInInput(ref Name, ref Password);
					string Role = MuserCRUD.SignIn(Name, Password);
					if (Role == "admin")
					{
						Console.Clear();
						string option = ConsoleUtility.AdminMenu();
						if(option == "1")
						{
							Console.Clear();
							Product obj = ProductUI.TakeProductInput();
							ProductDL.AddProductToList(obj);
						}
						if(option == "2")
						{
							Console.Clear();
							ProductUI.ViewProducts();
						}
						if (option == "3")
						{
							Console.Clear();
							string NameOfProduct = ProductDL.ProductHighestPrice();
							ProductUI.NameOfProductWithHighestPrice(NameOfProduct);
						}
						if (option == "4")
						{
							Console.Clear();
							ProductUI.SalesTax();
						}
						if (option == "5")
						{
							Console.Clear();
							string Product = ProductUI.EnterNameOfProduct();
							Product obj = ProductDL.ReturnObject(Product);
							int Quantity = ProductUI.AddProductQuantity();
							if (!(obj.AddProductStock(Quantity)))
								Console.WriteLine("Stock is out of range!");
						}
						if (option == "6")
						{
							Console.Clear();
							MuserUI.SignInInput(ref Name, ref Password);
							MUSER obj = MuserCRUD.ReturnUserObject(Name, Password);
							MuserUI.DisplayUserInformation(obj);
						}
						if (option == "7")
							return;
					}
					if (Role == "User")
					{
						MUSER obj = MuserCRUD.ReturnUserObject(Name, Password);
						string option = ConsoleUtility.UserMenu();
						if (option == "1")
						{
							Console.Clear();
							ProductUI.ViewProducts();
						}
						if(option == "2")
						{
							Console.Clear();
							string Product = ProductUI.EnterNameOfProduct();
							Product objs = ProductDL.ReturnObject(Product);
							int Quantity = ProductUI.AddProductQuantity();
							obj.AddOrder(objs);
							objs.Quantity -= Quantity;
							
						}
						if (option == "3")
						{
							Console.Clear();
							obj.GenerateInvoice();
							Console.ReadKey();
						}
						if (option == "4")
						{
							Console.Clear();
							MuserUI.DisplayUserInformation(obj);
							Console.ReadKey();
						}
						if (option == "5")
							return;
					}
				}
				if (Option == "3")
					return;
			}
		}
	}
}
