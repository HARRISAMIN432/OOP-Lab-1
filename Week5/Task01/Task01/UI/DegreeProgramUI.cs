using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;
using Task01.DataLayer;

namespace Task01.UI
{
	internal class DegreeProgramUI
	{
		public static void ShowPrograms()
		{
			foreach (var Programs in DegreeProgramCRUD.DegreePrograms)
				Console.WriteLine(Programs.Degree);
		}

		public static DegreeProgram TakeUserInput()
		{
			Console.Write("Enter degree name: ");
			string Degree = Console.ReadLine();
			Console.Write("Enter Degree duration: ");
			string Duration = Console.ReadLine();
			Console.Write("Enter seats for degree: ");
			int Seats = int.Parse(Console.ReadLine());
			DegreeProgram Obj = new DegreeProgram(Degree, Duration, Seats);
			Console.Write("Enter number of subjects: ");
			int s = int.Parse(Console.ReadLine());
			for(int i = 0; i < s; i++)
			{
				Console.Write("Enter subject type: ");
				string type = Console.ReadLine();
				Console.Write("Enter subject code: ");
				string code = Console.ReadLine();
				Console.Write("Enter credit hours: ");
				int CH = int.Parse(Console.ReadLine());
				Console.Write("Enter Subject Fees: ");
				int Fees = int.Parse(Console.ReadLine());
				Subject obj = new Subject(code, CH, type, Fees);
				Obj.SubjectList.Add(obj);
				Console.WriteLine("\n");
			}
			return Obj;
		}

		public static void ErrorDegree()
		{
			Console.WriteLine("No degree of this name exists");
		}

		public static void ErrorSubject()
		{
			Console.WriteLine("No Subject of this name exists");
		}
	}
}
