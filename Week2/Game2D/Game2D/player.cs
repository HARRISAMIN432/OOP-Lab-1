using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2D
{
	internal class player
	{
		public player(int pX, int pY, char[,] player2D)
		{
			X = pX;
			Y = pY;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					Console.SetCursorPosition(Y + j, X + i);
					Console.Write(player2D[i, j]);
				}
			}
		}
		public int X;
		public int Y;
	}
}
