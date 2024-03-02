using ConsoleApp1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char[,] Triangle = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
			char[,] OpTriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };
			Boundary b = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
			GameObject g1 = new GameObject(Triangle, new Point(5, 5), "LeftToRight", b);
			GameObject g2 = new GameObject(OpTriangle, new Point(30, 60), "RightToLeft", b);
			List<GameObject> lst = new List<GameObject>();
			lst.Add(g1);
			lst.Add(g2);
			while(true)
			{
				Thread.Sleep(2000);
				foreach(GameObject g in lst)
				{
					g.Erase();
					g.Move();
					g.Draw();
				}
			}
		}
	}
}
