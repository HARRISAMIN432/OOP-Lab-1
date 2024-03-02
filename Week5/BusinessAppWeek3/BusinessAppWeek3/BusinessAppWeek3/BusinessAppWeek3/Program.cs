using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using BusinessAppWeek3.UI;
using BusinessAppWeek3.BL;
using BusinessAppWeek3.DL;
namespace BusinessAppWeek3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool paymentDone = false;
			List<string> Feedback = new List<string>();
			while (true)
			{
				string username = "";
				string password = "";
				ConsoleUtilty.PrintHeader();
				string Option = ConsoleUtilty.Menu();
				if (Option == "1")
				{
					ConsoleUtilty.PrintHeader();
					MUSER_UI.TakeUserInput(ref username, ref password);
					if (MUSER_DL.SignIn(username, password) == "admin")
					{
						while(true)
						{
							Console.Clear();
							ConsoleUtilty.PrintHeader();
							Option = ConsoleUtilty.AdminMenu();
							if (Option == "1")
							{
								ConsoleUtilty.PrintHeader();
								Items obj = ItemsUI.InputMedicineData();
								if (!CheckItem(ItemsDL.MedicinesList, obj.Name))
									ItemsDL.AddToMedicinesList(obj);
								else
								{
									ItemsUI.AlreadyEnteredItemMessage();
									Console.ReadKey();
								}
							}
							if (Option == "2")
							{
								ConsoleUtilty.PrintHeader();
								Items obj = ItemsUI.InputSkinCareData();
								if (!CheckItem(ItemsDL.SkinCareList, obj.Name))
									ItemsDL.AddToSkinCareProductsList(obj);
								else
								{
									ItemsUI.AlreadyEnteredItemMessage();
									Console.ReadKey();
								}
							}
							if (Option == "3")
							{
								ConsoleUtilty.PrintHeader();
								Items obj = ItemsUI.InputEyeCareData();
								if (!CheckItem(ItemsDL.EyeCareList, obj.Name))
									ItemsDL.AddToEyeCareProductsList(obj);
								else
								{
									ItemsUI.AlreadyEnteredItemMessage();
									Console.ReadKey();
								}
							}
							if (Option == "4")
							{
								ConsoleUtilty.PrintHeader();
								Items obj = ItemsUI.InputDevicesData();
								if (!CheckItem(ItemsDL.MedicalDevicesList, obj.Name))
									ItemsDL.AddToMedicalDevicesList(obj);
								else
								{
									ItemsUI.AlreadyEnteredItemMessage();
									Console.ReadKey();
								}
							}
							if (Option == "5")
							{
								ConsoleUtilty.PrintHeader();
								Console.SetCursorPosition(35, 20);
								string Medicine = ItemsUI.EnterMedicineToRemove();
								if (!CheckItem(ItemsDL.MedicinesList, Medicine))
								{
									Console.SetCursorPosition(35, 21);
									ItemsUI.MedicineNotInList();
									Console.ReadKey();
								}
								else
								{
									ItemsDL.RemoveMedicineFromList(Medicine);
									Console.SetCursorPosition(35, 21);
									ItemsUI.ItemRemoveMessage();
									Console.SetCursorPosition(35, 22);
									ConsoleUtilty.PressAnyFingerToContinue();
									Console.ReadKey();
								}
							}
							if (Option == "6")
							{
								ConsoleUtilty.PrintHeader();
								Console.SetCursorPosition(35, 20);
								string SkinCare = ItemsUI.EnterSkinCareItemToRemove();
								if (!CheckItem(ItemsDL.SkinCareList, SkinCare))
								{
									Console.SetCursorPosition(35, 21);
									ItemsUI.SkinCareNotInList();
									Console.ReadKey();
								}
								else
								{
									ItemsDL.RemoveSkinCareProductFromList(SkinCare);
									Console.SetCursorPosition(35, 21);
									ItemsUI.ItemRemoveMessage();
									Console.SetCursorPosition(35, 22);
									ConsoleUtilty.PressAnyFingerToContinue();
									Console.ReadKey();
								}
							}
							if (Option == "7")
							{
								ConsoleUtilty.PrintHeader();
								Console.SetCursorPosition(35, 20);
								string EyeCare = ItemsUI.EnterEyeCareItemToRemove();
								if (!CheckItem(ItemsDL.EyeCareList, EyeCare))
								{
									Console.SetCursorPosition(35, 21);
									ItemsUI.EyeCareNotInList();
									Console.ReadKey();
								}
								else
								{
									ItemsDL.RemoveMedicineFromList(EyeCare);
									Console.SetCursorPosition(35, 21);
									ItemsUI.ItemRemoveMessage();
									Console.SetCursorPosition(35, 22);
									ConsoleUtilty.PressAnyFingerToContinue();
									Console.ReadKey();
								}
							}
							if (Option == "8")
							{
								ConsoleUtilty.PrintHeader();
								Console.SetCursorPosition(35, 20);
								string medicalDevice = ItemsUI.EnterMedicalDeviceToRemove();
								if (!CheckItem(ItemsDL.MedicalDevicesList, medicalDevice))
								{
									Console.SetCursorPosition(35, 21);
									ItemsUI.MedicalDevicesNotInList();
									Console.ReadKey();
								}
								else
								{
									ItemsDL.RemoveMedicalDeviceFromList(medicalDevice);
									Console.SetCursorPosition(35, 21);
									ItemsUI.ItemRemoveMessage();
									Console.SetCursorPosition(35, 22);
									ConsoleUtilty.PressAnyFingerToContinue();
									Console.ReadKey();
								}
							}
							if (Option == "9")
							{
								ConsoleUtilty.PrintHeader();
								Option = ItemsUI.MSEM();
								if (Option == "1")
								{
									ConsoleUtilty.PrintHeader();
									Console.SetCursorPosition(35, 20);
									string Medicine = ItemsUI.EnterMedicineToApplyDiscount();
									if(CheckItem(ItemsDL.MedicinesList, Medicine))
									{
										double DiscountRate = ItemsUI.EnterDiscountRate();
										Items obj = ItemsDL.ReturnMedicine(Medicine);
										obj.SetDiscountRate(DiscountRate);
										obj.SetDiscountPrice();
										Console.SetCursorPosition(35, 22);
										ItemsUI.PriceAfterDiscount(obj);
										Console.SetCursorPosition(35, 24);
										ConsoleUtilty.PressAnyFingerToContinue();
									}
									else
										ItemsUI.MedicineNotInList();
									Console.ReadKey();
								}
								if (Option == "2")
								{
									ConsoleUtilty.PrintHeader();
									string SkinCare = ItemsUI.EnterSkinCareProductToApplyDiscount();
									if (CheckItem(ItemsDL.SkinCareList, SkinCare))
									{
										double DiscountRate = ItemsUI.EnterDiscountRate();
										Items obj = ItemsDL.ReturnSkinCare(SkinCare);
										obj.SetDiscountRate(DiscountRate);
										obj.SetDiscountPrice();
										Console.SetCursorPosition(35, 22);
										ItemsUI.PriceAfterDiscount(obj);
										Console.SetCursorPosition(35, 24);
										ConsoleUtilty.PressAnyFingerToContinue();
									}
									else
										ItemsUI.SkinCareNotInList();
									Console.ReadKey();
								}
								if (Option == "3")
								{
									ConsoleUtilty.PrintHeader();
									string EyeCare = ItemsUI.EnterEyeCareProductToApplyDiscount();
									if (CheckItem(ItemsDL.EyeCareList, EyeCare))
									{
										double DiscountRate = ItemsUI.EnterDiscountRate();
										Items obj = ItemsDL.ReturnEyeCare(EyeCare);
										obj.SetDiscountRate(DiscountRate);
										obj.SetDiscountPrice();
										Console.SetCursorPosition(35, 22);
										ItemsUI.PriceAfterDiscount(obj);
										Console.SetCursorPosition(35, 24);
										ConsoleUtilty.PressAnyFingerToContinue();
									}
									else
										ItemsUI.EyeCareNotInList();
									Console.ReadKey();
								}
								if (Option == "4")
								{
									ConsoleUtilty.PrintHeader();
									string MedicalDevice = ItemsUI.EnterDeviceToApplyDiscount();
									if (CheckItem(ItemsDL.MedicalDevicesList, MedicalDevice))
									{
										double DiscountRate = ItemsUI.EnterDiscountRate();
										Items obj = ItemsDL.ReturnDevices(MedicalDevice);
										obj.SetDiscountRate(DiscountRate);
										obj.SetDiscountPrice();
										Console.SetCursorPosition(35, 22);
										ItemsUI.PriceAfterDiscount(obj);
										Console.SetCursorPosition(35, 24);
										ConsoleUtilty.PressAnyFingerToContinue();
									}
									else
										ItemsUI.MedicalDevicesNotInList();
									Console.ReadKey();
								}
								if (Option != "1" && Option != "2" && Option != "3" && Option != "4")
									continue;
							}
							if (Option == "10")
							{
								int Counter = 5;
								ConsoleUtilty.PrintHeader();
								Console.SetCursorPosition(20, 4);
								Console.WriteLine("Name");
								Console.SetCursorPosition(10, 4);
								Console.WriteLine("Serial Number");
								foreach (var i in MUSER_DL.UsersList)
								{
									Console.SetCursorPosition(20, Counter);
									i.PrintName();
									Console.SetCursorPosition(10, Counter);
									MUSER_UI.PrintSerialNumbers(Counter - 4);
									Counter++;
								}
								Console.ReadKey();
							}
							if (Option == "11")
							{
								ConsoleUtilty.PrintHeader();
								Option = ItemsUI.MSEM();
								if (Option == "1")
								{
									ConsoleUtilty.PrintHeader();
									Console.SetCursorPosition(35, 20);
									string Medicine = ItemsUI.EnterMedicineToSearch();
									Items obj = ItemsDL.ReturnMedicine(Medicine);
									if (CheckItem(ItemsDL.MedicinesList, Medicine))
										ItemsUI.ItemDetails(obj);
									else
									{
										Console.SetCursorPosition(35, 22);
										ItemsUI.MedicineNotInList();
									}
									Console.ReadKey();
								}
								if (Option == "2")
								{
									ConsoleUtilty.PrintHeader();
									Console.SetCursorPosition(35, 20);
									Console.Write("Enter the skin care product you want to search: ");
									string SkinCare = ItemsUI.EnterSkinCareToSearch();
									Items obj = ItemsDL.ReturnSkinCare(SkinCare);
									if (CheckItem(ItemsDL.SkinCareList, SkinCare))
										ItemsUI.ItemDetails(obj);
									else
									{
										Console.SetCursorPosition(35, 22);
										ItemsUI.SkinCareNotInList();
									}
									Console.ReadKey();
								}
								if (Option == "3")
								{
									ConsoleUtilty.PrintHeader();
									Console.SetCursorPosition(35, 20);
									string EyeCare = ItemsUI.EnterEyeCareToSearch();
									Items obj = ItemsDL.ReturnEyeCare(EyeCare);
									if (CheckItem(ItemsDL.EyeCareList, EyeCare))
										ItemsUI.ItemDetails(obj);
									else
									{
										Console.SetCursorPosition(35, 22);
										ItemsUI.EyeCareNotInList();
									}
									Console.ReadKey();
								}
								if (Option == "4")
								{
									ConsoleUtilty.PrintHeader();
									Console.SetCursorPosition(35, 20);
									string MedicalDevice = ItemsUI.EnterDeviceToSearch();
									Items obj = ItemsDL.ReturnDevices(MedicalDevice);
									if (CheckItem(ItemsDL.MedicalDevicesList, MedicalDevice))
										ItemsUI.ItemDetails(obj);
									else
									{
										Console.SetCursorPosition(35, 22);
										ItemsUI.MedicalDevicesNotInList();
									}
									Console.ReadKey();
								}
								if (Option != "1" && Option != "2" && Option != "3" && Option != "4")
									continue;
							}
							if (Option == "12")
							{
								ConsoleUtilty.PrintHeader();
								ItemsUI.ViewProducts();
								Console.ReadKey();
							}
							if (Option == "13")
							{
								ConsoleUtilty.PrintHeader();
								Option = ItemsUI.MSEM();
								if (Option == "1")
								{
									ConsoleUtilty.PrintHeader();
									Console.SetCursorPosition(35, 20);
									string Medicine = ItemsUI.EnterMedicineNameToChangePrice();
									if (!CheckItem(ItemsDL.MedicinesList, Medicine))
									{
										ConsoleUtilty.PrintHeader();
										Console.SetCursorPosition(35, 21);
										ItemsUI.MedicineNotInList();
										Console.ReadKey();
									}
									else
									{
										ConsoleUtilty.PrintHeader();
										Items obj = ItemsDL.ReturnMedicine(Medicine);
										double Price = ItemsUI.ChangePrice();
										Console.SetCursorPosition(35, 21);
										obj.SetPrice(Price);
										obj.SetDiscountRate(obj.DiscountRate);
										obj.SetDiscountPrice();
									}
								}
								if (Option == "2")
								{
									ConsoleUtilty.PrintHeader();
									Console.SetCursorPosition(35, 20);
									string SkinCare = ItemsUI.EnterSkinCareToChangePrice();
									if (!CheckItem(ItemsDL.SkinCareList, SkinCare))
									{
										ConsoleUtilty.PrintHeader();
										Console.SetCursorPosition(35, 21);
										ItemsUI.SkinCareNotInList();
										Console.ReadKey();
									}
									else
									{
										ConsoleUtilty.PrintHeader();
										Items obj = ItemsDL.ReturnSkinCare(SkinCare);
										double Price = ItemsUI.ChangePrice();
										Console.SetCursorPosition(35, 21);
										obj.SetPrice(Price);
										obj.SetDiscountRate(obj.DiscountRate);
										obj.SetDiscountPrice();
									}
								}
								if (Option == "3")
								{
									ConsoleUtilty.PrintHeader();
									Console.SetCursorPosition(35, 20);
									string EyeCare = ItemsUI.EnterEyeCareToChangePrice();
									if (!CheckItem(ItemsDL.EyeCareList, EyeCare))
									{
										ConsoleUtilty.PrintHeader();
										Console.SetCursorPosition(35, 21);
										ItemsUI.EyeCareNotInList();
										Console.ReadKey();
									}
									else
									{
										ConsoleUtilty.PrintHeader();
										Items obj = ItemsDL.ReturnEyeCare(EyeCare);
										double Price = ItemsUI.ChangePrice();
										Console.SetCursorPosition(35, 21);
										obj.SetPrice(Price);
										obj.SetDiscountRate(obj.DiscountRate);
										obj.SetDiscountPrice();
									}
								}
								if (Option == "4")
								{
									ConsoleUtilty.PrintHeader();
									Console.SetCursorPosition(35, 20);
									string MedicalDevice = ItemsUI.EnterMedicalDeviceToChangePrice();
									if (!CheckItem(ItemsDL.MedicalDevicesList, MedicalDevice))
									{
										ConsoleUtilty.PrintHeader();
										Console.SetCursorPosition(35, 21);
										ItemsUI.MedicalDevicesNotInList();
										Console.ReadKey();
									}
									else
									{
										ConsoleUtilty.PrintHeader();
										Items obj = ItemsDL.ReturnDevices(MedicalDevice);
										double Price = ItemsUI.ChangePrice();
										Console.SetCursorPosition(35, 21);
										obj.SetPrice(Price);
										obj.SetDiscountRate(obj.DiscountRate);
										obj.SetDiscountPrice();
									}
								}
								if (Option != "1" && Option != "2" && Option != "3" && Option != "4")
									continue;
							}
							if (Option == "14")
							{
								ConsoleUtilty.PrintHeader();
								ViewFeedback(Feedback);
								Console.ReadKey();
							}
							if (Option == "15")
								return;
							if (Option != "1" && Option != "2" && Option != "3" && Option != "4" && Option != "5" && Option != "6" && Option != "7" && Option != "8" && Option != "9" && Option != "10" && Option != "11" && Option != "12" && Option != "13" && Option != "14" && Option != "15")
							{
								Console.SetCursorPosition(35, 33);
								ConsoleUtilty.EnterCorrectOption();
								Console.ReadKey();
							}
						}
					}
					if (MUSER_DL.SignIn(username, password) == "Customer")
					{
						Customer customer = CustomerDL.ReturnCustomer(username);
						while (true)
						{
							ConsoleUtilty.PrintHeader(); 
							Option = ConsoleUtilty.CustomerMenu();
							if (Option == "1")
							{
								ConsoleUtilty.PrintHeader();
								OrderedItems obj = CustomerUI.TakeOrderItem();
								if (CheckItem(ItemsDL.MedicinesList, obj.Name))
								{
									CustomerUI.OrderCompleted();
									Items Item = ItemsDL.ReturnMedicine(obj.Name);
									customer.Bill += Item.DiscountPrice;
									customer.OrdersList.Add(obj);

								}
								else
									ItemsUI.MedicineNotInList();
							}
							if (Option == "2")
							{
								ConsoleUtilty.PrintHeader();
								OrderedItems obj = CustomerUI.TakeOrderItem();
								if (CheckItem(ItemsDL.SkinCareList, obj.Name))
								{
									CustomerUI.OrderCompleted();
									Items Item = ItemsDL.ReturnSkinCare(obj.Name);
									customer.Bill += Item.DiscountPrice;
									customer.OrdersList.Add(obj);
								}
								else
									ItemsUI.SkinCareNotInList();
							}
							if (Option == "3")
							{
								ConsoleUtilty.PrintHeader();
								OrderedItems obj = CustomerUI.TakeOrderItem();
								if (CheckItem(ItemsDL.EyeCareList, obj.Name))
								{
									CustomerUI.OrderCompleted();
									Items Item = ItemsDL.ReturnEyeCare(obj.Name);
									customer.Bill += Item.DiscountPrice;
									customer.OrdersList.Add(obj);
								}
								else
									ItemsUI.EyeCareNotInList();
							}
							if (Option == "4")
							{
								ConsoleUtilty.PrintHeader();
								OrderedItems obj = CustomerUI.TakeOrderItem();
								if (CheckItem(ItemsDL.MedicalDevicesList, obj.Name))
								{
									CustomerUI.OrderCompleted();
									Items Item = ItemsDL.ReturnDevices(obj.Name);
									customer.Bill += Item.DiscountPrice;
									customer.OrdersList.Add(obj);
								}
								else
									ItemsUI.MedicalDevicesNotInList();
							}
							if (Option == "5")
							{
								ConsoleUtilty.PrintHeader();
								Console.SetCursorPosition(35, 20);
								string RemoveItem = ItemsUI.EnterEyeCareItemToRemove();
								if (!customer.CheckOrderItem(RemoveItem))
								{
									Console.Clear();
									ConsoleUtilty.PrintHeader();
									Console.SetCursorPosition(35, 20);
									CustomerUI.ItemNotInList();
									Console.ReadKey();
								}
								else
								{
									customer.RemoveOrder(RemoveItem);
									Items obj = ItemsDL.ReturnMedicine(RemoveItem);
									if (obj == null)
										obj = ItemsDL.ReturnSkinCare(RemoveItem);
									if (obj == null)
										obj = ItemsDL.ReturnEyeCare(RemoveItem);
									if (obj == null)
										obj = ItemsDL.ReturnDevices(RemoveItem);
									customer.Bill -= obj.DiscountPrice;  
									CustomerUI.ItemRemovedMessage();
								}
							}
							if (Option == "6")
							{
								ConsoleUtilty.PrintHeader();
								CustomerUI.OrderStatus(customer);	
								Console.ReadKey();
							}
							if (Option == "7")
							{
								ConsoleUtilty.PrintHeader();
								ItemsUI.ViewProducts();
								Console.ReadKey();
							}
							if (Option == "8")
							{
								ConsoleUtilty.PrintHeader();
								GiveFeedback(Feedback);
							}
							if (Option == "9")
							{
								ConsoleUtilty.PrintHeader();
								customer.CancelOrder();
								customer.Bill = 0;
								Console.SetCursorPosition(35, 20);
								CustomerUI.OrderCancelMessage();
								Console.ReadKey();
							}
							if (Option == "10")
							{
								ConsoleUtilty.PrintHeader();
							}
							if (Option == "11")
								return;
							if (Option != "1" && Option != "2" && Option != "3" &&  Option != "4" && Option != "5" && Option != "6" && Option != "7" && Option != "8" && Option != "9" && Option != "10" && Option != "11")
							{
								Console.SetCursorPosition(35, 35);
								Console.Write("Select a valid Option!");
								Console.ReadKey();
								continue;
							}
						}
					}
					if (MUSER_DL.SignIn(username, password) == null)
					{
						Console.SetCursorPosition(35, 24);
						MUSER_UI.UnsuccessfulSignIn();
						Console.ReadKey();
					}
				}
				else if (Option == "2")
				{
					ConsoleUtilty.PrintHeader();
					MUSER obj = MUSER_UI.SignUp();
					if(MUSER_DL.AlreadySigned(obj.name))
					{
						Console.SetCursorPosition(35, 29);
						MUSER_UI.AlreadyRegisteredMessage();
						Console.ReadKey();
					}
					else
					{
						Console.SetCursorPosition(35, 29);
						MUSER_UI.SuccessfullySignedMessage();
						if(obj.role == "Customer" || obj.role == "customer")
						{
							Customer c = CustomerUI.TakeCustomerInformation();
							CustomerDL.AddToCustomersList(c);
						}
						Console.ReadKey();
						MUSER_DL.AddUserToList(obj);
					}
				}
				else if (Option == "3")
					return;
				else
				{
					Console.SetCursorPosition(35, 26);
					ConsoleUtilty.EnterCorrectOption();
					Console.ReadKey();
				}
			}
		}

		static void GiveFeedback(List<string> Feedback)
		{
			Console.SetCursorPosition(35, 21);
			string feedback = Console.ReadLine();
			Feedback.Add(feedback);
		}

		static bool CheckItem(List<Items> ProductsList, string ProductName)
		{
			foreach (var Product in ProductsList)
				if (ProductName == Product.Name)
					return true;
			return false;
		}

		public static bool IntegerCheck(string text)
		{
			for (int i = 0; i < text.Length; i++)
				if (!char.IsDigit(text[i]))
					return false;
			return true;
		}

		static bool paymentCheck(bool paymentDone)
		{
			return paymentDone;
		}

		public static bool CheckSpecialCharacters(string Text)
		{
			foreach (var i in Text)
				if (i == '!' || i == '@' || i == '#' || i == '$' || i == '%' || i == '^' || i == '&' || i == '*' || i == '(' || i == ')' || i == '-' || i == '+' || i == '=' || i == '<' || i == '>' || i == '.' || i == ',' || i == '?' || i == '/' || i == '\\' || i == '}' || i == '{' || i == ']' || i == '[' || i == ':' || i == ';' || i == '"' || i == '\'' || i == '`' || i == '~')
					return true;
			return false;
		}

		static void ViewFeedback(List<string> Feedback)
		{
			foreach (var i in Feedback)
			{
				Console.WriteLine(i);
				Console.WriteLine();
			}
		}
	}
}