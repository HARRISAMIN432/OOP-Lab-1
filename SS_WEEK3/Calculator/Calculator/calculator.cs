using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class calculator
	{
		public calculator(float n1, float n2)
		{
			this.n1 = n1;
			this.n2 = n2;
		}
		public float n1;
		public float n2;

		public float add()
		{
			return n1 + n2;
		}

		public float subtract()
		{
			return n1 - n2;
		}

		public float multiply()
		{
			return n1 * n2;
		}

		public float divide()
		{
			return n1 / n2;
		}

		public float mod()
		{
			return n1 % n2;
		}

		public void changeAttributes()
		{
			Console.SetCursorPosition(20, 6);
			Console.Write("Enter number 1: ");
			n1 = float.Parse(Console.ReadLine());
			Console.SetCursorPosition(20, 7);
			Console.Write("Enter number 2: ");
			n2 = float.Parse(Console.ReadLine());
		}
	}
}
