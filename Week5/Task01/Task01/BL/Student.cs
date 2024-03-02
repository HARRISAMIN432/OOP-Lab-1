using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.DataLayer;

namespace Task01.BL
{
	internal class Student
	{
		public Student(string n, int a, double f, double e)
		{
			Name = n;
			Age = a;
			Fsc = f;
			Ecat = e;
		}

		public string Name;
		public int Age;
		public double Fsc;
		public double Ecat;
		public double Merit;
		public List<DegreeProgram> StudentPreferences = new List<DegreeProgram>();
		public List<Subject> SubjectList = new List<Subject>();
		public DegreeProgram registered;
		public int CreditHours()
		{
			int CreditHoursCalculator = 0;
			foreach(var i in SubjectList)
			{
				CreditHoursCalculator += i.CreditHours;
			}
			return CreditHoursCalculator;
		}

		public void RegisterSubjects(Subject s)
		{
			SubjectList.Add(s);
		}

		public int CalculateFees()
		{
			int Fees = 0;
			foreach (var i in SubjectList)
				Fees += i.SubjectFees;
			return Fees;
		}

		public void CalculateMerit()
		{
			Merit = 0;
			Merit += (Fsc / 1100 * 30) + (Ecat / 1100 * 60); 
		}

		public void AddProgramToList(string Program)
		{
			foreach (var i in DegreeProgramCRUD.DegreePrograms)
				if (Program == i.Degree)
					StudentPreferences.Add(i);
		} 

		public int GenerateFees()
		{
			int Fees = 0;
			foreach(var i in SubjectList)
			{
				Fees += i.SubjectFees;
			}
			return Fees;
		}
	}
}
