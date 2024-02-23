using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
	internal class Book
	{
		public Book(int copies)
		{
			this.copies = copies;
		}
		public string title;
		public List<string> author;
		public int publisher;
		public string ISBN;
		public int price;
		public int copies;

		public void showTitle()
		{
			Console.WriteLine("The title of book with ISBN number is: " + title);
		}

		public void setTitle()
		{
			Console.WriteLine("Enter the title of the book: ");
			title = Console.ReadLine();
		}

		public void setCopies()
		{
			Console.WriteLine("Enter the number of copies: ");
			copies = int.Parse(Console.ReadLine());
		}

		public void showCopies()
		{
			Console.WriteLine("Total copies: " + copies);
		}

		public void publishers()
		{
			Console.WriteLine("The publisher of book with title " + " is: " + publisher);
		}

		public void isbn()
		{
			Console.WriteLine("The ISBN number of book with title " + " is: " + ISBN);
		}

		public void changePrice()
		{
			Console.WriteLine("Enter the price of book: ");
			price = int.Parse(Console.ReadLine());
		}

		public void authorName()
		{
			Console.WriteLine("The authors of book with title " + title + " are: " + author);
		}
	}
}
