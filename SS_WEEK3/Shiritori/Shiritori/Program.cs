using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shiritori
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Shiritori game = new Shiritori();
			char lastLetter = ' ';
			string word;
			Console.SetCursorPosition(35, 6);
			while (true)
			{
				Console.Write("Shiritori");
				Console.SetCursorPosition(30, 10);
				Console.Write("Enter the starting word: ");
				word = Console.ReadLine();
				game.play(word);
				for (int i = 0; i < word.Length; i++)
				{
					lastLetter = word[i];
				}
				char startingLetter = lastLetter;
				while (startingLetter == lastLetter)
				{
					for (int i = 0; i < word.Length; i++)
					{
						lastLetter = word[i];
					}
					Console.Clear();
					Console.SetCursorPosition(30, 14);
					Console.Write("Enter the next word: ");
					word = Console.ReadLine();
					startingLetter = word[0];
					if (lastLetter != startingLetter)
					{
						Console.WriteLine("Invalid input");
						Console.ReadKey();
						game.restart();
						break;
					}
					game.play(word);
				}
			}
		}
	}
}
