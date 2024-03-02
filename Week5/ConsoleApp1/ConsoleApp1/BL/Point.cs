using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
	internal class Point
	{
		public int X;
		public int Y;

		public Point()
		{
			X = 0;
			Y = 0;
		}

		public Point(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}

		public void SetXY(int x, int y)
		{
			X = x;
			Y = y;
		}


	}
}
