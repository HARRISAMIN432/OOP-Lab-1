using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace CSBusinessApp
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
			string[] discountedMedicines = new string[100];
			string[] discountedSkinCare = new string[100];
			string[] discountedEyeCare = new string[100];
			string[] discountedDevices = new string[100];
			int discountCounterMedicines = 0, discountCounterSkinCare = 0, discountCounterEyeCare = 0, discountCounterDevices = 0;
			int[] discountMedicine = new int[100];
			int[] discountSkinCares = new int[100];
			int[] discountEyeCares = new int[100];
			int[] discountDevice = new int[100];
			int[] discountPriceMedicines = new int[100];
			int[] discountPriceSkinCare = new int[100];
			int[] discountPriceEyeCare = new int[100];
			int[] discountPriceMedicalDevices = new int[100];
			int feedbackCounter = 0, ia = 0, ja = 0, ka = 0, la = 0;
			string[] Feedback = new string[100];
			string[] medicines = new string[100];
			string[] skinCare = new string[100];
			string[] medicalDevices = new string[100];
			string[] eyeCare = new string[100];
			int[] medicineprice = new int[100];
			int[] skinCarePrice = new int[100];
			int[] medicalDevicesPrice = new int[100];
			int[] eyeCareProductsPrice = new int[100];
			int signUpCounter = 0, enterDataMedicine = 0, enterDataSkin = 0, enterDataEye = 0, enterDataDevices = 0, enterDataSnacks = 0;
			string[] uNames = new string[500];
			string[] uPass = new string[500];
			string[] uRole = new string[500];
			string username, password, yourChoice;
			storeNamesAndPasswordOfCustomers(ref uNames,ref uPass,ref signUpCounter);
			storeMedicines(medicines, medicineprice, ref enterDataMedicine);
			storeSkinCare(skinCare, skinCarePrice,ref enterDataSkin);
			storeEyeCare(eyeCare, eyeCareProductsPrice, ref enterDataEye);
			storeDataDevices(medicalDevices, medicalDevicesPrice, ref enterDataDevices);
			storeDiscountMedicines(discountedMedicines, discountMedicine, ref discountCounterMedicines);
			storeDiscountedSkinCare(discountedSkinCare, discountSkinCares, ref discountCounterSkinCare);
			storeDiscountedEyeCare(discountedEyeCare, discountEyeCares, ref discountCounterEyeCare);
			storeDiscountedDevices(discountedDevices, discountDevice, ref discountCounterDevices);
			for (int i = 0; i < 100; i++)
			{
				discountMedicine[i] = 0;
				discountSkinCares[i] = 0;
				discountEyeCares[i] = 0;
				discountDevice[i] = 0;
			}
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
					customerCount = checkCustomerCount(uNames, username, uPass, signUpCounter);
					for (int i = 0; i <= signUpCounter; i++)
					{
						if (signIn(username, password, uNames, uPass, signUpCounter))
						{
							if (username == uNames[i])
							{
								if (i == 0)
								{
									manager(uNames, ref signUpCounter, medicines, skinCare, eyeCare, medicalDevices, medicineprice, skinCarePrice, medicalDevicesPrice, eyeCareProductsPrice, ref enterDataMedicine, ref enterDataSkin, ref enterDataEye, ref enterDataDevices, ref enterDataSnacks, Feedback, ref feedbackCounter, discountMedicine, discountSkinCares, discountEyeCares, discountDevice, ref ia, ref ja, ref ka, ref la, discountedMedicines, discountedSkinCare, discountedEyeCare, discountedDevices, ref discountCounterMedicines, ref discountCounterSkinCare, ref discountCounterEyeCare, ref discountCounterDevices, discountPriceMedicines, discountPriceSkinCare, discountPriceEyeCare, discountPriceMedicalDevices, orderMedicines, orderSkinCares, orderEyeCares, orderDevice, orderCounterMedicines, orderCounterSkin, orderCounterEye, orderCounterDevices, ref totalPrice, uPass, salesRecord, ref salesRecordCounter);
									break;
								}
								if (i > 0)
								{
									customer(medicines, skinCare, eyeCare, medicalDevices, medicineprice, skinCarePrice, medicalDevicesPrice, eyeCareProductsPrice, ref enterDataMedicine, ref enterDataSkin, ref enterDataEye, ref enterDataDevices, ref enterDataSnacks, Feedback, ref feedbackCounter, discountMedicine, discountSkinCares, discountEyeCares, discountDevice, ref ia, ref ja, ref ka, ref la, discountedMedicines, discountedSkinCare, discountedEyeCare, discountedDevices, ref discountCounterMedicines, ref discountCounterSkinCare, ref discountCounterEyeCare, ref discountCounterDevices, discountPriceMedicines, discountPriceSkinCare, discountPriceEyeCare, discountPriceMedicalDevices, orderMedicines, orderSkinCares, orderEyeCares, orderDevice, orderCounterMedicines, orderCounterSkin, orderCounterEye, orderCounterDevices, ref totalPrice, uNames, uPass, ref signUpCounter, ref customerCount, salesRecord, ref salesRecordCounter, ref paymentDone);
									break;
								}
							}
						}
					}
					if (!signIn(username, password, uNames, uPass, signUpCounter))
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
					uNames[signUpCounter] = Console.ReadLine();
					name = uNames[signUpCounter];
					while (checkSpecialCharacters(name) || name.Count() < 5)
					{
						Console.SetCursorPosition(35, 22);

						Console.Write("username cannot contain special characters and cannot be 5 characters short.");
						Console.ReadKey();
						printHeader();
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the user name: ");
						uNames[signUpCounter] = Console.ReadLine();
						name = uNames[signUpCounter];
					}
					Console.SetCursorPosition(35, 22);
					Console.Write("Enter the password: ");
					Console.SetCursorPosition(35, 23);
					Console.Write("Password must be 8 characters long: ");
					uPass[signUpCounter] = Console.ReadLine();
					while (uPass[signUpCounter].Count() < 8)
					{
						Console.Clear();
						printHeader();
						Console.SetCursorPosition(35, 20);
						Console.Write("Password not valid!");
						Console.ReadKey();
						Console.SetCursorPosition(35, 22);
						Console.Write("Re-enter your password: ");
						uPass[signUpCounter] = Console.ReadLine();
					}
					string signUP;
					Console.SetCursorPosition(35, 29);
					signUP = signUp(ref uNames,ref uPass, uRole, ref signUpCounter);
					Console.Write(signUP);
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

		static int checkCustomerCount(string[] uNames, string username, string[] uPass, int signUpCounter)
		{
			int n = -1;
			for (int i = 0; i < signUpCounter; i++)
			{
				if (username == uNames[i])
				{
					n = i;
				}
			}
			return n;
		}

		static bool signIn(string username, string password, string[] uNames, string[] uPass, int signUpCounter)
		{
			for (int i = 0; i <= signUpCounter; i++)
			{
				if (username == uNames[i] && password == uPass[i] && username != "\0")
				{
					return true;
				}
			}
			return false;
		}

		static string SignUp(ref string[] uNames,ref string[] uPass, string[] uRole, ref int signUpCounter)
		{
			if (signUpCounter >= 500)
			{
				return "Maximum number of customers have signed up.";
			}
			for (int i = 0; i < signUpCounter; i++)
			{
				if (uNames[signUpCounter] == uNames[i])
				{
					uNames[signUpCounter] = "\0";
					uPass[signUpCounter] = "\0";
					uRole[signUpCounter] = "\0";
					return "Already registered!";
				}
			}
			fileSignUp(ref uNames,ref uPass, signUpCounter);
			if (signUpCounter == 0)
			{
				return "You have been registered as an admin.";
			}
			return "You have been registered successfully as a customer.";
		}

		static int manager(string[] uNames, ref int signUpCounter, string[] medicines, string[] skinCare, string[] eyeCare, string[] medicalDevices, int[] medicineprice, int[] skinCarePrice, int[] medicalDevicesPrice, int[] eyeCareProductsPrice, ref int enterDataMedicine, ref int enterDataSkin, ref int enterDataEye, ref int enterDataDevices, ref int enterDataSnacks, string[] Feedback, ref int feedbackCounter, int[] discountMedicine, int[] discountSkinCares, int[] discountEyeCares, int[] discountDevice, ref int ia, ref int ja, ref int ka, ref int la, string[] discountedMedicines, string[] discountedSkinCare, string[] discountedEyeCare, string[] discountedDevices, ref int discountCounterMedicines, ref int discountCounterSkinCare, ref int discountCounterEyeCare, ref int discountCounterDevices, int[] discountPriceMedicines, int[] discountPriceSkinCare, int[] discountPriceEyeCare, int[] discountPriceMedicalDevices, string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice, int orderCounterMedicines, int orderCounterSkin, int orderCounterEye, int orderCounterDevices, ref int totalPrice, string[] uPass, string[] salesRecord, ref int salesRecordCounter)
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
					medicines[enterDataMedicine] = Console.ReadLine();
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

						Console.Write("Enter the name of medicine: " + medicines[enterDataMedicine]);
						Console.SetCursorPosition(35, 23);

						Console.Write("Enter price: ");
						text = Console.ReadLine();
					}
					medicineprice[enterDataMedicine] = int.Parse(text);
					if (!checkMedicine(medicines, medicines[enterDataMedicine], ref enterDataMedicine))
					{
						fileMedicines(medicines, medicineprice, enterDataMedicine);
						EnterDataMedicine(ref enterDataMedicine);
					}
					else
					{
						Console.SetCursorPosition(35, 29);
						Console.Write("You have already entered the item");
						Console.ReadKey();
						removeRepeatedMedicine(medicines, medicines[enterDataMedicine], medicineprice, ref enterDataMedicine);
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
					skinCare[enterDataSkin] = Console.ReadLine();
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
						Console.Write("Enter the name of skin care product: " + skinCarePrice[enterDataSkin]);
						Console.SetCursorPosition(35, 23);
						Console.Write("Enter price: ");
						text = Console.ReadLine();
					}
					skinCarePrice[enterDataSkin] = int.Parse(text);
					if (!checkSkinCare(skinCare, skinCare[enterDataSkin], ref enterDataSkin))
					{
						fileSkinCare(skinCare, skinCarePrice, enterDataSkin);
						EnterDataSkin(ref enterDataSkin);
					}
					else
					{
						;
						Console.SetCursorPosition(35, 23);
						Console.Write("You have already entered the item");
						Console.ReadKey();
						removeRepeatedSkinCare(skinCare, skinCare[enterDataSkin], ref enterDataSkin);
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
					eyeCare[enterDataEye] = Console.ReadLine();
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
						Console.Write("Enter the name of eye care product: " + eyeCareProductsPrice[enterDataEye]);
						Console.SetCursorPosition(35, 23);
						Console.Write("Enter price: ");
						text = Console.ReadLine();
					}
					eyeCareProductsPrice[enterDataEye] = int.Parse(text);
					if (!checkEyeCare(eyeCare, eyeCare[enterDataEye], ref enterDataEye))
					{
						fileEyeCare(eyeCare, eyeCareProductsPrice, enterDataEye);
						EnterDataEye(ref enterDataEye);
					}
					else
					{
						;
						Console.SetCursorPosition(35, 23);
						Console.Write("You have already entered the item");
						Console.ReadKey();
						removeRepeatedEyeCare(eyeCare, eyeCare[enterDataEye], ref enterDataEye);
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
					medicalDevices[enterDataDevices] = Console.ReadLine();
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
						Console.Write("Enter the name of medical device: " + medicalDevices[enterDataDevices]);
						Console.SetCursorPosition(35, 23);
						Console.Write("Enter price: ");
						text = Console.ReadLine();
					}
					medicalDevicesPrice[enterDataDevices] = int.Parse(text);
					if (!checkDevices(medicalDevices, medicalDevices[enterDataDevices], ref enterDataDevices))
					{
						fileMedicalDevices(medicalDevices, medicalDevicesPrice, enterDataDevices);
						EnterDataDevices(ref enterDataDevices);
					}
					else
					{
						Console.SetCursorPosition(35, 23);
						Console.Write("You have already entered the item");
						Console.ReadKey();
						removeRepeatedDevices(medicalDevices, medicalDevices[enterDataDevices], ref enterDataDevices);
					}
				}
				if (enterNumber == "5")
				{
					int y = 20;
					printHeader();

					Console.SetCursorPosition(35, 20);
					Console.Write("Enter the medicine you want to remove: ");
					medicine = Console.ReadLine();
					if (!checkMedicine(medicines, medicine, ref enterDataMedicine))
					{
						Console.SetCursorPosition(35, y + 1);
						Console.Write("There is no such medicine in the list.");
						Console.ReadKey();
					}
					else
					{
						removeMedicine(medicines, medicineprice, medicine, ref enterDataMedicine);
						Console.SetCursorPosition(35, 21);
						Console.Write("The item has been removed!");
						Console.SetCursorPosition(35, 22);
						fileMedicines(medicines, medicineprice, enterDataMedicine);
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
					if (!checkSkinCare(skinCare, skinCares, ref enterDataSkin))
					{
						;
						Console.SetCursorPosition(35, 21);
						Console.Write("There is no such item in the list.");
						Console.ReadKey();
					}
					else
					{

						removeSkinCare(skinCare, skinCarePrice, skinCares, ref enterDataSkin);
						Console.SetCursorPosition(35, 21);
						Console.Write("The item has been removed!");
						Console.SetCursorPosition(35, 22);
						fileSkinCare(skinCare, skinCarePrice, enterDataSkin);
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
					if (!checkEyeCare(eyeCare, eyeCares, ref enterDataEye))
					{
						;
						Console.SetCursorPosition(35, 21);
						Console.Write("There is no such item in the list.");
						Console.ReadKey();
					}
					else
					{

						removeEyeCare(eyeCare, eyeCareProductsPrice, eyeCares, ref enterDataEye);
						Console.SetCursorPosition(35, 21);
						Console.Write("The item has been removed!");
						Console.SetCursorPosition(35, 22);
						fileEyeCare(eyeCare, eyeCareProductsPrice, enterDataEye);
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
					if (!checkDevices(medicalDevices, medicalDevice, ref enterDataDevices))
					{
						;
						Console.SetCursorPosition(35, 21);
						Console.Write("There is no such device in the list.");
						Console.ReadKey();
					}
					else
					{

						removeDevices(medicalDevices, medicalDevicesPrice, medicalDevice, ref enterDataDevices);
						Console.SetCursorPosition(35, 21);
						Console.Write("The item has been removed!");
						Console.SetCursorPosition(35, 22);
						fileMedicalDevices(medicalDevices, medicalDevicesPrice, enterDataDevices);
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
						Console.SetCursorPosition(170, 21);
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
						if (!checkMedicine(medicines, medicine, ref enterDataMedicine))
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
							discountMedicine[discountCounterMedicines] = int.Parse(text);
							Console.SetCursorPosition(35, 23);

							Console.Write("Price after discount: " + discountMedicines(medicines, medicineprice, medicine, discountMedicine[discountCounterMedicines], ref enterDataMedicine, ref discountCounterMedicines, discountedMedicines, ref ia, discountPriceMedicines));
							Console.SetCursorPosition(35, 24);

							Console.Write("Press any key to continue: ");
							Console.ReadKey();
							discountMedicinesFile(discountedMedicines, discountPriceMedicines, discountMedicine, discountCounterMedicines);
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
						if (!checkSkinCare(skinCare, skinCares, ref enterDataSkin))
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
							discountSkinCares[discountCounterSkinCare] = int.Parse(text);
							Console.SetCursorPosition(35, 23);

							Console.Write("Price after discount: " + discountSkinCare(skinCare, skinCarePrice, skinCares, discountSkinCares[discountCounterSkinCare], ref enterDataSkin, ref discountCounterSkinCare, discountedSkinCare, ref ja, discountPriceSkinCare));
							Console.SetCursorPosition(35, 24);

							Console.Write("Press any key to continue: ");
							Console.ReadKey();
							discountSkinCareFile(discountedSkinCare, discountPriceSkinCare, discountSkinCares, discountCounterSkinCare);
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
						if (!checkEyeCare(eyeCare, eyeCares, ref enterDataEye))
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
							discountEyeCares[discountCounterEyeCare] = int.Parse(text);
							Console.SetCursorPosition(35, 22);
							Console.Write("Price after discount: " + discountEyeCare(eyeCare, eyeCareProductsPrice, eyeCares, discountEyeCares[discountCounterEyeCare], ref enterDataEye, ref discountCounterEyeCare, discountedEyeCare, ref ka, discountPriceEyeCare));
							Console.SetCursorPosition(35, 23);

							Console.Write("Press any key to continue: ");
							Console.ReadKey();
							discountEyeCareFile(discountedEyeCare, discountPriceEyeCare, discountEyeCares, discountCounterEyeCare);
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
						if (!checkDevices(medicalDevices, medicalDevice, ref enterDataDevices))
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
							discountDevice[discountCounterDevices] = int.Parse(text);
							Console.SetCursorPosition(35, 22);
							Console.Write("Price after discount: " + discountDevices(medicalDevices, medicalDevicesPrice, medicalDevice, discountDevice[discountCounterDevices], ref enterDataDevices, ref discountCounterDevices, discountedDevices, ref la, discountPriceMedicalDevices));
							Console.SetCursorPosition(35, 23);
							Console.Write("Press any key to continue: ");
							Console.ReadKey();
							discountDevicesFile(discountedDevices, discountPriceMedicalDevices, discountDevice, discountCounterDevices);
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
					viewCustomers(uNames, ref signUpCounter);
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
						if (checkMedicine(medicines, medicine, ref enterDataMedicine))
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
						if (checkSkinCare(skinCare, skinCares, ref enterDataSkin))
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
						if (checkEyeCare(eyeCare, eyeCares, ref enterDataEye))
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
						if (checkDevices(medicalDevices, medicalDevice, ref enterDataDevices))
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
					viewData(discountMedicine, discountSkinCares, discountEyeCares, discountDevice, medicines, skinCare, eyeCare, medicalDevices, medicineprice, skinCarePrice, eyeCareProductsPrice, medicalDevicesPrice, ref enterDataMedicine, ref enterDataDevices, ref enterDataSkin, ref enterDataEye);
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
						if (!checkMedicine(medicines, medicine, ref enterDataMedicine))
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
							updatePricesMedicine(medicine, medicines, medicineprice);
							for (int i = 0; i < discountCounterMedicines; i++)
							{
								if (medicine == discountedMedicines[i])
								{
									discountedMedicines[i] = "";
									discountCounterMedicines--;
									ia--;
								}
							}
							fileMedicines(medicines, medicineprice, enterDataMedicine);
						}
					}
					if (option == "2")
					{
						printHeader();

						Console.SetCursorPosition(170, 21);
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the skin care of which you want to change price: ");
						skinCares = Console.ReadLine();
						if (!checkSkinCare(skinCare, skinCares, ref enterDataSkin))
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
							updatePricesSkin(skinCares, skinCare, skinCarePrice);
							for (int i = 0; i < discountCounterSkinCare; i++)
							{
								if (skinCares == discountedSkinCare[i])
								{
									discountedSkinCare[i] = "";
									discountCounterSkinCare--;
									ja--;
								}
							}
							fileSkinCare(skinCare, skinCarePrice, enterDataSkin);
						}
					}
					if (option == "3")
					{
						printHeader();

						Console.SetCursorPosition(170, 21);
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the eye care product of which you want to change price: ");
						eyeCares = Console.ReadLine();
						if (!checkEyeCare(eyeCare, eyeCares, ref enterDataEye))
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
							updatePricesEyeCare(eyeCares, eyeCare, eyeCareProductsPrice);
							for (int i = 0; i < discountCounterEyeCare; i++)
							{
								if (eyeCares == discountedEyeCare[i])
								{
									discountedEyeCare[i] = "";
									discountCounterEyeCare--;
									ka--;
								}
							}
							fileEyeCare(eyeCare, eyeCareProductsPrice, enterDataEye);
						}
					}
					if (option == "4")
					{
						printHeader();

						Console.SetCursorPosition(170, 21);
						Console.SetCursorPosition(35, 20);
						Console.Write("Enter the medical device of which you want to change price: ");
						medicalDevice = Console.ReadLine();
						if (!checkDevices(medicalDevices, medicalDevice, ref enterDataDevices))
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
							updatePricesDevices(medicalDevice, medicalDevices, medicalDevicesPrice);
							for (int i = 0; i < discountCounterDevices; i++)
							{
								if (medicalDevice == discountedDevices[i])
								{
									discountedDevices[i] = "";
									discountCounterDevices--;
									la--;
								}
							}
							fileMedicalDevices(medicalDevices, medicalDevicesPrice, enterDataDevices);
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
			for (int i = 0;i < text.Length; i++)
			{
				if (!char.IsDigit(text[i]))
					return false;
			}
			return true;
		}

		static void EnterDataMedicine(ref int enterDataMedicine)
		{
			enterDataMedicine++;
		}

		static void EnterDataSkin(ref int enterDataSkin)
		{
			enterDataSkin++;
		}

		static void EnterDataEye(ref int enterDataEye)
		{
			enterDataEye++;
		}

		static void EnterDataDevices(ref int enterDataDevices)
		{
			enterDataDevices++;
		}

		static void feedback(string[] Feedback, ref int feedbackCounter)
		{

			Console.SetCursorPosition(35, 21);
			Console.Write("Must write letter h and then the feedback after that letter");
			Feedback[feedbackCounter] = Console.ReadLine();
			feedbackFile(Feedback[feedbackCounter]);
			feedbackCounter++;
		}

		static bool checkMedicine(string[] medicines, string medicine, ref int enterDataMedicine)
		{
			for (int i = 0; i < enterDataMedicine; i++)
			{
				if (medicine == medicines[i])
				{
					return true;
				}
			}
			return false;
		}

		static bool checkEyeCare(string[] eyeCare, string eyeCares, ref int enterDataEye)
		{
			for (int i = 0; i < enterDataEye; i++)
			{
				if (eyeCares == eyeCare[i])
				{
					return true;
				}
			}
			return false;
		}

		static bool checkSkinCare(string[] skinCare, string skinCares, ref int enterDataSkin)
		{
			for (int i = 0; i < enterDataSkin; i++)
			{
				if (skinCares == skinCare[i])
				{
					return true;
				}
			}
			return false;
		}

		static bool checkDevices(string[] medicalDevices, string medicalDevice, ref int enterDataDevices)
		{
			for (int i = 0; i < enterDataDevices; i++)
			{
				if (medicalDevice == medicalDevices[i])
				{
					return true;
				}
			}
			return false;
		}

		static void updatePricesMedicine(string medicine, string[] medicines, int[] medicineprice)
		{
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (medicine == medicines[i])
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
			medicineprice[n] = int.Parse(text);
		}

		static void updatePricesSkin(string skinCares, string[] skinCare, int[] skinCarePrice)
		{
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (skinCares == skinCare[i])
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
			skinCarePrice[n] = int.Parse(text);
		}

		static void updatePricesEyeCare(string eyeCares, string[] eyeCare, int[] eyeCareProductsPrice)
		{
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (eyeCares == eyeCare[i])
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
			eyeCareProductsPrice[n] = int.Parse(text);
		}

		static void updatePricesDevices(string medicalDevice, string[] medicalDevices, int[] medicalDevicesPrice)
		{
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (medicalDevice == medicalDevices[i])
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
			medicalDevicesPrice[n] = int.Parse(text);
		}

		static void cancelOrder(string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice,int[] quantityMedicines,int[] quantitySkinCare, int[] quantityEyeCare,int[] quantityDevices,  ref int orderCounterMedicines, ref int orderCounterSkin, ref int orderCounterEye, ref int orderCounterDevices)
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

		static int customer(string[] medicines, string[] skinCare, string[] eyeCare, string[] medicalDevices, int[] medicineprice, int[] skinCarePrice, int[] medicalDevicesPrice, int[] eyeCareProductsPrice, ref int enterDataMedicine, ref int enterDataSkin, ref int enterDataEye, ref int enterDataDevices, ref int enterDataSnacks, string[] Feedback, ref int feedbackCounter, int[] discountMedicine, int[] discountSkinCares, int[] discountEyeCares, int[] discountDevice, ref int ia, ref int ja, ref int ka, ref int la, string[] discountedMedicines, string[] discountedSkinCare, string[] discountedEyeCare, string[] discountedDevices, ref int discountCounterMedicines, ref int discountCounterSkinCare, ref int discountCounterEyeCare, ref int discountCounterDevices, int[] discountPriceMedicines, int[] discountPriceSkinCare, int[] discountPriceEyeCare, int[] discountPriceMedicalDevices, string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice, int orderCounterMedicines, int orderCounterSkin, int orderCounterEye, int orderCounterDevices, ref int totalPrice, string[] uNames, string[] uPass, ref int signUpCounter, ref int customerCount, string[] salesRecord, ref int salesRecordCounter, ref bool paymentDone)
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
			storeSkinCare(skinCare, skinCarePrice, ref orderCounterSkin);
			storeEyeCare(eyeCare, eyeCareProductsPrice, ref orderCounterEye);
			storeOrderDevices(medicalDevices, medicalDevicesPrice, ref orderCounterDevices);
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
					if (!checkMedicine(medicines, orderMedicines[orderCounterMedicines], ref enterDataMedicine))
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
						orderMedicine(medicines, orderMedicines[orderCounterMedicines], quantityMedicine[orderCounterMedicines], medicineprice, ref enterDataMedicine, ref totalPrice); ;
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
					if (!checkSkinCare(skinCare, orderSkinCares[orderCounterSkin], ref enterDataSkin))
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
						orderSkinCare(skinCare, orderSkinCares[orderCounterSkin], quantitySkinCare[orderCounterSkin], skinCarePrice, ref enterDataSkin, ref totalPrice);
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
					if (!checkEyeCare(eyeCare, orderEyeCares[orderCounterEye], ref enterDataEye))
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
						orderEyeCare(eyeCare, orderEyeCares[orderCounterEye], quantityEyeCare[orderCounterEye], eyeCareProductsPrice, ref enterDataEye, ref totalPrice);
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
					if (!checkDevices(medicalDevices, orderDevice[orderCounterDevices], ref enterDataDevices))
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
						orderDevices(medicalDevices, orderDevice[orderCounterDevices], quantityDevices[orderCounterDevices], medicalDevicesPrice, ref enterDataDevices, ref totalPrice);
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
						if (checkMedicine(medicines, removeOrders, ref enterDataMedicine))
							x = medicineNumber(medicines, removeOrders);
						if (checkSkinCare(skinCare, removeOrders, ref enterDataSkin))
							x = skinCareNumber(skinCare, removeOrders);
						if (checkEyeCare(eyeCare, removeOrders, ref enterDataEye))
							x = eyeCareNumber(eyeCare, removeOrders);
						if (checkDevices(medicalDevices, removeOrders, ref enterDataDevices))
							x = medicalDevicesNumber(medicalDevices, removeOrders);
						removeOrder(quantityMedicine, quantitySkinCare, quantityEyeCare, quantityDevices, removeOrders, orderMedicines, orderSkinCares, orderEyeCares, orderDevice, medicineprice, skinCarePrice, eyeCareProductsPrice, medicalDevicesPrice, ref totalPrice, x);
						orderMedicinesFile(orderMedicines, quantityMedicine, orderCounterMedicines);
						orderSkinCareFile(orderSkinCares, quantitySkinCare, orderCounterSkin);
						orderEyeCareFile(orderEyeCares, quantityEyeCare, orderCounterEye);
						orderDevicesFile(orderDevice, quantityDevices, orderCounterDevices);
					}
				}
				if (n == "6")
				{
					printHeader();
					orderStatus(medicines, skinCare, eyeCare, medicalDevices, orderMedicines, orderSkinCares, orderEyeCares, orderDevice, ref orderCounterMedicines, ref orderCounterSkin, ref orderCounterEye, ref orderCounterDevices, medicineprice, skinCarePrice, eyeCareProductsPrice, medicalDevicesPrice, quantityMedicine, quantitySkinCare, quantityEyeCare, quantityEyeCare, ref totalPrice);
					Console.ReadKey();
				}
				if (n == "7")
				{
					printHeader();
					viewData(discountMedicine, discountSkinCares, discountEyeCares, discountDevice, medicines, skinCare, eyeCare, medicalDevices, medicineprice, skinCarePrice, eyeCareProductsPrice, medicalDevicesPrice, ref enterDataMedicine, ref enterDataDevices, ref enterDataSkin, ref enterDataEye);
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
						cancelOrder(orderMedicines, orderSkinCares, orderEyeCares, orderDevice,quantityMedicine,quantitySkinCare,quantityEyeCare,quantityDevices, ref orderCounterMedicines, ref orderCounterSkin, ref orderCounterEye, ref orderCounterDevices);
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

		static void orderMedicine(string[] medicines, string medicine, int quantity, int[] medicineprice, ref int enterDataMedicine, ref int totalPrice)
		{
			int n = 0;
			for (int i = 0; i < enterDataMedicine; i++)
			{
				if (medicine == medicines[i])
					n = i;
			}
			totalPrice += medicineprice[n] * quantity;
		}

		static void orderSkinCare(string[] skinCare, string skinCares, int quantity, int[] skinCarePrice, ref int enterDataSkin, ref int totalPrice)
		{
			int n = 0;
			for (int i = 0; i < enterDataSkin; i++)
			{
				if (skinCares == skinCare[i])
					n = i;
			}
			totalPrice += skinCarePrice[n] * quantity;
		}

		static void orderEyeCare(string[] eyeCare, string eyeCares, int quantity, int[] eyeCareProductsPrice, ref int enterDataEye, ref int totalPrice)
		{
			int n = 0;
			for (int i = 0; i < enterDataEye; i++)
			{
				if (eyeCares == eyeCare[i])
					n = i;
			}
			totalPrice += eyeCareProductsPrice[n] * quantity;
		}

		static void orderDevices(string[] medicalDevices, string medicalDevice, int quantity, int[] medicalDevicesPrice, ref int enterDataDevices, ref int totalPrice)
		{
			int n = 0;
			for (int i = 0; i < enterDataDevices; i++)
			{
				if (medicalDevice == medicalDevices[i])
					n = i;
			}
			totalPrice += medicalDevicesPrice[n] * quantity;
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

		static int discountMedicines(string[] medicines, int[] medicineprice, string medicine, int discountRate, ref int enterDataMedicine, ref int discountCounterMedicines, string[] discountedMedicines, ref int ia, int[] discountPriceMedicines)
		{
			int n = 0;
			for (int s = 0; s < enterDataMedicine; s++)
			{
				if (medicine == medicines[s])
				{
					n = s;
				}
			}
			medicineprice[n] = medicineprice[n] - (medicineprice[n] * discountRate / 100);
			discountedMedicines[discountCounterMedicines] = medicine;
			discountPriceMedicines[ia] = medicineprice[n];
			return medicineprice[n];
		}

		static int discountSkinCare(string[] skinCare, int[] skinCarePrice, string skinCares, int discountRate, ref int enterDataSkin, ref int discountedCounterSkinCare, string[] discountedSkinCare, ref int ja, int[] discountPriceSkinCare)
		{
			int n = 0;
			for (int s = 0; s < enterDataSkin; s++)
			{
				if (skinCares == skinCare[s])
				{
					n = s;
				}
			}
			skinCarePrice[n] = skinCarePrice[n] - (skinCarePrice[n] * discountRate / 100);
			discountedSkinCare[discountedCounterSkinCare] = skinCares;
			discountPriceSkinCare[ja] = skinCarePrice[n];
			return skinCarePrice[n];
		}

		static int discountEyeCare(string[] eyeCare, int[] eyeCareProductsPrice, string eyeCares, int discountRate, ref int enterDataEye, ref int discountCounterEyeCare, string[] discountedEyeCare, ref int ka, int[] discountPriceEyeCare)
		{
			int n = 0;
			for (int s = 0; s < enterDataEye; s++)
			{
				if (eyeCares == eyeCare[s])
				{
					n = s;
				}
			}
			eyeCareProductsPrice[n] = eyeCareProductsPrice[n] - (eyeCareProductsPrice[n] * discountRate / 100);
			discountedEyeCare[discountCounterEyeCare] = eyeCares;
			discountPriceEyeCare[ka] = eyeCareProductsPrice[n];
			ka++;
			return eyeCareProductsPrice[n];
		}

		static int discountDevices(string[] medicalDevices, int[] medicalDevicesPrice, string medicalDevice, int discountRate, ref int enterDataDevices, ref int discountedCounterDevices, string[] discountedDevices, ref int la, int[] discountPriceMedicalDevices)
		{
			int n = 0;
			for (int s = 0; s < enterDataDevices; s++)
			{
				if (medicalDevice == medicalDevices[s])
				{
					n = s;
				}
			}
			medicalDevicesPrice[n] = medicalDevicesPrice[n] - (medicalDevicesPrice[n] * discountRate / 100);
			discountedDevices[discountedCounterDevices] = medicalDevice;
			discountPriceMedicalDevices[la] = medicalDevicesPrice[n];
			la++;
			return medicalDevicesPrice[n];
		}

		static string signUp(ref string[] uNames,ref string[] uPass, string[] uRole, ref int signUpCounter)
		{
			if (signUpCounter >= 500)
			{
				return "Maximum number of customers have signed up.";
			}
			for (int i = 0; i < signUpCounter; i++)
			{
				if (signUpCounter >= 1 && uNames[signUpCounter] == uNames[i])
				{
					uNames[signUpCounter] = "\0";
					uPass[signUpCounter] = "\0";
					uRole[signUpCounter] = "\0";
					return "Already registered!";
				}
			}
			if (signUpCounter == 0)
			{
				fileSignUp(ref uNames,ref uPass, signUpCounter);
				signUpCounter++;
				return "You have been registered as an admin.";
			}
			fileSignUp(ref uNames,ref uPass, signUpCounter);
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

		static void removeOrder(int[] quantityMedicine, int[] quantitySkinCare, int[] quantityEyeCare, int[] quantityDevices, string removeOrders, string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice, int[] medicineprice, int[] skinCarePrice, int[] eyeCareProductsPrice, int[] medicalDevicesPrice, ref int totalPrice, int n)
		{
			for (int i = 0; i < 100; i++)
			{
				if (removeOrders == orderMedicines[i])
				{
					orderMedicines[i] = "";
					totalPrice -= medicineprice[n] * quantityMedicine[i];
					break;
				}
				if (removeOrders == orderSkinCares[i])
				{
					orderSkinCares[i] = "";
					totalPrice -= skinCarePrice[n] * quantitySkinCare[i];
					break;
				}
				if (removeOrders == orderEyeCares[i])
				{
					orderEyeCares[i] = "";
					totalPrice -= eyeCareProductsPrice[n] * quantityEyeCare[i];
					break;
				}
				if (removeOrders == orderDevice[i])
				{
					orderDevice[i] = "";
					totalPrice -= medicalDevicesPrice[n] * quantityDevices[i];
					break;
				}
			}
		}
		static void viewData(int[] discountMedicine, int[] discountSkinCare, int[] discountEyeCare, int[] discountDevice, string[] medicines, string[] skinCare, string[] eyeCare, string[] medicalDevices, int[] medicineprice, int[] skinCarePrice, int[] eyeCareProductsPrice, int[] medicalDevicesPrice, ref int enterDataMedicine, ref int enterDataDevices, ref int enterDataSkin, ref int enterDataEye)
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
				if (medicines[i] == "")
				{
					continue;
				}

				Console.SetCursorPosition(20, y + 1);
				Console.Write(medicines[i]);

				Console.SetCursorPosition(60, y + 1);
				Console.Write(discountMedicine[i]);

				Console.SetCursorPosition(100, y + 1);
				Console.Write(medicineprice[i]);
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
				if (skinCare[i] == "")
				{
					continue;
				}

				Console.SetCursorPosition(20, y + 1);
				Console.Write(skinCare[i]);

				Console.SetCursorPosition(60, y + 1);
				Console.Write(discountSkinCare[i]);

				Console.SetCursorPosition(100, y + 1);
				Console.Write(skinCarePrice[i]);
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
				if (eyeCare[i] == "")
				{
					continue;
				}
				Console.SetCursorPosition(20, y + 1);
				Console.Write(eyeCare[i]);
				Console.SetCursorPosition(60, y + 1);
				Console.Write(discountEyeCare[i]);
				Console.SetCursorPosition(100, y + 1);
				Console.Write(eyeCareProductsPrice[i]);
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
			for (int i = 0; i <enterDataDevices; i++)
			{
				if (medicalDevices[i] == "")
				{
					continue;
				}
				Console.SetCursorPosition(20, y + 1);

				Console.Write(medicalDevices[i]);

				Console.SetCursorPosition(60, y + 1);
				Console.Write(discountDevice[i]);
				Console.SetCursorPosition(100, y + 1);

				Console.Write(medicalDevicesPrice[i]);
				y++;
			}
		}

		static void viewCustomers(string[] uNames, ref int signUpCounter)
		{
			int y = 20;
			Console.SetCursorPosition(20, 20);

			Console.Write("Serial Number");
			Console.SetCursorPosition(45, 20);
			Console.Write("Customers");
			for (int i = 2; i < signUpCounter; i++)
			{
				if (uNames[i] == "")
				{
					continue;
				}
				Console.SetCursorPosition(45, y + 1);

				Console.Write(uNames[i]);
				Console.SetCursorPosition(20, y + 1);

				Console.Write(i);
				y++;
			}
		}

		static void removeMedicine(string[] medicines, int[] medicineprice, string medicine, ref int enterDataMedicine)
		{
			int n = 0;
			for (int i = 0; i <= enterDataMedicine; i++)
			{
				if (medicine == medicines[i])
				{
					n = i;
					break;
				}
			}
			medicines[n] = "";
			medicineprice[n] = 0;
		}

		static void removeSkinCare(string[] skinCare, int[] skinCarePrice, string skinCares, ref int enterDataSkin)
		{
			int n = 0;
			for (int i = 0; i <= enterDataSkin; i++)
			{
				if (skinCares == skinCare[i])
				{
					n = i;
					break;
				}
			}
			skinCare[n] = "";
			skinCarePrice[n] = 0;
		}

		static void removeEyeCare(string[] eyeCare, int[] eyeCareProductsPrice, string eyeCares, ref int enterDataEye)
		{
			int n = 0;
			for (int i = 0; i <= enterDataEye; i++)
			{
				if (eyeCares == eyeCare[i])
				{
					n = i;
					break;
				}
			}
			eyeCare[n] = "";
			eyeCareProductsPrice[n] = 0;
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

		static void removeDevices(string[] medicalDevices, int[] medicalDevicesPrice, string medicalDevice, ref int enterDataDevice)
		{
			int n = 0;
			for (int i = 0; i <= enterDataDevice; i++)
			{
				if (medicalDevice == medicalDevices[i])
				{
					n = i;
					break;
				}
			}
			medicalDevices[n] = "";
			medicalDevicesPrice[n] = 0;
		}

		static void orderStatus(string[] medicines, string[] skinCare, string[] eyeCare, string[] medicalDevices, string[] orderMedicines, string[] orderSkinCares, string[] orderEyeCares, string[] orderDevice, ref int orderCounterMedicines, ref int orderCounterSkin, ref int orderCounterEye, ref int orderCounterDevices, int[] medicineprice, int[] skinCarePrice, int[] eyeCareProductsPrice, int[] medicalDevicesPrice, int[] quantityMedicine, int[] quantitySkinCare, int[] quantityEyeCare, int[] quantityDevices, ref int totalPrice)
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

				n = medicineNumber(medicines, orderMedicines[i]);
				Console.Write(orderMedicines[i]);
				Console.SetCursorPosition(x + 40, y + 1);

				Console.Write(quantityMedicine[i]);
				Console.SetCursorPosition(x + 100, y + 1);

				Console.Write(medicineprice[n]);
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
				n = skinCareNumber(skinCare, orderSkinCares[i]);

				Console.Write(orderSkinCares[i]);
				Console.SetCursorPosition(x + 40, y);

				Console.Write(quantitySkinCare[i]);
				Console.SetCursorPosition(x + 100, y + 1);

				Console.Write(skinCarePrice[n]);
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
				n = eyeCareNumber(eyeCare, orderEyeCares[i]);
				Console.SetCursorPosition(x + 40, y);

				Console.Write(quantityEyeCare[i]);
				Console.SetCursorPosition(x + 100, y + 1);

				Console.Write(eyeCareProductsPrice[n]);
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
				n = medicalDevicesNumber(medicalDevices, orderDevice[i]);
				Console.SetCursorPosition(x + 40, y);

				Console.Write(quantityDevices[i]);
				Console.SetCursorPosition(x + 80, y + 1);

				Console.Write(medicalDevicesPrice[n]);
				y++;
			}
			Console.SetCursorPosition(80, y + 3);
			totalPrice = calculateTotalPrice(medicines, skinCare,eyeCare,medicalDevices, orderMedicines, quantityMedicine,medicineprice, orderSkinCares, quantitySkinCare,skinCarePrice, orderEyeCares, quantityEyeCare,eyeCareProductsPrice, orderDevice, quantityDevices, medicalDevicesPrice);
			Console.Write("Total bill: " + totalPrice);
		}

		static int calculateTotalPrice(string[] medicines, string[] skinCare, string[] eyeCare, string[] medicalDevices, string[] orderMedicines, int[] quantityMedicine, int[] medicineprice, string[] orderSkinCares, int[] quantitySkinCare, int[] skinCarePrice, string[] orderEyeCare, int[] quantityEyeCare, int[] eyeCarePrice, string[] orderDevices, int[] quantityDevices, int[] medicalDevicesPrice)
		{
			int price = 0;
			for(int i = 0; orderMedicines[i] != "";i++)
			{
				int n = medicineNumber(medicines, orderMedicines[i]);
				price += quantityMedicine[i] * medicineprice[n];
			}
			for (int i = 0; orderSkinCares[i] != ""; i++)
			{
				int n = skinCareNumber(skinCare, orderSkinCares[i]);
				price += quantitySkinCare[i] * skinCarePrice[n];
			}
			for (int i = 0; orderEyeCare[i] != ""; i++)
			{
				int n = eyeCareNumber(eyeCare, orderEyeCare[i]);
				price += quantityEyeCare[i] * eyeCarePrice[n];
			}
			for (int i = 0; orderDevices[i] != ""; i++)
			{
				int n = medicalDevicesNumber(medicalDevices, orderDevices[i]);
				price += quantityDevices[i] * medicalDevicesPrice[n];
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

		static void viewDiscounts(string[] medicines, string[] skinCare, string[] eyeCare, string[] medicalDevices, string[] discountedMedicines, string[] discountedSkinCare, string[] discountedEyeCare, string[] discountedDevices, ref int discountCounterMedicines, ref int discountCounterSkinCare, ref int discountCounterEyeCare, ref int discountCounterDevices, int[] discountMedicine, int[] discountSkinCares, int[] discountEyeCares, int[] discountDevice, int[] medicineprice, int[] skinCarePrice, int[] eyeCareProductsPrice, int[] medicalDevicesPrice, ref int ia, int ja, ref int ka, ref int la, int[] discountPriceMedicines, int[] discountPriceSkinCare, int[] discountPriceEyeCare, int[] discountPriceMedicalDevice)
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
				n = medicineNumber(medicines, discountedMedicines[i]);

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
				n = skinCareNumber(skinCare, discountedSkinCare[i]);

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
				n = eyeCareNumber(eyeCare, discountedEyeCare[i]);

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
				n = medicalDevicesNumber(medicalDevices, discountedDevices[i]);

				Console.Write(discountPriceMedicalDevice[n]);
				y++;
			}
		}

		static int taxMedicines(string[] medicines, string medicine, int[] medicineprice, int taxRate, ref int enterDataMedicines)
		{
			int n = 0;
			for (int i = 0; i < enterDataMedicines; i++)
			{
				if (medicine == medicines[i])
					n = i;
			}
			medicineprice[n] = medicineprice[n] + (medicineprice[n] * taxRate / 100);
			return medicineprice[n];
		}

		static int taxSkinCare(string[] skinCare, string skinCares, int[] skinCarePrice, int taxRate, ref int enterDataSkin)
		{
			int n = 0;
			for (int i = 0; i < enterDataSkin; i++)
			{
				if (skinCares == skinCare[i])
					n = i;
			}
			skinCarePrice[n] = skinCarePrice[n] + (skinCarePrice[n] * taxRate / 100);
			return skinCarePrice[n];
		}

		static int taxEyeCare(string[] eyeCare, string eyeCares, int[] eyeCarePrice, int taxRate, ref int enterDataEye)
		{
			int n = 0;
			for (int i = 0; i < enterDataEye; i++)
			{
				if (eyeCares == eyeCare[i])
					n = i;
			}
			eyeCarePrice[n] = eyeCarePrice[n] + (eyeCarePrice[n] * taxRate / 100);
			return eyeCarePrice[n];
		}

		static int taxMedicalDevices(string[] medicalDevices, string medicalDevice, int[] medicalDevicesPrice, int taxRate, ref int enterDataDevices)
		{
			int n = 0;
			for (int i = 0; i < enterDataDevices; i++)
			{
				if (medicalDevice == medicalDevices[i])
					n = i;
			}
			medicalDevicesPrice[n] = medicalDevicesPrice[n] + (medicalDevicesPrice[n] * taxRate / 100);
			return medicalDevicesPrice[n];
		}

		static void changePassword(string[] uPass, ref int customerCount)
		{
			string password;
			int x = 20, y = 20;
			Console.SetCursorPosition(x, y);

			Console.Write("Enter your old password: ");
			password = Console.ReadLine();
			while (!(password == uPass[customerCount]))
			{

				Console.SetCursorPosition(x, y + 1);
				Console.Write("Wrong password!");
				Console.ReadKey();
				Console.Clear();
				printHeader();
				Console.SetCursorPosition(x, y);

				Console.Write("Enter your old password: ");
				password = Console.ReadLine();
			}

			Console.SetCursorPosition(x, y + 2);
			Console.Write("Enter your new password: ");
			uPass[customerCount] = Console.ReadLine();
			Console.SetCursorPosition(x, y + 4);

			Console.Write("Your password has been changed!");
		}

		static void salesRecords(string[] saleRecord, int salesRecordCounter)
		{
			int x = 35, y = 20;
			if (salesRecordCounter == 0)
			{
				Console.SetCursorPosition(35, 20);
				Console.Write("There is no sales yet!");
				return;
			}
			Console.SetCursorPosition(x, y);
			for (int i = 0; i < salesRecordCounter; i++)
			{
				Console.SetCursorPosition(x, y + 1);
				Console.Write(saleRecord[i]);
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

		static void removeRepeatedMedicine(string[] medicines, string medicine, int[] medicineprice, ref int enterDataMedicine)
		{
			int count = 0;
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (medicine == medicines[i])
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
				medicines[n] = "";
			}
		}

		static void removeRepeatedSkinCare(string[] skinCare, string skinCares, ref int enterDataSkin)
		{
			int count = 0;
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (skinCares == skinCare[i])
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
				skinCare[n] = "";
			}
		}

		static void removeRepeatedEyeCare(string[] eyeCare, string eyeCares, ref int enterDataEye)
		{
			int count = 0;
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (eyeCares == eyeCare[i])
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
				eyeCare[n] = "";
			}
		}

		static void removeRepeatedDevices(string[] medicalDevices, string medicalDevice, ref int enterDataDevices)
		{
			int count = 0;
			int n = 0;
			for (int i = 0; i < 100; i++)
			{
				if (medicalDevice == medicalDevices[i])
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
				medicalDevices[n] = "";
			}
		}

		static int medicineNumber(string[] medicines, string medicine)
		{
			for (int i = 0; i < 100; i++)
			{
				if (medicine == medicines[i])
					return i;
			}
			return 0;
		}

		static int skinCareNumber(string[] skinCare, string skinCares)
		{
			for (int i = 0; i < 100; i++)
			{
				if (skinCares == skinCare[i])
					return i;
			}
			return 0;
		}

		static int eyeCareNumber(string[] eyeCare, string eyeCares)
		{
			for (int i = 0; i < 100; i++)
			{
				if (eyeCares == eyeCare[i])
					return i;
			}
			return 0;
		}

		static int medicalDevicesNumber(string[] medicalDevices, string medicalDevice)
		{
			for (int i = 0; i < 100; i++)
			{
				if (medicalDevice == medicalDevices[i])
					return i;
			}
			return 0;
		}

		static void fileSignUp(ref string[] uNames,ref string[] uPass, int signUpCounter)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\signUp.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i <= signUpCounter; i++)
				{
					file.WriteLine(uNames[i] + "," + uPass[i]);
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
						password = password + line[i];
					}
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
			return password;
		}

		static void storeNamesAndPasswordOfCustomers(ref string[] uNames,ref string[] uPass, ref int signUpCounter)
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
					uNames[signUpCounter] = name;
					uPass[signUpCounter] = password;
					signUpCounter++;
				}
			}	
			file.Close();
		}

		static void fileMedicines(string[] medicines, int[] medicineprice, int enterDataMedicine)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\medicines.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < enterDataMedicine; i++)
				{
					file.WriteLine(medicines[i] + "," + medicineprice[i]);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void fileSkinCare(string[] skinCare, int[] skinCarePrice, int enterDataSkin)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\skinCare.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < enterDataSkin; i++)
				{
					file.WriteLine(skinCare[i] + "," + skinCarePrice[i]);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void fileEyeCare(string[] eyeCare, int[] eyeCareProductsPrice, int enterDataEye)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\eyeCare.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < enterDataEye; i++)
				{
					file.WriteLine(eyeCare[i] + "," + eyeCareProductsPrice[i]);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void fileMedicalDevices(string[] medicalDevices, int[] medicalDevicesPrice, int enterDataDevices)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\medicalDevices.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < enterDataDevices; i++)
				{
					file.WriteLine(medicalDevices[i] + "," + medicalDevicesPrice[i]);
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
			int intprice = int.Parse(price);
			return intprice;
		}

		static void storeMedicines(string[] medicines, int[] medicineprice, ref int enterDataMedicine)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\medicines.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					medicines[enterDataMedicine] = parseMedicines(enterDataMedicine);
					medicineprice[enterDataMedicine] = parseMedicinePrice(enterDataMedicine);
					enterDataMedicine++;
				}
			}
		}

		static void storeSkinCare(string[] skinCare, int[] skinCarePrice, ref int enterDataSkin)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\skinCare.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					skinCare[enterDataSkin] = parseSkinCare(enterDataSkin);
					skinCarePrice[enterDataSkin] = parseSkinCarePrice(enterDataSkin);
					enterDataSkin++;
				}
			}
		}

		static void storeEyeCare(string[] eyeCare, int[] eyeCareProductsPrice, ref int enterDataEye)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\eyeCare.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					eyeCare[enterDataEye] = parseEyeCare(enterDataEye);
					eyeCareProductsPrice[enterDataEye] = parsePriceEyeCare(enterDataEye);
					enterDataEye++;
				}
			}
		}

		static void storeDataDevices(string[] medicalDevices, int[] medicalDevicesPrice, ref int enterDataDevices)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\medicalDevices.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					medicalDevices[enterDataDevices] = parseDevices(enterDataDevices);
					medicalDevicesPrice[enterDataDevices] = parseDevicePrice(enterDataDevices);
					enterDataDevices++;
				}
			}
		}

		static void discountMedicinesFile(string[] discountedMedicines, int[] discountPriceMedicines, int[] discountMedicine, int discountCounterMedicines)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicines.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < discountCounterMedicines; i++)
				{
					file.WriteLine(discountedMedicines[i] + "," + discountMedicine[i]);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void discountSkinCareFile(string[] discountedSkinCare, int[] discountPriceSkinCare, int[] discountSkinCare, int discountCounterSkinCare)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\discountSkinCare.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < discountCounterSkinCare; i++)
				{
					file.WriteLine(discountedSkinCare[i] + "," + discountSkinCare[i]);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void discountEyeCareFile(string[] discountedEyeCare, int[] discountPriceEyeCare, int[] discountEyeCare, int discountCounterEyeCare)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\discountEyeCare.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i < discountCounterEyeCare; i++)
				{
					file.WriteLine(discountedEyeCare[i] + "," + discountEyeCare[i]);
					file.Flush();
				}
				file.Close();
			}
			else
			{
				Console.WriteLine("File does not exist");
			}
		}

		static void discountDevicesFile(string[] discountedDevices, int[] discountPriceMedicalDevice, int[] discountDevice, int discountCounterDevices)
		{
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicalDevices.txt";
			if (File.Exists(path))
			{
				StreamWriter file = new StreamWriter(path, false);
				for (int i = 0; i <= discountCounterDevices; i++)
				{
					file.WriteLine(discountedDevices[i] + "," + discountDevice[i]);
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
			int intprice = int.Parse(price);
			return intprice;
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
			int intprice = int.Parse(price);
			return intprice;
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
			int intprice = int.Parse(price);
			return intprice;
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
			int intprice = int.Parse(price);
			return intprice;
		}

		static void storeDiscountMedicines(string[] discountedMedicines, int[] discountMedicine, ref int discountCounterMedicines)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicines.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					discountedMedicines[discountCounterMedicines] = parseDiscountMedicine(discountCounterMedicines);
					discountMedicine[discountCounterMedicines] = parseDiscountMedicinesRate(discountCounterMedicines);
					discountCounterMedicines++;
				}
			}
			file.Close();
		}

		static void storeDiscountedSkinCare(string[] discountedSkinCare, int[] discountSkinCares, ref int discountCounterSkinCare)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountSkinCare.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					discountedSkinCare[discountCounterSkinCare] = parseDiscountSkinCare(discountCounterSkinCare);
					discountSkinCares[discountCounterSkinCare] = parseDiscountSkinCareRate(discountCounterSkinCare);
					discountCounterSkinCare++;
				}
			}
			file.Close();
		}

		static void storeDiscountedEyeCare(string[] discountedEyeCare, int[] discountEyeCares, ref int discountCounterEyeCare)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountEyeCare.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					discountedEyeCare[discountCounterEyeCare] = parseDiscountEyeCare(discountCounterEyeCare);
					discountEyeCares[discountCounterEyeCare] = parseDiscountEyeCareRate(discountCounterEyeCare);
					discountCounterEyeCare++;
				}
			}
			file.Close();
		}

		static void storeDiscountedDevices(string[] discountedDevices, int[] discountDevice, ref int discountCounterDevices)
		{
			string line = "";
			string path = "D:\\Programming Day\\Week5\\idk\\discountMedicalDevices.txt";
			StreamReader file = new StreamReader(path);
			if (File.Exists(path))
			{
				while ((line = file.ReadLine()) != null)
				{
					discountedDevices[discountCounterDevices] = parseDiscountDevices(discountCounterDevices);
					discountDevice[discountCounterDevices] = parseDiscountDevicesRate(discountCounterDevices);
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
			int intquantity = int.Parse(quantity);
			return intquantity;
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
	}
}