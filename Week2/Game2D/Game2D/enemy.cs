using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2D
{
	internal class enemy
	{
		public enemy(int eX, int eY, char[,] enemy2D)
		{
			X = eX;
			Y = eY;
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.SetCursorPosition(eY + j, eX + i);
					Console.Write(enemy2D[i, j]);
				}
			}
		}
		public int X;
		public int Y;
	}
}
