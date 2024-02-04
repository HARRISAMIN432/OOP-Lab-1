using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiritori
{
	internal class Shiritori
	{
		public string[] groupOfWords = new string[100];
		public int counter = 0;
		public bool game_over = false;
		public void restart()
		{
			for (int i = 0; i < counter; i++)
			{
				groupOfWords[i] = "";
			}
		}

		public void play(string word)
		{
			for(int i = 0; i < counter; i++)
			{
				if(word == groupOfWords[counter])
				{
					Console.WriteLine("Invalid input...");
					Console.ReadKey();
					Console.Clear();
					Console.WriteLine("Game have been restarted");
					restart();
				}
			}
			groupOfWords[counter] = word;
			counter++;
		}
	}
}
