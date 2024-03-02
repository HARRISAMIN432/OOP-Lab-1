using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
	internal class GameObject
	{
		public char[,] Shape;
		public Point StartingPoint;
		public Boundary Premises;
		public string Direction;

		public GameObject()
		{
			Shape = new char[,] { { '-', '-', '-' } };
			StartingPoint = new Point();
			Premises = new Boundary();
			Direction = "LeftToRight";
		}

		public GameObject(char[,] Shape, Point StartingPoint, string Direction, Boundary Premises)
		{
			this.Shape = Shape;
			this.StartingPoint = StartingPoint;
			this.Premises = Premises;
			this.Direction = Direction;
		}

		public GameObject(char[,] Shape, Point StartingPoint)
		{
			this.Shape = Shape;
			this.StartingPoint = StartingPoint;
			Premises = new Boundary();
			Direction = "LeftToRight";
		}

		public void Move()
		{
			if (Direction == "LeftToRight" && Premises.BottomRight.Y < 89)
				StartingPoint.Y++;
			if (Direction == "RightToLeft" && Premises.BottomLeft.Y > 1)
				StartingPoint.Y--;
			if (Direction == "Patrol")
				for (int i = 0; i < Premises.TopRight.Y; i++)
					if (StartingPoint.Y < Premises.TopRight.Y)
					{
						StartingPoint.Y++;
						Draw();
					}
			if (Direction == "Projectile")
			{
				for (int i = 0; i < 5; i++)
					if (StartingPoint.Y < Premises.TopRight.Y && StartingPoint.X > Premises.TopRight.X)
					{
						StartingPoint.SetXY(StartingPoint.Y++, StartingPoint.X--);
						Erase();
						Draw();
					}
				for (int i = 0; i < 2; i++)
					if (StartingPoint.Y < Premises.TopRight.Y)
					{
						StartingPoint.Y++;
						Erase();
						Draw();
					}
				for (int i = 0; i < 4; i++)
					if (StartingPoint.Y < Premises.TopRight.Y && StartingPoint.X > Premises.TopRight.X)
					{
						StartingPoint.SetXY(StartingPoint.Y++, StartingPoint.X++);
						Erase();
						Draw();
					}
				for(int i = 0; i < Premises.TopRight.Y; i++)
				{
					if(StartingPoint.Y < Premises.BottomRight.Y && StartingPoint.X > Premises.BottomRight.X)
					{
						StartingPoint.SetXY(StartingPoint.X--, StartingPoint.Y++);
						Erase();
						Draw();
					}
				}
			}
		}

		public void Erase()
		{
			for(int i = 0; i < Shape.GetLength(0); i++)
				for(int j = 0; j < Shape.GetLength(1); j++)
				{
				    Console.SetCursorPosition(StartingPoint.Y + j, StartingPoint.X + i);
				    Console.Write(' ');
				}
		}

		public void Draw()
		{
			for(int i = 0; i < Shape.GetLength(0); i++)
				for(int j = 0; j < Shape.GetLength(1); j++)
				{
					Console.SetCursorPosition(StartingPoint.Y + j, StartingPoint.X + i);
					Console.Write(Shape[i, j]);
				}
		}
	}
}
