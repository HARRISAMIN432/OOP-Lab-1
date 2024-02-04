using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int counter = 0;
			string option;
			List<Class> books = new List<Class>();
			while (true)
			{
				menu();
				option = Console.ReadLine();
				if (option == "1")
				{
					Console.Clear();
					Class objects = new Class();
					objects.takeInput();
					books.Add(objects);
					Console.WriteLine("A book object has been created");
					Console.ReadKey();
					counter++;
				}
				if (option == "2")
				{
					Console.Clear();
					foreach (var i in books)
					{
						Console.WriteLine(i.title + "\t" + i.author + "\t" + i.publicationYear + "\t" + i.price + "\t" + i.quantityInStock + "\n");
					}
					Console.ReadKey();
				}
				if(option == "3")
				{
					Console.Clear();
					Console.Write("Enter the title of the book: ");
					string title = Console.ReadLine();
					for(int i = 0; i < counter; i++)
					{
						if (books[i].title == title)
						{
							Console.WriteLine("The author: " + books[i].author);
						}
						else
						{
							Console.WriteLine("Book not found!");
						}
					}
					Console.ReadKey();
				}
				if(option == "4")
				{
					Console.Clear();
					Console.WriteLine("Enter the title of the book you want to sell copies: ");
					string title = Console.ReadLine();
					Console.WriteLine("Enter the number of copies you want to sold: ");
					int copies = int.Parse(Console.ReadLine());
					for (int i = 0; i < counter; i++)
					{
						if (books[i].title == title)
						{
							Console.WriteLine("The copies sold are: " + copies);
							books[i].quantityInStock -= copies;
						}
						else
						{
							Console.WriteLine("Book not found!");
						}
					}
					Console.ReadKey();
				}
				if(option == "5")
				{
					Console.Clear();
					Console.WriteLine("Enter the title of the book you want to restock: ");
					string title = Console.ReadLine();
					Console.WriteLine("Enter the number of copies you want to restock: ");
					int copies = int.Parse(Console.ReadLine());
					for (int i = 0; i < counter; i++)
					{
						if (books[i].title == title)
						{
							Console.WriteLine("The copies sold are: " + copies);
							books[i].quantityInStock += copies;
						}
						else
						{
							Console.WriteLine("Book not found!");
						}
					}
					Console.ReadKey();
				}
				if(option == "6")
				{
					Console.WriteLine("The total number of books are: " + counter);
					Console.ReadKey();
				}
				if(option == "7")
				{
					return;
				}
			}
		}

		static void menu()
		{
			Console.Clear();
			Console.SetCursorPosition(30, 4);
			Console.Write("1-  Add Book");
			Console.SetCursorPosition(30, 5);
			Console.Write("2-  View all information");
			Console.SetCursorPosition(30, 6);
			Console.Write("3-  Author details");
			Console.SetCursorPosition(30, 7);
			Console.Write("4-  Sell Copies");
			Console.SetCursorPosition(30, 8);
			Console.Write("5-  Restock copies");
			Console.SetCursorPosition(30, 9);
			Console.Write("6-  Count books");
			Console.SetCursorPosition(30, 10);
			Console.Write("7-  Exit");
			Console.SetCursorPosition(30, 12);
			Console.Write("Enter the option...");
		}
	}
}
