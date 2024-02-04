using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculator
{
	internal class calculator
	{
		public calculator(float n1, float n2, float scientific_operand)
		{
			this.n1 = n1;
			this.n2 = n2;
			this.scientific_operand = scientific_operand;
		}
		public float n1;
		public float n2;
		public float scientific_operand;

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

	public double sqrt()
	{
			return Math.Sqrt(scientific_operand); 
	}

	public double log()
	{
			return Math.Log(scientific_operand);
	}

	public double sine()
		{
			return Math.Sin(scientific_operand*(Math.PI/180.0F));
		}

	public double cosine()
		{ 
			return Math.Cos(scientific_operand * (Math.PI / 180.0F));
		}

		public double tan()
		{
			return Math.Tan(scientific_operand * (Math.PI / 180.0F));
		}

		public double exp()
		{
			return Math.Exp(scientific_operand);
		}

	public void changeAttributes()
	{
		Console.SetCursorPosition(20, 6);
		Console.Write("Enter number 1: ");
		n1 = float.Parse(Console.ReadLine());
		Console.SetCursorPosition(20, 7);
		Console.Write("Enter number 2: ");
		n2 = float.Parse(Console.ReadLine());
		Console.Write("Enter scientific operand: ");
		scientific_operand = float.Parse(Console.ReadLine());
		}
}
}
