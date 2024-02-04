using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
	internal class Class
	{
		public string title;
		public string author;
		public string publicationYear;
		public string price;
		public int quantityInStock;

		public string getTitle()
		{
			return "Title + {title}";
		}

		public string getAuthor()
		{
			return "Author + {author}";
		}

		public string getPublicationYear()
		{
			return "Publication Year: {publicationYear}";
		}

		public string prices()
		{
			return "Price: {price}";
		}

		public string bookDetails()
		{
			return "Title: {title}\n Author: {author}\n Publication Year: {publicationYear}\n Price: {price}\n Quantity In Stock: {quantityInStock}";
		}

		public void sellCopies(int numberCopies)
		{
			if(numberCopies < quantityInStock)
			{
				Console.WriteLine("Not enough stock");
			}
			quantityInStock -= numberCopies;
		}

		public void reStock(int additionalCopies)
		{
			quantityInStock += additionalCopies;
			Console.WriteLine("Copies added to stock!");
		}

		public void takeInput()
		{
			Console.Write("Enter the title of the book: ");
			title = Console.ReadLine();
			Console.Write("Enter the author of the book: ");
			author = Console.ReadLine();
			Console.Write("Enter the publication year of the book: ");
			publicationYear = Console.ReadLine();
			Console.Write("Price: ");
			price = Console.ReadLine();
			Console.Write("quantity: ");
			quantityInStock = int.Parse(Console.ReadLine());
		}
	}
}
