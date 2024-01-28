using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;
using System.Net;

namespace BusinessAppClass
{
	internal class Program
	{
		static void printHeader()
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
			y++;
			Console.Write("|       |___/                                                  |");
		}
		static int Main(string[] args)
		{
			bool paymentDone = false;
			int totalPrice = 0, salesRecordCounter = 0, customerCount = 0;
			string[] salesRecord = new string[500];
			string[] orderMedicines = new string[100];
			string[] orderSkinCares = new string[100];
			string[] orderEyeCares = new string[100];
			string[] orderDevice = new string[100];
			int orderCounterMedicines = 0, orderCounterSkin = 0, orderCounterEye = 0, orderCounterDevices = 0;
			int discountCounterMedicines = 0, discountCounterSkinCare = 0, discountCounterEyeCare = 0, discountCounterDevices = 0;
			int feedbackCounter = 0, ia = 0, ja = 0, ka = 0, la = 0;
			string[] Feedback = new string[100];
			discountMedicineClass[] discountMedicinesData = new discountMedicineClass[100];
			discountSkinCareClass[] discountSkinCareData = new discountSkinCareClass[100];
			discountEyeCareClass[] discountEyeCareData = new discountEyeCareClass[100];
			discountDevicesClass[] discountDevicesData = new discountDevicesClass[100];
			medicineClass[] medicineData = new medicineClass[100];
			skinCareClass[] skinCaraData = new skinCareClass[100];
			eyeCareClass[] eyeCareData = new eyeCareClass[100];
			devicesClass[] devicesData = new devicesClass[100];
			int signUpCounter = 0, enterDataMedicine = 0, enterDataSkin = 0, enterDataEye = 0, enterDataDevices = 0, enterDataSnacks = 0;
			string username, password, role, yourChoice;
			signIn[] userData = new signIn[100];
			storeNamesAndPasswordOfCustomers(userData, ref signUpCounter);
			storeMedicines(medicineData, ref enterDataMedicine);
			storeSkinCare(skinCaraData, ref enterDataSkin);
			storeEyeCare(eyeCareData, ref enterDataEye);
			storeDataDevices(devicesData, ref enterDataDevices);
			storeDiscountMedicines(discountMedicinesData, ref discountCounterMedicines);
			storeDiscountedSkinCare(discountSkinCareData, ref discountCounterSkinCare);
			storeDiscountedEyeCare(discountEyeCareData, ref discountCounterEyeCare);
			storeDiscountedDevices(discountDevicesData, ref discountCounterDevices);
			while (true)
			{
				printHeader();
				Console.SetCursorPosition(35, 20);
				Console.Write("1- Sign In: ");
				Console.SetCursorPosition(35, 22);
				Console.Write("2- Sign Up: ");
				Console.SetCursorPosition(35, 24);
				Console.Write("3- Exit");
				Console.SetCursorPosition(35, 26);
				Console.Write("Select your option: ");
				yourChoice = Console.ReadLine();
				if (yourChoice == "1")
				{
					Console.Clear();
					printHeader();
					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the user name: ");
					username = Console.ReadLine();
					Console.SetCursorPosition(35, 22);
					Console.Write("Enter the password: ");
					password = Console.ReadLine();
					customerCount = checkCustomerCount(userData, username, signUpCounter);
					for (int i = 0; i <= signUpCounter; i++)
					{
						if (signIn(username, password, userData, signUpCounter))
						{
							if (username == userData[i].name)
							{
								if (i == 0)
								{
									admin(userData, ref signUpCounter, medicineData, skinCaraData, eyeCareData, devicesData, ref enterDataMedicine, ref enterDataSkin, ref enterDataEye, ref enterDataDevices, ref enterDataSnacks, Feedback, ref feedbackCounter, discountMedicinesData, discountSkinCareData, discountEyeCareData, discountDevicesData, ref ia, ref ja, ref ka, ref la, ref discountCounterMedicines, ref discountCounterSkinCare, ref discountCounterEyeCare, ref discountCounterDevices, orderMedicines, orderSkinCares, orderEyeCares, orderDevice, orderCounterMedicines, orderCounterSkin, orderCounterEye, orderCounterDevices, ref totalPrice, salesRecord, ref salesRecordCounter);
									break;
								}
								if (i > 0)
								{
									customer(medicineData, skinCaraData, eyeCareData, devicesData, ref enterDataMedicine, ref enterDataSkin, ref enterDataEye, ref enterDataDevices, ref enterDataSnacks, Feedback, ref feedbackCounter, discountMedicinesData, discountSkinCareData, discountEyeCareData, discountDevicesData, ref ia, ref ja, ref ka, ref la, ref discountCounterMedicines, ref discountCounterSkinCare, ref discountCounterEyeCare, ref discountCounterDevices, orderMedicines, orderSkinCares, orderEyeCares, orderDevice, orderCounterMedicines, orderCounterSkin, orderCounterEye, orderCounterDevices, ref totalPrice, userData, ref signUpCounter, ref customerCount, salesRecord, ref salesRecordCounter, ref paymentDone);
									break;
								}
							}
						}
					}
					if (!signIn(username, password, userData, signUpCounter))
					{
						Console.SetCursorPosition(35, 24);
						Console.Write("Username or password is incorrect");
						Console.ReadKey();
					}
				}
				else if (yourChoice == "2")
				{
					string name;
					printHeader();
					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the user name: ");
					name = Console.ReadLine();
					while (checkSpecialCharacters(name) || name.Count() < 5)
					{
						Console.SetCursorPosition(35, 22);

						Console.Write("username cannot contain special characters and cannot be 5 characters short.");
						Console.ReadKey();
						printHeader();
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the user name: ");
						name = Console.ReadLine();
					}
					Console.SetCursorPosition(35, 22);
					Console.Write("Enter the password: ");
					Console.SetCursorPosition(35, 23);
					Console.Write("Password must be 8 characters long: ");
					string passwords = Console.ReadLine();
					while (passwords.Count() < 8)
					{
						Console.Clear();
						printHeader();
						Console.SetCursorPosition(35, 20);
						Console.Write("Password not valid!");
						Console.ReadKey();
						Console.SetCursorPosition(35, 22);
						Console.Write("Re-enter your password: ");
						passwords = Console.ReadLine();
					}
					Console.SetCursorPosition(35, 25);
					Console.Write("Enter your role: ");
					role = Console.ReadLine();
					while(role != "admin" && role != "customer")
					{
						Console.Clear();
						printHeader();
						Console.SetCursorPosition(35, 26);
						Console.Write("role not valid!");
						Console.ReadKey();
						Console.SetCursorPosition(35, 22);
						Console.Write("Re-enter your role: ");
						passwords = Console.ReadLine();
					}
					Console.SetCursorPosition(35, 29);
					Console.Write(SignUp(name, passwords,role, userData, ref signUpCounter));					
					Console.SetCursorPosition(35, 30);
					Console.Write("Press any key to continue: ");
					Console.ReadKey();
				}
				else if (yourChoice == "3")
				{
					return 0;
				}
				else
				{
					Console.WriteLine(yourChoice);
					Console.SetCursorPosition(35, 26);
					Console.WriteLine("Enter a valid option!");
					Console.ReadKey();
				}
			}
		}

		static int checkCustomerCount(signIn[] userData, string username, int signUpCounter)
		{
			int n = -1;
			for (int i = 0; i < signUpCounter; i++)
			{
				if (username == userData[i].name)
				{
					n = i;
				}
			}
			return n;
		}

		static bool signIn(string username, string password, signIn[] userData, int signUpCounter)
		{
			if (signUpCounter == 0)
				return false;
			for (int i = 0; i < signUpCounter; i++)
			{
				if (username == userData[i].name && password == userData[i].password && username != "\0")
				{
					return true;
				}
			}
			return false;
		}

		static string SignUp(string name, string password,string role, signIn[] userData, ref int signUpCounter)
		{
			userData[signUpCounter] = signInInput(name, password,role);
			if (signUpCounter >= 500)
			{
				return "Maximum number of customers have signed up.";
			}
			for (int i = 0; i < signUpCounter; i++)
			{
				if (userData[signUpCounter].name == userData[i].name)
				{
					userData[signUpCounter].name = "\0";
					userData[signUpCounter].password = "\0";
					return "Already registered!";
				}
			}
			fileSignUp(userData, signUpCounter);
			if (signUpCounter == 0)
			{
				signUpCounter++;
				return "You have been registered as an admin.";
			}
			signUpCounter++;
			return "You have been registered successfully as a customer.";
		}

		static int admin(signIn[] userData, ref int signUpCounter, medicineClass[] medicineData, skinCareClass[] skinCareData, eyeCareClass[] eyeCareData, devicesClass[] devicesData, ref int enterDataMedicine, ref int enterDataSkin, ref int enterDataEye, ref int enterDataDevices, ref int enterDataSnacks, string[] Feedback, ref int feedbackCounter, discountMedicineClass[] discountMedicinesData, discountSkinCareClass[] discountSkinCareData, discountEyeCareClass[] discountEyeCareData, discountDevicesClass[] discountDevicesData, ref int ia, ref int ja, ref int ka, ref int la, ref int discountCounterMedicines, ref int discountCounterSkinCare, ref int discountCounterEyeCare, ref int discountCounterDevices, string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice, int orderCounterMedicines, int orderCounterSkin, int orderCounterEye, int orderCounterDevices, ref int totalPrice, string[] salesRecord, ref int salesRecordCounter)
		{
			storeFeedback(Feedback, ref feedbackCounter);
			string medicine, skinCares, eyeCares, medicalDevice, enterNumber;
			while (true)
			{
				printHeader();
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
				enterNumber = Console.ReadLine();
				if (enterNumber == "1")
				{
					printHeader();
					Console.SetCursorPosition(35, 20);
					if (enterDataMedicine >= 100)
					{
						Console.Write("You have entered maximum number of medicines");
						continue;
					}

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the name of medicine: ");
					medicine = Console.ReadLine();
					Console.SetCursorPosition(35, 23);
					Console.Write("Enter price: ");
					string text;
					text = Console.ReadLine();
					while (!checkInteger(text))
					{
						Console.SetCursorPosition(35, 25);
						Console.Write("Enter a valid digit: ");
						Console.ReadKey();
						printHeader();
						Console.SetCursorPosition(35, 20);

						Console.Write("Enter the name of medicine: " + medicine);
						Console.SetCursorPosition(35, 23);

						Console.Write("Enter price: ");
						text = Console.ReadLine();
					}
					int price = int.Parse(text);
					if (!checkMedicine(medicineData, medicine, ref enterDataMedicine))
					{
						medicineData[enterDataMedicine] = medicinesInput(medicine, price);
						fileMedicines(medicineData, enterDataMedicine);
						enterDataMedicine++;
					}
					else
					{
						Console.SetCursorPosition(35, 29);
						Console.Write("You have already entered the item");
						Console.ReadKey();
						removeRepeatedMedicine(medicine, medicineData, ref enterDataMedicine);
					}
				}
				if (enterNumber == "2")
				{
					printHeader();
					Console.SetCursorPosition(35, 20);
					if (enterDataSkin >= 100)
					{
						;
						Console.Write("You have entered maximum number of skin care products");
						continue;
					}

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the name of the skin care product: ");
					skinCares = Console.ReadLine();
					Console.SetCursorPosition(35, 21);
					Console.Write("Enter price: ");
					string text;
					text = Console.ReadLine();
					while (!checkInteger(text))
					{
						Console.SetCursorPosition(35, 25);
						Console.Write("Enter a valid digit: ");
						Console.ReadKey();
						printHeader();
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the name of skin care product: " + skinCares);
						Console.SetCursorPosition(35, 23);
						Console.Write("Enter price: ");
						text = Console.ReadLine();
					}
					int price = int.Parse(text);
					if (!checkSkinCare(skinCareData, skinCares, ref enterDataSkin))
					{
						skinCareData[enterDataSkin] = skinCareInput(skinCares, price);
						fileSkinCare(skinCareData, enterDataSkin);
						enterDataSkin++;
					}
					else
					{
						;
						Console.SetCursorPosition(35, 23);
						Console.Write("You have already entered the item");
						Console.ReadKey();
						removeRepeatedSkinCare(skinCareData, skinCares, ref enterDataSkin);
					}
				}
				if (enterNumber == "3")
				{
					printHeader();
					Console.SetCursorPosition(35, 20);
					if (enterDataEye >= 100)
					{
						;
						Console.Write("You have entered maximum number of eye care products");
						continue;
					}

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the name of the eye care product: ");
					eyeCares = Console.ReadLine();
					Console.SetCursorPosition(35, 21);
					Console.Write("Enter price: ");
					string text;
					text = Console.ReadLine();
					while (!checkInteger(text))
					{
						;
						Console.SetCursorPosition(35, 25);
						Console.Write("Enter a valid digit: ");
						Console.ReadKey();
						printHeader();

						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the name of eye care product: " + eyeCares);
						Console.SetCursorPosition(35, 23);
						Console.Write("Enter price: ");
						text = Console.ReadLine();
					}
					int price = int.Parse(text);
					if (!checkEyeCare(eyeCareData, eyeCares, ref enterDataEye))
					{
						fileEyeCare(eyeCareData, enterDataEye);
						enterDataEye++;
					}
					else
					{
						;
						Console.SetCursorPosition(35, 23);
						Console.Write("You have already entered the item");
						Console.ReadKey();
						removeRepeatedEyeCare(eyeCareData, eyeCares, ref enterDataEye);
					}
				}
				if (enterNumber == "4")
				{
					printHeader();
					Console.SetCursorPosition(35, 20);
					if (enterDataDevices >= 100)
					{
						Console.Write("You have entered maximum number of devices");
						continue;
					}

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the name of medical device: ");
					medicalDevice = Console.ReadLine();
					Console.SetCursorPosition(35, 21);
					Console.Write("Enter price: ");
					string text;
					text = Console.ReadLine();
					while (!checkInteger(text))
					{
						;
						Console.SetCursorPosition(35, 25);
						Console.Write("Enter a valid digit: ");
						Console.ReadKey();
						printHeader();

						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the name of medical device: " + medicalDevice);
						Console.SetCursorPosition(35, 23);
						Console.Write("Enter price: ");
						text = Console.ReadLine();
					}
					int price = int.Parse(text);
					if (!checkDevices(devicesData, medicalDevice, ref enterDataDevices))
					{
						fileMedicalDevices(devicesData, enterDataDevices);
						enterDataEye++;
					}
					else
					{
						Console.SetCursorPosition(35, 23);
						Console.Write("You have already entered the item");
						Console.ReadKey();
						removeRepeatedDevices(devicesData, medicalDevice, ref enterDataDevices);
					}
				}
				if (enterNumber == "5")
				{
					int y = 20;
					printHeader();

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the medicine you want to remove: ");
					medicine = Console.ReadLine();
					if (!checkMedicine(medicineData, medicine, ref enterDataMedicine))
					{
						Console.SetCursorPosition(35, y + 1);
						Console.Write("There is no such medicine in the list.");
						Console.ReadKey();
					}
					else
					{
						removeMedicine(medicineData, medicine, ref enterDataMedicine);
						Console.SetCursorPosition(35, 21);
						Console.Write("The item has been removed!");
						Console.SetCursorPosition(35, 22);
						fileMedicines(medicineData, enterDataMedicine);
						Console.Write("Press any key to continue...");
						Console.ReadKey();
					}
				}
				if (enterNumber == "6")
				{
					printHeader();

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the skin care product you want to remove: ");
					skinCares = Console.ReadLine();
					if (!checkSkinCare(skinCareData, skinCares, ref enterDataSkin))
					{
						;
						Console.SetCursorPosition(35, 21);
						Console.Write("There is no such item in the list.");
						Console.ReadKey();
					}
					else
					{

						removeSkinCare(skinCareData, skinCares, ref enterDataSkin);
						Console.SetCursorPosition(35, 21);
						Console.Write("The item has been removed!");
						Console.SetCursorPosition(35, 22);
						fileSkinCare(skinCareData, enterDataSkin);
						Console.Write("Press any key to continue...");
						Console.ReadKey();
					}
				}
				if (enterNumber == "7")
				{
					printHeader();

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the eye care product you want to remove: ");
					eyeCares = Console.ReadLine();
					if (!checkEyeCare(eyeCareData, eyeCares, ref enterDataEye))
					{
						;
						Console.SetCursorPosition(35, 21);
						Console.Write("There is no such item in the list.");
						Console.ReadKey();
					}
					else
					{

						removeEyeCare(eyeCareData, eyeCares, ref enterDataEye);
						Console.SetCursorPosition(35, 21);
						Console.Write("The item has been removed!");
						Console.SetCursorPosition(35, 22);
						fileEyeCare(eyeCareData, enterDataEye);
						Console.Write("Press any key to continue...");
						Console.ReadKey();
					}
				}
				if (enterNumber == "8")
				{
					printHeader();

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the device you want to remove: ");
					medicalDevice = Console.ReadLine();
					if (!checkDevices(devicesData, medicalDevice, ref enterDataDevices))
					{
						;
						Console.SetCursorPosition(35, 21);
						Console.Write("There is no such device in the list.");
						Console.ReadKey();
					}
					else
					{

						removeDevices(devicesData, medicalDevice, ref enterDataDevices);
						Console.SetCursorPosition(35, 21);
						Console.Write("The item has been removed!");
						Console.SetCursorPosition(35, 22);
						fileMedicalDevices(devicesData, enterDataDevices);
						Console.Write("Press any key to continue...");
						Console.ReadKey();
					}
				}
				if (enterNumber == "9")
				{
					string option;
					printHeader();

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
					option = Console.ReadLine();
					if (option == "1")
					{
						printHeader();
						Console.SetCursorPosition(35, 20);
						if (discountCounterMedicines >= 100)
						{
							;
							Console.Write("You have applied discounts on maximum number of medicines");
							continue;
						}

						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the medicine on which you want to apply discount: ");
						medicine = Console.ReadLine();
						if (!checkMedicine(medicineData, medicine, ref enterDataMedicine))
						{
							printHeader();
							Console.SetCursorPosition(35, 21);
							Console.Write("There is no such medicine in the list.");
							Console.ReadKey();
						}
						else
						{
							printHeader();

							Console.SetCursorPosition(35, 21);
							Console.Write("Enter the discount rate: ");
							string text;
							text = Console.ReadLine();
							while (!checkInteger(text))
							{
								;
								Console.SetCursorPosition(35, 22);
								Console.Write("Enter a valid rate!");
								Console.ReadKey();
								printHeader();

								Console.SetCursorPosition(35, 21);
								Console.Write("Enter the discount rate: ");
								text = Console.ReadLine();
							}
							int discountRates = int.Parse(text);
							Console.SetCursorPosition(35, 23);

							Console.Write("Price after discount: " + discountMedicines(medicineData, medicine,discountRates, discountMedicinesData, ref enterDataMedicine, ref discountCounterMedicines, ref ia));
							Console.SetCursorPosition(35, 24);

							Console.Write("Press any key to continue: ");
							Console.ReadKey();
							discountMedicinesFile(discountMedicinesData, discountCounterMedicines);
							discountCounterMedicines++;
						}
					}
					if (option == "2")
					{
						printHeader();
						Console.SetCursorPosition(170, 21);
						if (discountCounterSkinCare >= 100)
						{
							Console.Write("You have applied discounts on maximum number of skin care products");
							continue;
						}

						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the skin care product on which you want to apply discount: ");
						skinCares = Console.ReadLine();
						if (!checkSkinCare(skinCareData, skinCares, ref enterDataSkin))
						{
							printHeader();
							Console.SetCursorPosition(35, 21);
							Console.Write("There is no such skin care product in the list.");
							Console.ReadKey();
						}
						else
						{
							printHeader();

							Console.SetCursorPosition(35, 21);
							Console.Write("Enter the discount rate: ");
							string text;
							text = Console.ReadLine();
							while (!checkInteger(text))
							{
								;
								Console.SetCursorPosition(35, 22);
								Console.Write("Enter a valid rate!");
								Console.ReadKey();
								printHeader();

								Console.SetCursorPosition(35, 21);
								Console.Write("Enter the discount rate: ");
								text = Console.ReadLine();
							}
							int discountRates = int.Parse(text);
							Console.SetCursorPosition(35, 23);

							Console.Write("Price after discount: " + discountSkinCare(skinCareData, skinCares, discountRates, discountSkinCareData, ref enterDataSkin, ref discountCounterSkinCare, ref ja));
							Console.SetCursorPosition(35, 24);

							Console.Write("Press any key to continue: ");
							Console.ReadKey();
							discountSkinCareFile(discountSkinCareData, discountCounterSkinCare);
							discountCounterSkinCare++;
						}
					}
					if (option == "3")
					{
						printHeader();
						Console.SetCursorPosition(170, 21);
						if (discountCounterEyeCare >= 100)
						{
							;
							Console.Write("You have applied discounts on maximum number of eye care products");
							continue;
						}
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the eye care product on which you want to apply discount: ");
						eyeCares = Console.ReadLine();
						if (!checkEyeCare(eyeCareData, eyeCares, ref enterDataEye))
						{
							printHeader();
							Console.SetCursorPosition(35, 21);
							Console.Write("There is no such eye care product in the list.");

							Console.ReadKey();
						}
						else
						{
							printHeader();

							Console.SetCursorPosition(35, 21);
							Console.Write("Enter the discount rate: ");
							string text;
							text = Console.ReadLine();
							while (!checkInteger(text))
							{
								;
								Console.SetCursorPosition(35, 22);
								Console.Write("Enter a valid rate!");
								Console.ReadKey();
								printHeader();

								Console.SetCursorPosition(35, 21);
								Console.Write("Enter the discount rate: ");
								text = Console.ReadLine();
							}
							int discountRates = int.Parse(text);
							Console.SetCursorPosition(35, 22);
							Console.Write("Price after discount: " + discountEyeCare(eyeCareData, eyeCares, discountRates,discountEyeCareData, ref enterDataEye, ref discountCounterEyeCare, ref ka));
							Console.SetCursorPosition(35, 23);

							Console.Write("Press any key to continue: ");
							Console.ReadKey();
							discountEyeCareFile(discountEyeCareData, discountCounterEyeCare);
							discountCounterEyeCare++;
						}
					}
					if (option == "4")
					{
						printHeader();
						Console.SetCursorPosition(170, 21);
						if (discountCounterDevices >= 100)
						{
							Console.Write("You have applied discounts on maximum number medical devices");
							continue;
						}

						Console.SetCursorPosition(35, 21);
						Console.Write("Enter the device on which you want to apply discount: ");
						medicalDevice = Console.ReadLine();
						if (!checkDevices(devicesData, medicalDevice, ref enterDataDevices))
						{
							printHeader();
							Console.SetCursorPosition(35, 21);
							Console.Write("There is no such device in the list.");
							Console.ReadKey();
						}
						else
						{
							printHeader();

							Console.SetCursorPosition(35, 21);
							Console.Write("Enter the discount rate: ");
							string text;
							text = Console.ReadLine();
							while (!checkInteger(text))
							{
								;
								Console.SetCursorPosition(35, 22);
								Console.Write("Enter a valid rate!");
								Console.ReadKey();
								printHeader();
								Console.SetCursorPosition(35, 21);
								Console.Write("Enter the discount rate: ");
								text = Console.ReadLine();
							}
							int discountRates = int.Parse(text);
							Console.SetCursorPosition(35, 22);
							Console.Write("Price after discount: " + discountDevices(devicesData, medicalDevice, discountRates,discountDevicesData, ref enterDataDevices, ref discountCounterDevices, ref la));
							Console.SetCursorPosition(35, 23);
							Console.Write("Press any key to continue: ");
							Console.ReadKey();
							discountDevicesFile(discountDevicesData, discountCounterDevices);
							discountCounterDevices++;
						}
					}
					if (option != "1" && option != "2" && option != "3" && option != "4")
					{
						continue;
					}
				}
				if (enterNumber == "10")
				{
					printHeader();
					viewCustomers(userData, ref signUpCounter);
					Console.ReadKey();
				}
				if (enterNumber == "11")
				{
					printHeader();

					string option;
					Console.SetCursorPosition(35, 20);
					Console.Write("On which category you want search: ");
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
					option = Console.ReadLine();
					if (option == "1")
					{
						printHeader();

						Console.SetCursorPosition(170, 21);
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the medicine you want to search: ");

						medicine = Console.ReadLine();
						Console.SetCursorPosition(35, 22);
						;
						if (checkMedicine(medicineData, medicine, ref enterDataMedicine))
							Console.Write("The medicine is present in the list");
						else
							Console.Write("There is no such medicine in the list!");
						Console.ReadKey();
					}
					if (option == "2")
					{
						printHeader();

						Console.SetCursorPosition(170, 21);
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the skin care product you want to search: ");

						skinCares = Console.ReadLine();
						Console.SetCursorPosition(35, 22);
						;
						if (checkSkinCare(skinCareData, skinCares, ref enterDataSkin))
							Console.Write("The product is present in the list");
						else
							Console.Write("There is no such product in the list!");
						Console.ReadKey();
					}
					if (option == "3")
					{
						printHeader();

						Console.SetCursorPosition(170, 21);
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the eye care product you want to search: ");

						eyeCares = Console.ReadLine();
						Console.SetCursorPosition(35, 22);
						;
						if (checkEyeCare(eyeCareData, eyeCares, ref enterDataEye))
							Console.Write("The product is present in the list");
						else
							Console.Write("There is no such product in the list!");
						Console.ReadKey();
					}
					if (option == "4")
					{
						printHeader();

						Console.SetCursorPosition(170, 21);
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the device you want to search: ");

						medicalDevice = Console.ReadLine();
						Console.SetCursorPosition(35, 22);
						;
						if (checkDevices(devicesData, medicalDevice, ref enterDataDevices))
							Console.Write("The device is present in the list");
						else
							Console.Write("There is no such medicine in the list!");
						Console.ReadKey();
					}
					if (option != "1" && option != "2" && option != "3" && option != "4")
					{
						continue;
					}
				}
				if (enterNumber == "12")
				{
					printHeader();
					viewData(discountMedicinesData, discountSkinCareData, discountEyeCareData, discountDevicesData,medicineData, skinCareData, eyeCareData, devicesData, ref enterDataMedicine, ref enterDataDevices, ref enterDataSkin, ref enterDataEye);
					Console.ReadKey();
				}
				if (enterNumber == "13")
				{
					string option;
					printHeader();

					Console.SetCursorPosition(35, 20);
					Console.Write("On which category you want to update price: ");
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
					option = Console.ReadLine();
					if (option == "1")
					{
						printHeader();
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the medicine of which you want to change price: ");
						medicine = Console.ReadLine();
						if (!checkMedicine(medicineData, medicine, ref enterDataMedicine))
						{
							;
							printHeader();
							Console.SetCursorPosition(35, 21);
							Console.Write("There is no such medicine in the list.");
							Console.ReadKey();
						}
						else
						{
							printHeader();
							updatePricesMedicine(medicine, medicineData);
							for (int i = 0; i < discountCounterMedicines; i++)
							{
								if (medicine == discountMedicinesData[i].discountMedicines)
								{
									discountMedicinesData[i].discountMedicines = "";
									discountCounterMedicines--;
									ia--;
								}
							}
							fileMedicines(medicineData, enterDataMedicine);
						}
					}
					if (option == "2")
					{
						printHeader();

						Console.SetCursorPosition(170, 21);
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the skin care of which you want to change price: ");
						skinCares = Console.ReadLine();
						if (!checkSkinCare(skinCareData, skinCares, ref enterDataSkin))
						{
							;
							printHeader();
							Console.SetCursorPosition(35, 21);
							Console.Write("There is no such product in the list.");
							Console.ReadKey();
						}
						else
						{
							printHeader();
							updatePricesSkin(skinCares, skinCareData);
							for (int i = 0; i < discountCounterSkinCare; i++)
							{
								if (skinCares == discountSkinCareData[i].discountSkinCare)
								{
									discountSkinCareData[i].discountSkinCare = "";
									discountCounterSkinCare--;
									ja--;
								}
							}
							fileSkinCare(skinCareData, enterDataSkin);
						}
					}
					if (option == "3")
					{
						printHeader();

						Console.SetCursorPosition(170, 21);
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the eye care product of which you want to change price: ");
						eyeCares = Console.ReadLine();
						if (!checkEyeCare(eyeCareData, eyeCares, ref enterDataEye))
						{
							;
							printHeader();
							Console.SetCursorPosition(35, 21);
							Console.Write("There is no such product in the list.");
							Console.ReadKey();
						}
						else
						{
							printHeader();
							updatePricesEyeCare(eyeCares, eyeCareData);
							for (int i = 0; i < discountCounterEyeCare; i++)
							{
								if (eyeCares == discountEyeCareData[i].discountEyeCare)
								{
									discountEyeCareData[i].discountEyeCare = "";
									discountCounterEyeCare--;
									ka--;
								}
							}
							fileEyeCare(eyeCareData, enterDataEye);
						}
					}
					if (option == "4")
					{
						printHeader();

						Console.SetCursorPosition(170, 21);
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the medical device of which you want to change price: ");
						medicalDevice = Console.ReadLine();
						if (!checkDevices(devicesData, medicalDevice, ref enterDataDevices))
						{
							;
							printHeader();
							Console.SetCursorPosition(35, 21);
							Console.Write("There is no such device in the list.");
							Console.ReadKey();
						}
						else
						{
							printHeader();
							updatePricesDevices(medicalDevice, devicesData);
							for (int i = 0; i < discountCounterDevices; i++)
							{
								if (medicalDevice == discountDevicesData[i].discountDevices)
								{
									discountDevicesData[i].discountDevices = "";
									discountCounterDevices--;
									la--;
								}
							}
							fileMedicalDevices(devicesData, enterDataDevices);
						}
					}
					if (option != "1" && option != "2" && option != "3" && option != "4")
					{
						continue;
					}
				}
				if (enterNumber == "14")
				{
					printHeader();
					viewFeedback(Feedback, feedbackCounter);
					Console.ReadKey();
				}
				if (enterNumber == "15")
				{
					return 0;
				}
				if (enterNumber != "1" && enterNumber != "2" && enterNumber != "3" && enterNumber != "4" && enterNumber != "5" && enterNumber != "6" && enterNumber != "7" && enterNumber != "8" && enterNumber != "9" && enterNumber != "10" && enterNumber != "11" && enterNumber != "12" && enterNumber != "13" && enterNumber != "14" && enterNumber != "15")
				{
					Console.SetCursorPosition(35, 33);
					Console.Write("Invalid choice!");
					Console.ReadKey();
				}
			}
		}
		static bool checkInteger(string text)
		{
			for (int i = 0; i < text.Length; i++)
			{
				if (!char.IsDigit(text[i]))
					return false;
			}
			return true;
		}

		static void feedback(string[] Feedback, ref int feedbackCounter)
		{

			Console.SetCursorPosition(35, 21);
			Console.Write("Must write letter h and then the feedback after that letter");
			Feedback[feedbackCounter] = Console.ReadLine();
			feedbackFile(Feedback[feedbackCounter]);
			feedbackCounter++;
		}

		static bool checkMedicine(medicineClass[] medicineData, string medicine, ref int enterDataMedicine)
		{
			for (int i = 0; i < enterDataMedicine; i++)
			{
				if (medicine == medicineData[i].medicines)
				{
					return true;
				}
			}
			return false;
		}

		static bool checkEyeCare(eyeCareClass[] eyeCareData, string eyeCares, ref int enterDataEye)
		{
			for (int i = 0; i < enterDataEye; i++)
			{
				if (eyeCares == eyeCareData[i].eyeCare)
				{
					return true;
				}
			}
			return false;
		}

		static bool checkSkinCare(skinCareClass[] skinCareData, string skinCares, ref int enterDataSkin)
		{
			for (int i = 0; i < enterDataSkin; i++)
			{
				if (skinCares == skinCareData[i].skinCare)
				{
					return true;
				}
			}
			return false;
		}

		static bool checkDevices(devicesClass[] devicesData, string medicalDevice, ref int enterDataDevices)
		{
			for (int i = 0; i < enterDataDevices; i++)
			{
				if (medicalDevice == devicesData[i].medicalDevices)
				{
					return true;
				}
			}
			return false;
		}

		static void updatePricesMedicine(string medicine, medicineClass[] medicineData)
		{
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (medicine == medicineData[i].medicines)
					n = i;
			}
			Console.SetCursorPosition(35, 22);

			Console.Write("Enter the updated price for " + medicine + ": ");
			string text;

			text = Console.ReadLine();
			while (!checkInteger(text))
			{

				Console.SetCursorPosition(35, 23);
				Console.Write("Enter a valid price: ");
				Console.ReadKey();
				printHeader();

				Console.SetCursorPosition(35, 22);
				Console.Write("Enter the updated price for " + medicine + ": ");
				text = Console.ReadLine();
			}
			medicineData[n].medicineprice = int.Parse(text);
		}

		static void updatePricesSkin(string skinCares, skinCareClass[] skinCareData)
		{
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (skinCares == skinCareData[i].skinCare)
					n = i;
			}
			Console.SetCursorPosition(35, 22);

			Console.Write("Enter the updated price for " + skinCares + ": ");
			string text;

			text = Console.ReadLine();
			while (!checkInteger(text))
			{

				Console.SetCursorPosition(35, 23);
				Console.Write("Enter a valid price: ");
				Console.ReadKey();
				printHeader();
				Console.SetCursorPosition(35, 22);

				Console.Write("Enter the updated price for " + skinCares + ": ");
				text = Console.ReadLine();
			}
			skinCareData[n].skinCarePrice = int.Parse(text);
		}

		static void updatePricesEyeCare(string eyeCares, eyeCareClass[] eyeCareData)
		{
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (eyeCares == eyeCareData[i].eyeCare)
					n = i;
			}
			Console.SetCursorPosition(35, 22);

			Console.Write("Enter the updated price for " + eyeCares + ": ");
			string text;

			text = Console.ReadLine();
			while (!checkInteger(text))
			{

				Console.SetCursorPosition(35, 23);
				Console.Write("Enter a valid price: ");
				Console.ReadKey();
				printHeader();
				Console.SetCursorPosition(35, 22);

				Console.Write("Enter the updated price for " + eyeCares + ": ");
				text = Console.ReadLine();
			}
			eyeCareData[n].eyeCarePrice = int.Parse(text);
		}

		static void updatePricesDevices(string medicalDevice, devicesClass[] devicesData)
		{
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (medicalDevice == devicesData[i].medicalDevices)
					n = i;
			}
			Console.SetCursorPosition(35, 22);

			Console.Write("Enter the updated price for " + medicalDevice + ": ");
			string text;

			text = Console.ReadLine();
			while (!checkInteger(text))
			{

				Console.SetCursorPosition(35, 23);
				Console.Write("Enter a valid price: ");
				Console.ReadKey();
				printHeader();
				Console.SetCursorPosition(35, 22);

				Console.Write("Enter the updated price for " + medicalDevice + ": ");
				text = Console.ReadLine();
			}
		    devicesData[n].medicalDevicesPrice = int.Parse(text);
		}

		static void cancelOrder(string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice, int[] quantityMedicines, int[] quantitySkinCare, int[] quantityEyeCare, int[] quantityDevices, ref int orderCounterMedicines, ref int orderCounterSkin, ref int orderCounterEye, ref int orderCounterDevices)
		{
			for (int i = 0; i < orderCounterMedicines; i++)
			{
				orderMedicines[i] = "";
			}
			for (int i = 0; i < orderCounterSkin; i++)
			{
				orderSkinCares[i] = "";
			}
			for (int i = 0; i < orderCounterEye; i++)
			{
				orderEyeCares[i] = "";
			}
			for (int i = 0; i < orderCounterDevices; i++)
			{
				orderDevice[i] = "";
			}
			orderMedicinesFile(orderMedicines, quantityMedicines, orderCounterMedicines);
			orderSkinCareFile(orderSkinCares, quantitySkinCare, orderCounterSkin);
			orderEyeCareFile(orderEyeCares, quantityEyeCare, orderCounterEye);
			orderDevicesFile(orderDevice, quantityDevices, orderCounterDevices);
			orderCounterMedicines = 0;
			orderCounterSkin = 0;
			orderCounterEye = 0;
			orderCounterDevices = 0;
		}

		static int customer(medicineClass[] medicineData,skinCareClass[] skinCareData, eyeCareClass[] eyeCareData, devicesClass[] devicesData, ref int enterDataMedicine, ref int enterDataSkin, ref int enterDataEye, ref int enterDataDevices, ref int enterDataSnacks, string[] Feedback, ref int feedbackCounter, discountMedicineClass[] discountMedicinesData, discountSkinCareClass[] discountSkinCareData, discountEyeCareClass[] discountEyeCareData, discountDevicesClass[] discountDevicesData, ref int ia, ref int ja, ref int ka, ref int la, ref int discountCounterMedicines, ref int discountCounterSkinCare, ref int discountCounterEyeCare, ref int discountCounterDevices, string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice, int orderCounterMedicines, int orderCounterSkin, int orderCounterEye, int orderCounterDevices, ref int totalPrice, signIn[] userData, ref int signUpCounter, ref int customerCount, string[] salesRecord, ref int salesRecordCounter, ref bool paymentDone)
		{
			totalPrice = 0;
			string n;
			string[] placeOrders = new string[100];
			int[] quantityOrder = new int[100];
			int[] quantityMedicine = new int[100];
			int[] quantitySkinCare = new int[100];
			int[] quantityEyeCare = new int[100];
			int[] quantityDevices = new int[100];
			orderCounterMedicines = 0;
			orderCounterSkin = 0;
			orderCounterEye = 0;
			orderCounterDevices = 0;
			storeOrderMedicines(orderMedicines, quantityMedicine, ref orderCounterMedicines);
			storeOrderSkinCare(orderSkinCares,quantitySkinCare, ref orderCounterSkin);
			storeOrderEyeCare(orderEyeCares, quantityEyeCare, ref orderCounterEye);
			storeOrderDevices(orderDevice, quantityDevices, ref orderCounterDevices);
			while (true)
			{
				Console.Clear();
				printHeader();

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
				Console.Write("Select an option: ");
				n = Console.ReadLine();
				if (n == "1")
				{
					printHeader();
					if (orderCounterMedicines >= 100)
					{
						Console.Write("You have ordered maximum number of medicines");
						continue;
					}

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter name of the medicine: ");
					orderMedicines[orderCounterMedicines] = Console.ReadLine();
					if (!checkMedicine(medicineData, orderMedicines[orderCounterMedicines], ref enterDataMedicine))
					{
						Console.SetCursorPosition(35, 21);
						Console.Write("There is no such medicine in the list.");
						Console.ReadKey();
					}
					else
					{

						Console.SetCursorPosition(35, 22);
						Console.Write("Enter the quantity: ");
						quantityMedicine[orderCounterMedicines] = int.Parse(Console.ReadLine());
						orderMedicine(medicineData, orderMedicines[orderCounterMedicines], quantityMedicine[orderCounterMedicines], ref enterDataMedicine, ref totalPrice); ;
						orderCounterMedicines++;
						Console.SetCursorPosition(35, 21);
						Console.Write("Your order has been placed successfully!");
						Console.Write("Press any key to continue...");
						Console.ReadKey();
					}
				}
				if (n == "2")
				{
					printHeader();
					Console.SetCursorPosition(35, 20);
					if (orderCounterSkin >= 100)
					{
						Console.Write("You have ordered maximum number of skin care products");
						continue;
					}

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter name of the skin care product: ");
					orderSkinCares[orderCounterSkin] = Console.ReadLine();
					if (!checkSkinCare(skinCareData, orderSkinCares[orderCounterSkin], ref enterDataSkin))
					{

						Console.SetCursorPosition(35, 21);
						Console.Write("There is no such product in the list.");
						Console.ReadKey();
					}
					else
					{

						Console.SetCursorPosition(35, 22);
						Console.Write("Enter the quantity: ");
						quantitySkinCare[orderCounterSkin] = int.Parse(Console.ReadLine());
						orderSkinCare(skinCareData, orderSkinCares[orderCounterSkin], quantitySkinCare[orderCounterSkin],  ref enterDataSkin, ref totalPrice);
						orderCounterSkin++;
						Console.SetCursorPosition(35, 21);
						Console.Write("Your order has been placed successfully!");
						Console.Write("Press any key to continue...");
						Console.ReadKey();
						totalPriceFile(totalPrice);
					}
				}
				if (n == "3")
				{
					printHeader();

					Console.SetCursorPosition(35, 20);
					if (orderCounterEye >= 100)
					{
						Console.Write("You have ordered maximum number of eye care products");
						continue;
					}

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter name of the eye care product: ");
					orderEyeCares[orderCounterEye] = Console.ReadLine();
					if (!checkEyeCare(eyeCareData, orderEyeCares[orderCounterEye], ref enterDataEye))
					{

						Console.SetCursorPosition(35, 21);
						Console.Write("There is no such product in the list.");
						Console.ReadKey();
					}
					else
					{

						Console.SetCursorPosition(35, 22);
						Console.Write("Enter the quantity: ");
						quantityEyeCare[orderCounterEye] = int.Parse(Console.ReadLine());
						orderEyeCare(eyeCareData, orderEyeCares[orderCounterEye], quantityEyeCare[orderCounterEye], ref enterDataEye, ref totalPrice);
						orderCounterEye++;
						Console.SetCursorPosition(35, 21);

						Console.Write("Your order has been placed successfully!");
						Console.Write("Press any key to continue...");
						Console.ReadKey();
						totalPriceFile(totalPrice);
					}
				}
				if (n == "4")
				{
					printHeader();
					Console.SetCursorPosition(35, 20);
					if (orderCounterDevices >= 100)
					{
						Console.Write("You have ordered maximum number of medical devices");
						continue;
					}

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter name of the device: ");
					orderDevice[orderCounterDevices] = Console.ReadLine();
					if (!checkDevices(devicesData, orderDevice[orderCounterDevices], ref enterDataDevices))
					{

						Console.SetCursorPosition(35, 21);
						Console.Write("There is no such product in the list.");
						Console.ReadKey();
					}
					else
					{

						Console.SetCursorPosition(35, 22);
						Console.Write("Enter the quantity: ");
						quantityDevices[orderCounterDevices] = int.Parse(Console.ReadLine());
						orderDevices(devicesData, orderDevice[orderCounterDevices], quantityDevices[orderCounterDevices], ref enterDataDevices, ref totalPrice);
						orderCounterDevices++;
						Console.SetCursorPosition(35, 21);

						Console.Write("Your order has been placed successfully!");
						Console.SetCursorPosition(35, 23);
						Console.Write("Press any key to continue...");
						Console.ReadKey();
					}
				}
				if (n == "5")
				{
					string removeOrders;
					printHeader();

					Console.SetCursorPosition(35, 20);
					Console.Write("Which item would you like to remove from the order: ");
					removeOrders = Console.ReadLine();
					if (!checkOrder(removeOrders, orderMedicines, orderSkinCares, orderEyeCares, orderDevice))
					{

						Console.Clear();
						printHeader();
						Console.SetCursorPosition(35, 20);
						Console.Write("There is no such item in the list!");
						Console.ReadKey();
					}
					if (checkOrder(removeOrders, orderMedicines, orderSkinCares, orderEyeCares, orderDevice))
					{
						int x = 0;
						if (checkMedicine(medicineData, removeOrders, ref enterDataMedicine))
							x = medicineNumber(medicineData, removeOrders);
						if (checkSkinCare(skinCareData, removeOrders, ref enterDataSkin))
							x = skinCareNumber(skinCareData, removeOrders);
						if (checkEyeCare(eyeCareData, removeOrders, ref enterDataEye))
							x = eyeCareNumber(eyeCareData, removeOrders);
						if (checkDevices(devicesData, removeOrders, ref enterDataDevices))
							x = medicalDevicesNumber(devicesData, removeOrders);
						removeOrder(medicineData, skinCareData, eyeCareData, devicesData, quantityMedicine, quantitySkinCare, quantityEyeCare, quantityDevices, removeOrders, orderMedicines, orderSkinCares, orderEyeCares, orderDevice, ref totalPrice, x);
						orderMedicinesFile(orderMedicines, quantityMedicine, orderCounterMedicines);
						orderSkinCareFile(orderSkinCares, quantitySkinCare, orderCounterSkin);
						orderEyeCareFile(orderEyeCares, quantityEyeCare, orderCounterEye);
						orderDevicesFile(orderDevice, quantityDevices, orderCounterDevices);
					}
				}
				if (n == "6")
				{
					printHeader();
					orderStatus(medicineData, skinCareData, eyeCareData, devicesData, orderMedicines, orderSkinCares, orderEyeCares, orderDevice, ref orderCounterMedicines, ref orderCounterSkin, ref orderCounterEye, ref orderCounterDevices, quantityMedicine, quantitySkinCare, quantityEyeCare, quantityEyeCare, ref totalPrice);
					Console.ReadKey();
				}
				if (n == "7")
				{
					printHeader();
					viewData(discountMedicinesData, discountSkinCareData, discountEyeCareData, discountDevicesData, medicineData, skinCareData, eyeCareData, devicesData, ref enterDataMedicine, ref enterDataDevices, ref enterDataSkin, ref enterDataEye);
					Console.ReadKey();
				}
				if (n == "8")
				{
					printHeader();
					feedback(Feedback, ref feedbackCounter);
				}
				if (n == "9")
				{
					string cancelTheOrder;
					printHeader();
					Console.Write("Enter cancel to cancel your order: ");
					cancelTheOrder = Console.ReadLine();
					if (cancelTheOrder == "cancel")
					{
						cancelOrder(orderMedicines, orderSkinCares, orderEyeCares, orderDevice, quantityMedicine, quantitySkinCare, quantityEyeCare, quantityDevices, ref orderCounterMedicines, ref orderCounterSkin, ref orderCounterEye, ref orderCounterDevices);
						totalPrice = 0;
						Console.ReadKey();
					}
				}
				if (n == "10")
				{
					printHeader();
					payment(ref totalPrice, paymentDone);
				}
				if (n == "11")
				{
					printHeader();
					Console.SetCursorPosition(35, 20);

					Console.Write("Your order status will be erased if any other customer logs in");
					Console.SetCursorPosition(35, 22);
					Console.Write("Press any key to continue...");
					Console.ReadKey();
					for (int i = 0; i < orderCounterMedicines; i++)
					{
						orderMedicines[i] = "";
						quantityMedicine[i] = 0;
					}
					for (int i = 0; i < orderCounterSkin; i++)
					{
						orderSkinCares[i] = "";
						quantitySkinCare[i] = 0;
					}
					for (int i = 0; i < orderCounterEye; i++)
					{
						orderEyeCares[i] = "";
						quantityEyeCare[i] = 0;
					}
					for (int i = 0; i < orderCounterDevices; i++)
					{
						orderDevice[i] = "";
						quantityDevices[i] = 0;
					}
					orderCounterMedicines = 0;
					orderCounterSkin = 0;
					orderCounterEye = 0;
					orderCounterDevices = 0;
					return 0;
				}
				if (n != "1" && n != "2" && n != "3" && n != "4" && n != "5" && n != "6" && n != "7" && n != "8" && n != "9" && n != "10" && n != "11")
				{
					Console.SetCursorPosition(35, 35);

					Console.Write("Select a valid option!");
					Console.ReadKey();
					continue;
				}
			}
		}

		static void orderMedicine(medicineClass[] medicineData, string medicine, int quantity, ref int enterDataMedicine, ref int totalPrice)
		{
			int n = 0;
			for (int i = 0; i < enterDataMedicine; i++)
			{
				if (medicine == medicineData[i].medicines)
					n = i;
			}
			totalPrice += medicineData[n].medicineprice * quantity;
		}

		static void orderSkinCare(skinCareClass[] skinCareData, string skinCares, int quantity, ref int enterDataSkin, ref int totalPrice)
		{
			int n = 0;
			for (int i = 0; i < enterDataSkin; i++)
			{
				if (skinCares == skinCareData[i].skinCare)
					n = i;
			}
			totalPrice += skinCareData[n].skinCarePrice * quantity;
		}

		static void orderEyeCare(eyeCareClass[] eyeCareData, string eyeCares, int quantity, ref int enterDataEye, ref int totalPrice)
		{
			int n = 0;
			for (int i = 0; i < enterDataEye; i++)
			{
				if (eyeCares == eyeCareData[i].eyeCare)
					n = i;
			}
			totalPrice += eyeCareData[n].eyeCarePrice * quantity;
		}

		static void orderDevices(devicesClass[] devicesData, string medicalDevice, int quantity, ref int enterDataDevices, ref int totalPrice)
		{
			int n = 0;
			for (int i = 0; i < enterDataDevices; i++)
			{
				if (medicalDevice == devicesData[i].medicalDevices)
					n = i;
			}
			totalPrice += devicesData[n].medicalDevicesPrice * quantity;
		}

		static void cancelOrder(string[] placeOrders, int[] quantityOrder, ref int orderCounter, string cancelOrders)
		{
			if (cancelOrders == "cancel")
			{
				for (int i = 0; i < 100; i++)
				{
					placeOrders[i] = "";
					quantityOrder[i] = 0;
				}
			}
			else
			{

				Console.Write("You have not cancelled your order");
			}
		}

		static int discountMedicines(medicineClass[] medicineData, string medicine, int discountRates,discountMedicineClass[] discountMedicinesData, ref int enterDataMedicine, ref int discountCounterMedicines, ref int ia)
		{
			int n = 0;
			for (int s = 0; s < enterDataMedicine; s++)
			{
				if (medicine == medicineData[s].medicines)
				{
					n = s;
				}
			}
			medicineData[n].medicineprice = medicineData[n].medicineprice - (medicineData[n].medicineprice * discountRates / 100);
			discountMedicinesData[discountCounterMedicines].discountMedicines = medicine;
			discountMedicinesData[discountCounterMedicines].discountRate = discountRates;
			return medicineData[n].medicineprice;
		}

		static int discountSkinCare(skinCareClass[] skinCareData, string skinCares, int discountRates,discountSkinCareClass[] discountSkinCareData, ref int enterDataSkin, ref int discountedCounterSkinCare, ref int ja)
		{
			int n = 0;
			for (int s = 0; s < enterDataSkin; s++)
			{
				if (skinCares == skinCareData[s].skinCare)
				{
					n = s;
				}
			}
			skinCareData[n].skinCarePrice = skinCareData[n].skinCarePrice - (skinCareData[n].skinCarePrice * discountRates / 100);
			discountSkinCareData[discountedCounterSkinCare].discountSkinCare = skinCares;
			discountSkinCareData[discountedCounterSkinCare].discountRate = discountRates;
			return skinCareData[n].skinCarePrice;
		}

		static int discountEyeCare(eyeCareClass[] eyeCareData, string eyeCares, int discountRates,discountEyeCareClass[] discountEyeCareData, ref int enterDataEye, ref int discountCounterEyeCare, ref int ka)
		{
			int n = 0;
			for (int s = 0; s < enterDataEye; s++)
			{
				if (eyeCares == eyeCareData[s].eyeCare)
				{
					n = s;
				}
			}
			eyeCareData[n].eyeCarePrice = eyeCareData[n].eyeCarePrice - (eyeCareData[n].eyeCarePrice * discountRates / 100);
			discountEyeCareData[discountCounterEyeCare].discountEyeCare = eyeCares;
			discountEyeCareData[discountCounterEyeCare].discountRate = discountRates;
			return eyeCareData[n].eyeCarePrice;
		}

		static int discountDevices(devicesClass[] devicesData, string medicalDevice, int discountRates,discountDevicesClass[] discountDevicesData, ref int enterDataDevices, ref int discountedCounterDevices, ref int la)
		{
			int n = 0;
			for (int s = 0; s < enterDataDevices; s++)
			{
				if (medicalDevice == devicesData[s].medicalDevices)
				{
					n = s;
				}
			}
			devicesData[n].medicalDevicesPrice = devicesData[n].medicalDevicesPrice - (devicesData[n].medicalDevicesPrice * discountRates / 100);
			discountDevicesData[discountedCounterDevices].discountDevices = medicalDevice;
			discountDevicesData[discountedCounterDevices].discountRate = discountRates;
			la++;
			return devicesData[n].medicalDevicesPrice;
		}

		static string signUp(string name, string password,string role, signIn[] userData, ref int signUpCounter)
		{
			userData[signUpCounter] = signInInput(name, password, role);
			if (signUpCounter >= 500)
			{
				return "Maximum number of customers have signed up.";
			}
			for (int i = 0; i < signUpCounter; i++)
			{
				if (signUpCounter >= 1 && userData[signUpCounter] == userData[i])
				{
					userData[signUpCounter].name = "\0";
					userData[signUpCounter].password = "\0";
					return "Already registered!";
				}
			}
			if (signUpCounter == 0)
			{
				fileSignUp(userData, signUpCounter);
				signUpCounter++;
				return "You have been registered as an admin.";
			}
			fileSignUp(userData, signUpCounter);
			signUpCounter++;
			return "You have been registered successfully as a customer.";
		}

		static bool checkOrder(string removeOrders, string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice)
		{
			for (int i = 0; i < 100; i++)
			{
				if (removeOrders == orderMedicines[i])
				{
					return true;
				}
				if (removeOrders == orderSkinCares[i])
				{
					return true;
				}
				if (removeOrders == orderEyeCares[i])
				{
					return true;
				}
				if (removeOrders == orderDevice[i])
				{
					return true;
				}
			}
			return false;
		}

		static void removeOrder(medicineClass[] medicineData, skinCareClass[] skinCareData, eyeCareClass[] eyeCareData, devicesClass[] devicesData, int[] quantityMedicine, int[] quantitySkinCare, int[] quantityEyeCare, int[] quantityDevices, string removeOrders, string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice, ref int totalPrice, int n)
		{
			for (int i = 0; i < 100; i++)
			{
				if (removeOrders == orderMedicines[i])
				{
					orderMedicines[i] = "";
					totalPrice -= medicineData[n].medicineprice * quantityMedicine[i];
					break;
				}
				if (removeOrders == orderSkinCares[i])
				{
					orderSkinCares[i] = "";
					totalPrice -= skinCareData[n].skinCarePrice * quantitySkinCare[i];
					break;
				}
				if (removeOrders == orderEyeCares[i])
				{
					orderEyeCares[i] = "";
					totalPrice -= eyeCareData[n].eyeCarePrice * quantityEyeCare[i];
					break;
				}
				if (removeOrders == orderDevice[i])
				{
					orderDevice[i] = "";
					totalPrice -= devicesData[n].medicalDevicesPrice * quantityDevices[i];
					break;
				}
			}
		}
		static void viewData(discountMedicineClass[] discountMedicinesData, discountSkinCareClass[] discountSkinCareData, discountEyeCareClass[] discountEyeCareData, discountDevicesClass[] discountDevicesData,medicineClass[] medicineData, skinCareClass[] skinCareData, eyeCareClass[] eyeCareData, devicesClass[] devicesData,ref int enterDataMedicine, ref int enterDataDevices, ref int enterDataSkin, ref int enterDataEye)
		{
			int y = 20;
			Console.SetCursorPosition(20, 20);

			Console.Write("Medicine");
			Console.SetCursorPosition(60, 20);

			Console.Write("Discount Rate");
			Console.SetCursorPosition(100, 20);

			Console.Write("Price");
			for (int i = 0; i < enterDataMedicine; i++)
			{
				if (medicineData[i].medicines == "")
				{
					continue;
				}

				Console.SetCursorPosition(20, y + 1);
				Console.Write(medicineData[i].medicines);

				Console.SetCursorPosition(60, y + 1);
				Console.Write(discountMedicinesData[i].discountRate);

				Console.SetCursorPosition(100, y + 1);
				Console.Write(medicineData[i].medicineprice);
				y++;
			}
			Console.SetCursorPosition(10, y + 1);

			Console.Write("-----------------------------------------------------------------------------------------------------------------------------");
			Console.SetCursorPosition(20, y + 2);

			Console.Write("Skin Care Product");
			Console.SetCursorPosition(60, y + 2);

			Console.Write("Discount Rate");
			Console.SetCursorPosition(100, y + 2);
			y = y + 2;

			Console.Write("Price");
			for (int i = 0; i < enterDataSkin; i++)
			{
				if (skinCareData[i].skinCare == "")
				{
					continue;
				}

				Console.SetCursorPosition(20, y + 1);
				Console.Write(skinCareData[i].skinCare);

				Console.SetCursorPosition(60, y + 1);
				Console.Write(discountSkinCareData[i].discountRate);

				Console.SetCursorPosition(100, y + 1);
				Console.Write(skinCareData[i].skinCarePrice);
				y++;
			}
			Console.SetCursorPosition(10, y + 1);

			Console.Write("-----------------------------------------------------------------------------------------------------------------------------");
			Console.SetCursorPosition(20, y + 2);

			Console.Write("Eye Care Product");
			Console.SetCursorPosition(60, y + 2);

			Console.Write("Discount Rate");
			Console.SetCursorPosition(100, y + 2);
			y = y + 2;

			Console.Write("Price");
			for (int i = 0; i < enterDataEye; i++)
			{
				if (eyeCareData[i].eyeCare == "")
				{
					continue;
				}
				Console.SetCursorPosition(20, y + 1);
				Console.Write(eyeCareData[i].eyeCarePrice);
				Console.SetCursorPosition(60, y + 1);
				Console.Write(discountEyeCareData[i].discountRate);
				Console.SetCursorPosition(100, y + 1);
				Console.Write(eyeCareData[i].eyeCarePrice);
				y++;
			}
			Console.SetCursorPosition(10, y + 1);

			Console.Write("-----------------------------------------------------------------------------------------------------------------------------");
			Console.SetCursorPosition(20, y + 2);

			Console.Write("Devices");
			Console.SetCursorPosition(60, y + 2);

			Console.Write("Discount Rate");
			Console.SetCursorPosition(100, y + 2);
			y = y + 2;

			Console.Write("Price");
			for (int i = 0; i < enterDataDevices; i++)
			{
				if (devicesData[i].medicalDevices == "")
				{
					continue;
				}
				Console.SetCursorPosition(20, y + 1);

				Console.Write(devicesData[i].medicalDevices);

				Console.SetCursorPosition(60, y + 1);
				Console.Write(discountDevicesData[i].discountRate);
				Console.SetCursorPosition(100, y + 1);

				Console.Write(devicesData[i].medicalDevicesPrice);
				y++;
			}
		}

		static void viewCustomers(signIn[] userData, ref int signUpCounter)
		{
			int y = 20;
			Console.SetCursorPosition(20, 20);

			Console.Write("Serial Number");
			Console.SetCursorPosition(45, 20);
			Console.Write("Customers");
			for (int i = 2; i < signUpCounter; i++)
			{
				if (userData[signUpCounter].name == "")
				{
					continue;
				}
				Console.SetCursorPosition(45, y + 1);

				Console.Write(userData[signUpCounter].name);
				Console.SetCursorPosition(20, y + 1);

				Console.Write(i);
				y++;
			}
		}

		static void removeMedicine(medicineClass[] medicineData, string medicine, ref int enterDataMedicine)
		{
			int n = 0;
			for (int i = 0; i <= enterDataMedicine; i++)
			{
				if (medicine == medicineData[i].medicines)
				{
					n = i;
					break;
				}
			}
			medicineData[n].medicines = "";
			medicineData[n].medicineprice = 0;
		}

		static void removeSkinCare(skinCareClass[] skinCareData, string skinCares, ref int enterDataSkin)
		{
			int n = 0;
			for (int i = 0; i <= enterDataSkin; i++)
			{
				if (skinCares == skinCareData[i].skinCare)
				{
					n = i;
					break;
				}
			}
			skinCareData[n].skinCare = "";
			skinCareData[n].skinCarePrice = 0;
		}

		static void removeEyeCare(eyeCareClass[] eyeCareData, string eyeCares, ref int enterDataEye)
		{
			int n = 0;
			for (int i = 0; i <= enterDataEye; i++)
			{
				if (eyeCares == eyeCareData[i].eyeCare)
				{
					n = i;
					break;
				}
			}
			eyeCareData[n].eyeCare = "";
			eyeCareData[n].eyeCarePrice = 0;
		}

		static bool checkSpecialCharacters(string name)
		{
			for (int i = 0; i < name.Length; i++)
			{
				if (name[i] == ',' || name[i] == '#' || name[i] == '$' || name[i] == '%' || name[i] == '^' || name[i] == '&' || name[i] == '*' || name[i] == '(' || name[i] == ')' || name[i] == '{' || name[i] == '}' || name[i] == '<' || name[i] == '>' || name[i] == '?' || name[i] == '.' || name[i] == '/' || name[i] == '\\' || name[i] == ':' || name[i] == ';' || name[i] == '[' || name[i] == ']' || name[i] == '-' || name[i] == '_' || name[i] == '+' || name[i] == '-' || name[i] == '|' || name[i] == '=')
					return true;
			}
			return false;
		}

		static void removeDevices(devicesClass[] devicesData, string medicalDevice, ref int enterDataDevice)
		{
			int n = 0;
			for (int i = 0; i <= enterDataDevice; i++)
			{
				if (medicalDevice == devicesData[i].medicalDevices)
				{
					n = i;
					break;
				}
			}
			devicesData[n].medicalDevices = "";
			devicesData[n].medicalDevicesPrice = 0;
		}

		static void orderStatus(medicineClass[] medicineData, skinCareClass[] skinCareData, eyeCareClass[] eyeCareData, devicesClass[] devicesData, string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice, ref int orderCounterMedicines, ref int orderCounterSkin, ref int orderCounterEye, ref int orderCounterDevices, int[] quantityMedicine, int[] quantitySkinCare, int[] quantityEyeCare, int[] quantityDevices, ref int totalPrice)
		{
			int x = 20, y = 20;
			int n = 0;
			Console.SetCursorPosition(x, y);

			Console.Write("Medicines");
			Console.SetCursorPosition(x + 40, y);

			Console.Write("Quantity");
			Console.SetCursorPosition(x + 100, y);

			Console.Write("Price");
			for (int i = 0; i < 100; i++)
			{
				if (orderMedicines[i] == "")
				{
					continue;
				}
				Console.SetCursorPosition(x, y + 1);

				n = medicineNumber(medicineData, orderMedicines[i]);
				Console.Write(orderMedicines[i]);
				Console.SetCursorPosition(x + 40, y + 1);

				Console.Write(quantityMedicine[i]);
				Console.SetCursorPosition(x + 100, y + 1);

				Console.Write(medicineData[n].medicineprice);
				y++;
			}
			Console.SetCursorPosition(x, y + 1);

			Console.Write("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			x = 20;
			Console.SetCursorPosition(x, y + 2);

			Console.Write("Skin Care Products");
			Console.SetCursorPosition(x + 40, y + 2);

			Console.Write("Quantity: ");
			Console.SetCursorPosition(x + 100, y + 2);

			Console.Write("Price");
			y = y + 2;
			for (int i = 0; i < 100; i++)
			{
				if (orderSkinCares[i] == "")
				{
					continue;
				}
				Console.SetCursorPosition(x, y + 1);
				n = skinCareNumber(skinCareData, orderSkinCares[i]);

				Console.Write(orderSkinCares[i]);
				Console.SetCursorPosition(x + 40, y);

				Console.Write(quantitySkinCare[i]);
				Console.SetCursorPosition(x + 100, y + 1);

				Console.Write(skinCareData[n].skinCarePrice);
				y++;
			}
			Console.SetCursorPosition(x, y + 1);

			Console.Write("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			x = 20;

			Console.SetCursorPosition(x, y + 2);
			Console.Write("Eye Care Products");
			Console.SetCursorPosition(x + 40, y + 2);

			Console.Write("Quantity: ");
			Console.SetCursorPosition(x + 100, y + 2);

			Console.Write("Price");
			y += 2;
			for (int i = 0; i < 100; i++)
			{
				if (orderEyeCares[i] == "")
				{
					continue;
				}
				Console.SetCursorPosition(x, y + 1);

				Console.Write(orderEyeCares[i]);
				n = eyeCareNumber(eyeCareData, orderEyeCares[i]);
				Console.SetCursorPosition(x + 40, y);

				Console.Write(quantityEyeCare[i]);
				Console.SetCursorPosition(x + 100, y + 1);

				Console.Write(eyeCareData[n].eyeCarePrice);
				y++;
			}

			Console.SetCursorPosition(x, y + 1);
			Console.Write("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			x = 20;
			Console.SetCursorPosition(x, y + 2);

			Console.Write("Medical Devices");
			Console.SetCursorPosition(x + 40, y + 2);

			Console.Write("Quantity: ");

			Console.SetCursorPosition(x + 100, y + 2);
			Console.Write("Price");
			y += 2;
			for (int i = 0; i < 100; i++)
			{
				if (orderDevice[i] == "")
				{
					continue;
				}
				Console.SetCursorPosition(x, y + 1);

				Console.Write(orderDevice[i]);
				n = medicalDevicesNumber(devicesData, orderDevice[i]);
				Console.SetCursorPosition(x + 40, y);

				Console.Write(quantityDevices[i]);
				Console.SetCursorPosition(x + 80, y + 1);

				Console.Write(devicesData[n].medicalDevicesPrice);
				y++;
			}
			Console.SetCursorPosition(80, y + 3);
			totalPrice = calculateTotalPrice(medicineData, skinCareData, eyeCareData, devicesData, orderMedicines, quantityMedicine, orderSkinCares, quantitySkinCare, orderEyeCares, quantityEyeCare, orderDevice, quantityDevices);
			Console.Write("Total bill: " + totalPrice);
		}

		static int calculateTotalPrice(medicineClass[] medicineData, skinCareClass[] skinCareData, eyeCareClass[] eyeCareData, devicesClass[] devicesData, string[] orderMedicines, int[] quantityMedicine, string[] orderSkinCares, int[] quantitySkinCare, string[] orderEyeCare, int[] quantityEyeCare, string[] orderDevices, int[] quantityDevices)
		{
			int price = 0;
			for (int i = 0; orderMedicines[i] != ""; i++)
			{
				int n = medicineNumber(medicineData, orderMedicines[i]);
				price += quantityMedicine[i] * medicineData[n].medicineprice;
			}
			for (int i = 0; orderSkinCares[i] != ""; i++)
			{
				int n = skinCareNumber(skinCareData, orderSkinCares[i]);
				price += quantitySkinCare[i] * skinCareData[n].skinCarePrice;
			}
			for (int i = 0; orderEyeCare[i] != ""; i++)
			{
				int n = eyeCareNumber(eyeCareData, orderEyeCare[i]);
				price += quantityEyeCare[i] * eyeCareData[n].eyeCarePrice;
			}
			for (int i = 0; orderDevices[i] != ""; i++)
			{
				int n = medicalDevicesNumber(devicesData, orderDevices[i]);
				price += quantityDevices[i] * devicesData[n].medicalDevicesPrice;
			}
			return price;
		}

		static void viewFeedback(string[] Feedback, int feedbackCounter)
		{
			if (feedbackCounter == 0)
			{

				Console.SetCursorPosition(35, 20);
				Console.Write("No feedback has been given!");
			}
			else
			{
				for (int i = 0; i < feedbackCounter; i++)
				{

					Console.Write(Feedback[i]);
					Console.Write("\n");
					Console.Write("\n");
					Console.Write("--------------------------------------------------------------------------------------------------------------");
					Console.Write("\n");
				}
			}
		}

		static void viewDiscounts(medicineClass[] medicineData, skinCareClass[] skinCareData, eyeCareClass[] eyeCareData, devicesClass[] devicesData, string[] discountedMedicines, string[] discountedSkinCare, string[] discountedEyeCare, string[] discountedDevices, ref int discountCounterMedicines, ref int discountCounterSkinCare, ref int discountCounterEyeCare, ref int discountCounterDevices, int[] discountMedicine, int[] discountSkinCares, int[] discountEyeCares, int[] discountDevice, int[] medicineprice, int[] skinCarePrice, int[] eyeCareProductsPrice, int[] medicalDevicesPrice, ref int ia, int ja, ref int ka, ref int la, int[] discountPriceMedicines, int[] discountPriceSkinCare, int[] discountPriceEyeCare, int[] discountPriceMedicalDevice)
		{
			int x = 20, y = 20, n;
			Console.SetCursorPosition(x, y);

			Console.Write("Medicines");
			Console.SetCursorPosition(x + 40, y);

			Console.Write("Discount Rate");
			Console.SetCursorPosition(x + 80, y);

			Console.Write("Price after discount");
			for (int i = 0; i < discountCounterMedicines; i++)
			{
				if (discountedMedicines[i] == "")
				{
					continue;
				}

				Console.SetCursorPosition(x, y + 1);
				Console.Write(discountedMedicines[i]);
				Console.SetCursorPosition(x + 40, y + 1);

				Console.Write(discountMedicine[i]);
				Console.SetCursorPosition(x + 80, y + 1);
				n = medicineNumber(medicineData, discountedMedicines[i]);

				Console.Write(discountPriceMedicines[n]);
				y++;
			}
			Console.SetCursorPosition(x, y + 1);

			Console.Write("---------------------------------------------------------------------------------------------------------------------------");
			Console.SetCursorPosition(x, y + 2);

			Console.Write("Skin Care Product");
			Console.SetCursorPosition(x + 40, y + 2);

			Console.Write("Discount Rate");
			Console.SetCursorPosition(x + 80, y + 2);

			Console.Write("Price after discount");
			y = y + 2;
			for (int i = 0; i < discountCounterSkinCare; i++)
			{
				if (discountedSkinCare[i] == "")
				{
					continue;
				}

				Console.SetCursorPosition(x, y + 1);
				Console.Write(discountedSkinCare[i]);

				Console.SetCursorPosition(x + 40, y + 1);
				Console.Write(discountSkinCares[i]);
				Console.SetCursorPosition(x + 80, y + 1);
				n = skinCareNumber(skinCareData, discountedSkinCare[i]);

				Console.Write(discountPriceSkinCare[n]);
				y++;
			}
			Console.SetCursorPosition(x, y + 1);

			Console.Write("---------------------------------------------------------------------------------------------------------------------------");
			Console.SetCursorPosition(x, y + 2);

			Console.Write("Eye Care Product");
			Console.SetCursorPosition(x + 40, y + 2);

			Console.Write("Discount Rate");
			Console.SetCursorPosition(x + 80, y + 2);

			Console.Write("Price after discount");
			y = y + 2;
			for (int i = 0; i < discountCounterEyeCare; i++)
			{
				if (discountedEyeCare[i] == "")
				{
					continue;
				}

				Console.SetCursorPosition(x, y + 1);
				Console.Write(discountedEyeCare[i]);
				Console.SetCursorPosition(x + 40, y + 1);

				Console.Write(discountEyeCares[i]);
				Console.SetCursorPosition(x + 80, y + 1);
				n = eyeCareNumber(eyeCareData, discountedEyeCare[i]);

				Console.Write(discountPriceEyeCare[n]);
				y++;
			}

			Console.SetCursorPosition(x, y + 1);
			Console.Write("---------------------------------------------------------------------------------------------------------------------------");
			Console.SetCursorPosition(x, y + 2);

			Console.Write("Medical Device");
			Console.SetCursorPosition(x + 40, y + 2);

			Console.Write("Discount Rate");
			Console.SetCursorPosition(x + 80, y + 2);

			Console.Write("Price after discount");
			y = y + 2;
			for (int i = 0; i < discountCounterDevices; i++)
			{
				if (discountedDevices[i] == "")
				{
					continue;
				}

				Console.SetCursorPosition(x, y + 1);
				Console.Write(discountedDevices[i]);

				Console.SetCursorPosition(x + 40, y + 1);
				Console.Write(discountDevice[i]);
				Console.SetCursorPosition(x + 80, y + 1);
				n = medicalDevicesNumber(devicesData, discountedDevices[i]);

				Console.Write(discountPriceMedicalDevice[n]);
				y++;
			}
		}

		static void payment(ref int totalPrice, bool paymentDone)
		{
			string number;
			int price;
			Console.SetCursorPosition(35, 20);

			Console.Write("Enter the card number(3-digits): ");
			number = Console.ReadLine();
			while (number.Count() != 3 || (number[0] != '1' && number[0] != '2' && number[0] != '3' && number[0] != '4' && number[0] != '5' && number[00] != '6' && number[0] != '7' && number[0] != '8' && number[0] != '9' && number[0] != '0') || (number[1] != '1' && number[1] != '2' && number[1] != '3' && number[1] != '4' && number[1] != '5' && number[1] != '6' && number[1] != '7' && number[1] != '8' && number[1] != '9' && number[1] != '0') || (number[2] != '1' && number[2] != '2' && number[2] != '3' && number[2] != '4' && number[2] != '5' && number[2] != '6' && number[2] != '7' && number[2] != '8' && number[2] != '9' && number[2] != '0'))
			{
				Console.Clear();
				printHeader();

				Console.SetCursorPosition(35, 20);
				Console.Write("Enter a valid card number: ");
				number = Console.ReadLine();
			}
			Console.SetCursorPosition(35, 21);

			Console.Write("Enter the price: ");
			price = int.Parse(Console.ReadLine());
			while (!(price > totalPrice))
			{

				Console.SetCursorPosition(35, 22);
				Console.Write("Lesser than total price!");
				Console.ReadKey();
				Console.Clear();
				printHeader();
				Console.SetCursorPosition(35, 21);
				Console.Write("Enter the price: ");
				price = int.Parse(Console.ReadLine());
			}

			Console.SetCursorPosition(35, 23);
			Console.Write("Transaction successful");
			Console.SetCursorPosition(35, 24);
			Console.Write("Your Amount: Rs." + price);
			Console.SetCursorPosition(35, 25);
			Console.Write("Total bill: Rs." + totalPrice);
			Console.SetCursorPosition(35, 26);
			Console.Write("Returned amount: Rs." + (price - totalPrice));
			Console.ReadKey();
			paymentDone = true;
			paymentCheck(paymentDone);
		}

		static bool paymentCheck(bool paymentDone)
		{
			return paymentDone;
		}

		static void removeRepeatedMedicine(string medicine, medicineClass[] medicineData, ref int enterDataMedicine)
		{
			int count = 0;
			int n = 0;
			for (int i = 0; i <= enterDataMedicine; i++)
			{
				if (medicine == medicineData[i].medicines)
				{
					count++;
				}
				if (count == 2)
				{
					n = i;
					break;
				}
			}
			if (count == 2)
			{
				medicineData[n].medicines = "";
			}
		}

		static void removeRepeatedSkinCare(skinCareClass[] skinCareData, string skinCares, ref int enterDataSkin)
		{
			int count = 0;
			int n = 0;
			for (int i = 0; i <= enterDataSkin; i++)
			{
				if (skinCares == skinCareData[i].skinCare)
				{
					count++;
				}
				if (count == 2)
				{
					n = i;
					break;
				}
			}
			if (count == 2)
			{
				skinCareData[n].skinCare = "";
			}
		}

		static void removeRepeatedEyeCare(eyeCareClass[] eyeCareData, string eyeCares, ref int enterDataEye)
		{
			int count = 0;
			int n = 0;
			for (int i = 0; i <= enterDataEye; i++)
			{
				if (eyeCares == eyeCareData[i].eyeCare)
				{
					count++;
				}
				if (count == 2)
				{
					n = i;
					break;
				}
			}
			if (count == 2)
			{
				eyeCareData[n].eyeCare = "";
			}
		}

		static void removeRepeatedDevices(devicesClass[] devicesData, string medicalDevice, ref int enterDataDevices)
		{
			int count = 0;
			int n = 0;
			for (int i = 0; i <= enterDataDevices; i++)
			{
				if (medicalDevice == devicesData[i].medicalDevices)
				{
					count++;
				}
				if (count == 2)
				{
					n = i;
					break;
				}
			}
			if (count == 2)
			{
				devicesData[n].medicalDevices = "";
			}
		}

		static int medicineNumber(medicineClass[] medicineData, string medicine)
		{
			for (int i = 0; i < 100; i++)
			{
				if (medicine == medicineData[i].medicines)
					return i;
			}
			return 0;
		}

		static int skinCareNumber(skinCareClass[] skinCareData, string skinCares)
		{
			for (int i = 0; i < 100; i++)
			{
				if (skinCares == skinCareData[i].skinCare)
					return i;
			}
			return 0;
		}

		static int eyeCareNumber(eyeCareClass[] eyeCareData, string eyeCares)
		{
			for (int i = 0; i < 100; i++)
			{
				if (eyeCares == eyeCareData[i].eyeCare)
					return i;
			}
			return 0;
		}

		static int medicalDevicesNumber(devicesClass[] devicesData, string medicalDevice)
		{
			for (int i = 0; i < 100; i++)
			{
				if (medicalDevice == devicesData[i].medicalDevices)
					return i;
			}
			return 0;
		}

		static void fileSignUp(signIn[] userData, int signUpCounter)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\signUp.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i <= signUpCounter; i++)
				{
					file.WriteLine(userData[i].name + "," + userData[i].password + "," + userData[i].role);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static string nameOfCustomer(int signUpCounter)
		{
			string username = "";
			string path = "D:\\Programming Day\\Week5\\idk\\signUp.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= signUpCounter; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						username = username + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return username;
		}

		static string passwordOfCustomer(int signUpCounter)
		{
			string password = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\signUp.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= signUpCounter; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if(commaCount == 1 && line[i] != ',')
					{
						password += line[i];
					}
					if (line[i] == ',') commaCount++;
				}
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return password;
		}

		static string roleCheck(int signUpCounter)
		{
			string role = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\signUp.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= signUpCounter; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && (commaCount == 0 || commaCount == 1))
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						role = role + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return role;

		}

		static void storeNamesAndPasswordOfCustomers(signIn[] userData, ref int signUpCounter)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\signUp.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				string line = "";
				while ((line = file.ReadLine()) != null)
				{
					if (line == "") break;
					string name = nameOfCustomer(signUpCounter);
					string password = passwordOfCustomer(signUpCounter);
					string role = roleCheck(signUpCounter);
					userData[signUpCounter] = signInInput(name, password, role);
					signUpCounter++;
				}
			}
			file.Close();
		}

		static void fileMedicines(medicineClass[] medicineData ,int enterDataMedicine)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\medicines.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < enterDataMedicine; i++)
				{
					file.WriteLine(medicineData[i].medicines + "," + medicineData[i].medicineprice);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void fileSkinCare(skinCareClass[] skinCareData, int enterDataSkin)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\skinCare.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < enterDataSkin; i++)
				{
					file.WriteLine(skinCareData[i].skinCare + "," + skinCareData[i].skinCarePrice);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void fileEyeCare(eyeCareClass[] eyeCareData, int enterDataEye)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\eyeCare.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < enterDataEye; i++)
				{
					file.WriteLine(eyeCareData[i].eyeCare + "," + eyeCareData[i].eyeCarePrice);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void fileMedicalDevices(devicesClass[] devicesData, int enterDataDevices)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\medicalDevices.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < enterDataDevices; i++)
				{
					file.WriteLine(devicesData[i].medicalDevices + "," + devicesData[i].medicalDevicesPrice);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static string parseMedicines(int enterDataMedicine)
		{
			string medicine = "";
			string path = "D:\\Programming Day\\Week5\\idk\\medicines.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= enterDataMedicine; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						medicine = medicine + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return medicine;
		}

		static int parseMedicineQuantity(int enterDataMedicine)
		{
			string quantity = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\orderMedicines.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= enterDataMedicine; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{

						commaCount++;
					}
					if (line[i] != ',')
					{
						quantity = quantity + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			int intquantity = int.Parse(quantity);
			return intquantity;
		}

		static int parseMedicinePrice(int enterDataMedicine)
		{
			string quantity = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\medicines.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= enterDataMedicine; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						quantity = quantity + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			int intquantity = int.Parse(quantity);
			return intquantity;
		}

		static string parseSkinCare(int enterDataSkin)
		{
			string skinCare = "";
			string path = "D:\\Programming Day\\Week5\\idk\\skinCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= enterDataSkin; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						skinCare = skinCare + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return skinCare;
		}

		static int parseSkinCarePrice(int enterDataSkin)
		{
			string price = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\skinCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= enterDataSkin; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						price = price + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			int intprice = int.Parse(price);
			return intprice;
		}

		static string parseEyeCare(int enterDataEye)
		{
			string eyeCare = "";
			string path = "D:\\Programming Day\\Week5\\idk\\eyeCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= enterDataEye; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						eyeCare = eyeCare + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return eyeCare;
		}

		static int parsePriceEyeCare(int enterDataEye)
		{
			string price = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\eyeCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= enterDataEye; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						price = price + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			int intprice = int.Parse(price);
			return intprice;
		}

		static string parseDevices(int enterDataDevices)
		{
			string device = "";
			string path = "D:\\Programming Day\\Week5\\idk\\medicalDevices.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= enterDataDevices; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						device = device + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return device;
		}

		static int parseDevicePrice(int enterDataDevices)
		{
			string price = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\medicalDevices.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= enterDataDevices; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						price = price + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			if (price != "")
			{
				int intprice = int.Parse(price);
				return intprice;
			}
			return 0;
		}

		static void storeMedicines(medicineClass[] medicineData, ref int enterDataMedicine)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\medicines.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					string medicine = parseMedicines(enterDataMedicine);
					int price = parseMedicinePrice(enterDataMedicine);
					medicineData[enterDataMedicine] = medicinesInput(medicine, price);
					enterDataMedicine++;
				}
			}
		}

		static void storeSkinCare(skinCareClass[] skinCareData, ref int enterDataSkin)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\skinCare.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					if(line == "") break;
					string skinCares = parseSkinCare(enterDataSkin);
					int price = parseSkinCarePrice(enterDataSkin);
					skinCareData[enterDataSkin] = skinCareInput(skinCares, price);
					enterDataSkin++;
				}
			}
		}

		static void storeEyeCare(eyeCareClass[] eyeCareData, ref int enterDataEye)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\eyeCare.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					if (line == "") break;
					string eyeCares = parseEyeCare(enterDataEye);
					int price = parsePriceEyeCare(enterDataEye);
					eyeCareData[enterDataEye] = eyeCareInput(eyeCares, price);
					enterDataEye++;
				}
			}
		}

		static void storeDataDevices(devicesClass[] devicesData, ref int enterDataDevices)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\medicalDevices.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					if (line == "") break;
					devicesData[enterDataDevices].medicalDevices = parseDevices(enterDataDevices);
					devicesData[enterDataDevices].medicalDevicesPrice = parseDevicePrice(enterDataDevices);
					enterDataDevices++;
				}
			}
		}

		static void discountMedicinesFile(discountMedicineClass[] discountMedicinesData, int discountCounterMedicines)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicines.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < discountCounterMedicines; i++)
				{
					file.WriteLine(discountMedicinesData[i].discountMedicines + "," + discountMedicinesData[i].discountRate);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void discountSkinCareFile(discountSkinCareClass[] discountSkinCareData, int discountCounterSkinCare)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\discountSkinCare.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < discountCounterSkinCare; i++)
				{
					file.WriteLine(discountSkinCareData[i].discountSkinCare + "," + discountSkinCareData[i].discountRate);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void discountEyeCareFile(discountEyeCareClass[] discountEyeCareData, int discountCounterEyeCare)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\discountEyeCare.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < discountCounterEyeCare; i++)
				{
					file.WriteLine(discountEyeCareData[i].discountEyeCare + "," + discountEyeCareData[i].discountRate);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void discountDevicesFile(discountDevicesClass[] discountDevicesData, int discountCounterDevices)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicalDevices.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i <= discountCounterDevices; i++)
				{
					file.WriteLine(discountDevicesData[i].discountDevices + "," + discountDevicesData[i].discountRate);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static string parseDiscountMedicine(int discountCounterMedicines)
		{
			string medicine = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicines.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= discountCounterMedicines; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						medicine = medicine + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return medicine;
		}

		static int parseDiscountMedicinesRate(int discountCounterMedicines)
		{
			string price = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicines.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= discountCounterMedicines; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						price = price + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			if (price != "")
			{
				int intprice = int.Parse(price);
				return intprice;
			}
			return 0;
		}

		static string parseDiscountSkinCare(int discountCounterSkinCare)
		{
			string skinCare = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountSkinCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= discountCounterSkinCare; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						skinCare = skinCare + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return skinCare;
		}

		static int parseDiscountSkinCareRate(int discountCounterSkinCare)
		{
			string price = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\discountSkinCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= discountCounterSkinCare; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						price = price + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			if (price != "")
			{
				int intprice = int.Parse(price);
				return intprice;
			}
			return 0;
		}

		static string parseDiscountEyeCare(int discountCounterEyeCare)
		{
			string eyeCare = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountEyeCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= discountCounterEyeCare; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						eyeCare = eyeCare + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return eyeCare;
		}

		static int parseDiscountEyeCareRate(int discountCounterEyeCare)
		{
			string price = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\discountEyeCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= discountCounterEyeCare; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						price = price + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			if (price != "")
			{
				int intprice = int.Parse(price);
				return intprice;
			}
			return 0;
		}

		static string parseDiscountDevices(int discountCounterDevices)
		{
			string device = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicalDevices.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= discountCounterDevices; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						device = device + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return device;
		}

		static int parseDiscountDevicesRate(int discountCounterDevices)
		{
			string price = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicalDevices.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= discountCounterDevices; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						price = price + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			if (price != "")
			{
				int intprice = int.Parse(price);
				return intprice;
			}
			return 0;
		}

		static void storeDiscountMedicines(discountMedicineClass[] discountMedicinesData, ref int discountCounterMedicines)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicines.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					discountMedicinesData[discountCounterMedicines].discountMedicines = parseDiscountMedicine(discountCounterMedicines);
					discountMedicinesData[discountCounterMedicines].discountRate = parseDiscountMedicinesRate(discountCounterMedicines);
					discountCounterMedicines++;
				}
			}
			file.Close();
		}

		static void storeDiscountedSkinCare(discountSkinCareClass[] discountSkinCareData, ref int discountCounterSkinCare)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountSkinCare.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					discountSkinCareData[discountCounterSkinCare].discountSkinCare = parseDiscountSkinCare(discountCounterSkinCare);
					discountSkinCareData[discountCounterSkinCare].discountRate = parseDiscountSkinCareRate(discountCounterSkinCare);
					discountCounterSkinCare++;
				}
			}
			file.Close();
		}

		static void storeDiscountedEyeCare(discountEyeCareClass[] discountEyeCareData, ref int discountCounterEyeCare)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountEyeCare.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					discountEyeCareData[discountCounterEyeCare].discountEyeCare = parseDiscountEyeCare(discountCounterEyeCare);
					discountEyeCareData[discountCounterEyeCare].discountRate = parseDiscountEyeCareRate(discountCounterEyeCare);
					discountCounterEyeCare++;
				}
			}
			file.Close();
		}

		static void storeDiscountedDevices(discountDevicesClass[] discountDevicesData, ref int discountCounterDevices)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicalDevices.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					discountDevicesData[discountCounterDevices].discountDevices = parseDiscountDevices(discountCounterDevices);
					discountDevicesData[discountCounterDevices].discountRate = parseDiscountDevicesRate(discountCounterDevices);
					discountCounterDevices++;
				}
			}
			file.Close();
		}

		static void orderMedicinesFile(string[] orderMedicines, int[] quantityMedicine, int orderCounterMedicines)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\orderMedicines.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i <= orderCounterMedicines; i++)
				{
					file.WriteLine(orderMedicines[i] + "," + quantityMedicine[i]);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void orderSkinCareFile(string[] orderSkinCares, int[] quantitySkinCare, int orderCounterSkin)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\orderSkinCare.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i <= orderCounterSkin; i++)
				{
					file.WriteLine(orderSkinCares[i] + "," + quantitySkinCare[i]);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void orderEyeCareFile(string[] orderEyeCares, int[] quantityEyeCare, int orderCounterEye)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\orderEyeCare.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i <= orderCounterEye; i++)
				{
					file.WriteLine(orderEyeCares[i] + "," + quantityEyeCare[i]);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void orderDevicesFile(string[] orderDevice, int[] quantityDevices, int orderCounterDevices)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\orderDevices.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i <= orderCounterDevices; i++)
				{
					file.WriteLine(orderDevice[i] + "," + quantityDevices[i]);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static string parseOrderMedicine(int orderCounterMedicines)
		{
			string medicine = "";
			string path = "D:\\Programming Day\\Week5\\idk\\orderMedicines.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= orderCounterMedicines; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						medicine = medicine + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return medicine;
		}

		static int parseQuantityMedicine(int orderCounterMedicines)
		{
			string quantity = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\orderMedicines.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= orderCounterMedicines; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						quantity = quantity + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			if (quantity != "")
			{
				int intquantity = int.Parse(quantity);
				return intquantity;
			}
			return 0;
		}

		static string parseOrderSkinCare(int orderCounterSkin)
		{
			string skinCare = "";
			string path = "D:\\Programming Day\\Week5\\idk\\orderSkinCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= orderCounterSkin; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						skinCare = skinCare + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return skinCare;
		}

		static int parseQuantitySkin(int orderCounterSkin)
		{
			string quantity = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\orderSkinCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= orderCounterSkin; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						quantity = quantity + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			int intquantity = int.Parse(quantity);
			return intquantity;
		}

		static string parseOrderEyeCare(int orderCounterEye)
		{
			string eyeCare = "";
			string path = "D:\\Programming Day\\Week5\\idk\\orderEyeCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= orderCounterEye; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						eyeCare = eyeCare + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return eyeCare;
		}

		static int parseQuantityEye(int orderCounterEye)
		{
			string quantity = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\orderEyeCare.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= orderCounterEye; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						quantity = quantity + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			int intquantity = int.Parse(quantity);
			return intquantity;
		}

		static string parseOrderDevices(int orderCounterDevices)
		{
			string device = "";
			string path = "D:\\Programming Day\\Week5\\idk\\orderDevices.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= orderCounterDevices; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] == ',')
					{
						break;
					}
					else
					{
						device = device + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return device;
		}

		static int parseQuantityDevices(int orderCounterDevices)
		{
			string quantity = "";
			int commaCount = 0;
			string path = "D:\\Programming Day\\Week5\\idk\\orderDevices.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= orderCounterDevices; i++)
				{
					line = file.ReadLine();
				}
				for (int i = 0; i < line.Length; i++)
				{
					if (line[i] != ',' && commaCount == 0)
					{
						continue;
					}
					else
					{
						commaCount++;
					}
					if (line[i] != ',')
					{
						quantity = quantity + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			int intquantity = int.Parse(quantity);
			return intquantity;
		}

		static void storeOrderMedicines(string[] orderMedicies, int[] quantityMedicine, ref int orderCounterMedicines)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\orderMedicines.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					orderMedicies[orderCounterMedicines] = parseOrderMedicine(orderCounterMedicines);
					quantityMedicine[orderCounterMedicines] = parseMedicineQuantity(orderCounterMedicines);
					orderCounterMedicines++;
				}
			}
			file.Close();
		}

		static void storeOrderSkinCare(string[] orderSkinCares, int[] quantitySkinCare, ref int orderCounterSkin)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\orderSkinCare.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					orderSkinCares[orderCounterSkin] = parseOrderSkinCare(orderCounterSkin);
					quantitySkinCare[orderCounterSkin] = parseQuantitySkin(orderCounterSkin);
					orderCounterSkin++;
				}
			}
			file.Close();
		}

		static void storeOrderEyeCare(string[] orderEyeCares, int[] quantityEyeCare, ref int orderCounterEye)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\orderEyeCare.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					orderEyeCares[orderCounterEye] = parseOrderEyeCare(orderCounterEye);
					quantityEyeCare[orderCounterEye] = parseQuantityEye(orderCounterEye);
					orderCounterEye++;
				}
			}
			file.Close();
		}

		static void storeOrderDevices(string[] orderDevice, int[] quantityDevices, ref int orderCounterDevices)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\orderDevices.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					orderDevice[orderCounterDevices] = parseOrderDevices(orderCounterDevices);
					quantityDevices[orderCounterDevices] = parseQuantityDevices(orderCounterDevices);
					orderCounterDevices++;
				}
			}
			file.Close();
		}

		static void totalPriceFile(int totalPrice)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\price.txt";
			StreamWriter file = new StreamWriter(path, false);
			if (File.Exists(path))
			{
				file.WriteLine(totalPrice);
			}
			file.Close();
		}

		static void feedbackFile(string feedback)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\Feedback.txt";
			StreamWriter file = new StreamWriter(path, true);
			if (File.Exists(path))
			{
				file.WriteLine(feedback);
			}
		}

		static string parseFeedback(int feedbackCounter)
		{
			string feedback = "";
			string path = "D:\\Programming Day\\Week5\\idk\\Feedback.txt";
			if (File.Exists(path))
			{
				StreamReader file = new StreamReader(path);
				string line = "";
				for (int i = 0; i <= feedbackCounter; i++)
				{
					line = file.ReadLine();
					feedback = line;
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return feedback;
		}

		static void storeFeedback(string[] Feedback, ref int feedbackCounter)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\Feedback.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					line = file.ReadLine();
					Feedback[feedbackCounter] = line;
				}
			}
			file.Close();
		}
		static signIn signInInput(string names, string passwords, string role)
		{
			signIn userData = new signIn(names, passwords, role);
			return userData;
		}

		static medicineClass medicinesInput(string medicines, int price)
		{
			medicineClass medicine = new medicineClass(medicines, price);
			return medicine;
		}

		static skinCareClass skinCareInput(string skinCare,int price)
		{
			skinCareClass skinCares = new skinCareClass(skinCare, price);
			return skinCares;
		}

		static eyeCareClass eyeCareInput(string eyeCare, int price)
		{
			eyeCareClass eyeCares = new eyeCareClass(eyeCare, price);
			return eyeCares;
		}

		static devicesClass devicesInput(string device, int price)
		{
			devicesClass devices = new devicesClass(device, price);
			return devices;
		}

		static discountMedicineClass discountMedicinesInput(string medicine, int rate)
		{
			discountMedicineClass medicines = new discountMedicineClass(medicine, rate);
			return medicines;
		}

		static discountSkinCareClass discountSkinCareInput(string skinCare, int rate)
		{
			discountSkinCareClass skinCares = new discountSkinCareClass(skinCare, rate);
			return skinCares;
		}

		static discountEyeCareClass discountEyeCareInput(string eyeCare, int rate)
		{
			discountEyeCareClass eyeCares = new discountEyeCareClass(eyeCare, rate);
			return eyeCares;
		}

		static discountDevicesClass discountDevices(string devices, int rate)
		{
			discountDevicesClass device = new discountDevicesClass(devices, rate);
			return device;
		}




	}
}