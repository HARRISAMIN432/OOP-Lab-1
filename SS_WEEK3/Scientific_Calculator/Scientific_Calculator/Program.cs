using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string option;
			while (true)
			{
				Console.Clear();
				displayMenu();
				option = Console.ReadLine();
				if (option == "1")
				{
					calculator objects = new calculator(10, 10, 10);
					Console.WriteLine("The object has been created successfully with default values of 10");
					Console.WriteLine("Enter any key to continue...");
					Console.ReadKey();
					while (true)
					{
						displayMenu();
						Console.WriteLine("Enter the option: ");
						option = Console.ReadLine();
						if (option == "2")
						{
							Console.Clear();
							objects.changeAttributes();
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "3")
						{
							Console.Clear();
							Console.WriteLine("Sum of " + objects.n1 + " and " + objects.n2 + " is: " + objects.add());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "4")
						{
							Console.Clear();
							Console.WriteLine("Difference of " + objects.n1 + " and " + objects.n2 + " is: " + objects.subtract());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "5")
						{
							Console.Clear();
							Console.WriteLine("Product of " + objects.n1 + " and " + objects.n2 + " is: " + objects.multiply());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "6")
						{
							if (objects.n2 == 0)
							{
								Console.WriteLine("Division by zero not possible");
								Console.ReadKey();
								continue;
							}
							Console.Clear();
							Console.WriteLine("Division of " + objects.n1 + " and " + objects.n2 + " is: " + objects.divide());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "7")
						{
							Console.Clear();
							Console.WriteLine("Modulo of " + objects.n1 + " and " + objects.n2 + " is: " + objects.mod());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "8")
						{
							Console.Clear();
							Console.WriteLine("Square root of: " + objects.sqrt());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "9")
						{
							Console.Clear();
							Console.WriteLine("Natural log of: " + objects.log());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "10")
						{
							Console.Clear();
							Console.WriteLine("Exponential function of: " + objects.exp());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "11")
						{
							Console.Clear();
							Console.WriteLine("Sine of: " + objects.sine());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "12")
						{
							Console.Clear();
							Console.WriteLine("Cosine of of: " + objects.cosine());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "13")
						{
							Console.Clear();
							if(objects.tan() > 100000000000000)
							{
								Console.Write("Tangent of: " + "Infinity");
								continue;
							}
							Console.WriteLine("Tangent of: " + objects.tan());
							Console.WriteLine("Enter any key to continue...");
							Console.ReadKey();
						}
						if (option == "14")
						{
							return;
						}
						if (option != "2" && option != "3" && option != "4" && option != "5" && option != "6" && option != "7" && option != "8" && option != "9" && option != "10" && option != "11" && option != "12" && option != "13" && option != "14")
						{
							Console.WriteLine("Enter a valid option");
						}
					}
				}
				else
				{
					Console.WriteLine("Create an object first");
					Console.ReadKey();
					continue;
				}
			}
		}
		static void displayMenu()
		{
			Console.Clear();
			Console.SetCursorPosition(25, 6);
			Console.Write("Welcome to calculator");
			Console.SetCursorPosition(20, 7);
			Console.Write("1-  Create single object of a calculator");
			Console.SetCursorPosition(20, 8);
			Console.Write("2-  Change values of attributes");
			Console.SetCursorPosition(20, 9);
			Console.Write("3-  Add");
			Console.SetCursorPosition(20, 10);
			Console.Write("4-  Subtract");
			Console.SetCursorPosition(20, 11);
			Console.Write("5-  Multiply");
			Console.SetCursorPosition(20, 12);
			Console.Write("6-  Divide");
			Console.SetCursorPosition(20, 13);
			Console.Write("7-  Modulo");
			Console.SetCursorPosition(20, 14);
			Console.Write("8-  Square Root");
			Console.SetCursorPosition(20, 15);
			Console.Write("9-  Log");
			Console.SetCursorPosition(20, 16);
			Console.Write("10-  exponent");
			Console.SetCursorPosition(20, 17);
			Console.Write("11-  sine");
			Console.SetCursorPosition(20, 18);
			Console.Write("12-  cosine");
			Console.SetCursorPosition(20, 19);
			Console.Write("13-  tan");
			Console.SetCursorPosition(20, 20);
			Console.Write("14-  Exit");
			Console.SetCursorPosition(20, 22);
			Console.Write("Enter your option...");
		}
	}
}
