using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;
using Task01.DataLayer;

namespace Task01.UI
{
	internal class StudentUI
	{
		public static Student TakeUserInput()
		{
			Console.Write("Enter Student Name: ");
			string Name = Console.ReadLine();
			Console.Write("Enter Student age: ");
			int Age = int.Parse(Console.ReadLine());
			Console.Write("Enter FSC marks: ");
			double Fsc = double.Parse(Console.ReadLine());
			Console.Write("Enter ECAT marks: ");
			double Ecat = double.Parse(Console.ReadLine());
			Student Obj = new Student(Name, Age, Fsc, Ecat);
			Obj.CalculateMerit();
			return Obj;
		}

		public static void Preferences(Student obj)
		{
			int n ;
			Console.Write("Enter the number of preferences: ");
			n = int.Parse(Console.ReadLine());
			while (n > DegreeProgramCRUD.DegreePrograms.Count())
			{
				Console.WriteLine("We do not have so much programs");
				Console.Write("Enter the number of preferences: ");
				n = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < n; i++)
			{
				Console.Write("Enter name of " + (i+1) + " program: ");
				string program = Console.ReadLine();
				if (DegreeProgramCRUD.Exists(program))
				{
					obj.AddProgramToList(program);
					continue;
				}
				Console.WriteLine("Does not exist");
				i--;
			}
		}

		public static void DisplayRegisteredStudents()
		{
			Console.WriteLine("Name\tAge\tFSC\tMatric");
			foreach (var i in StudentDL.StudentsList)
			{
				if (i.registered.Degree != "")
				{
					Console.WriteLine(i.Name + "\t" + i.Age + "\t" + i.Fsc + "\t" + i.Ecat);
				}
			}
		}

		public static string SearchStudentByDegree()
		{
			Console.Write("Enter name of degree: ");
			string degree = Console.ReadLine();
			Console.WriteLine("Name\tAge\tFSC\tMatric");
			return degree;
		}

		public static void NameOfStudent()
		{
			Console.Write("Enter the name of student who wants to register subjects: ");
			string name = Console.ReadLine();
			int CreditHours = 0;
			foreach (var i in StudentDL.StudentsList)
			{
				if (name == i.Name)
				{
					DegreeProgram obj = DegreeProgramCRUD.SearchDegreeProgram(i.registered.Degree);
					while (CreditHours <= 9)
					{
						Console.WriteLine("Enter the name of subject: ");
						string s = Console.ReadLine();
						if (obj.DoesSubjectExists(s))
						{
							foreach (var j in i.SubjectList)
								if (s == j.SubjectType)
								{
									i.SubjectList.Add(j);
									CreditHours += j.CreditHours;
								}
						}
						else
						{
							DegreeProgramUI.ErrorSubject();
							break;
						}
					}
				}
				else
				{
					ErrorMessage();
					break;
				}
			}
		}
		public static void PrintFees(int Fees)
		{
			Console.WriteLine("Total Fees " + Fees);
		}

		public static string EnterNameOfStudent()
		{
			Console.WriteLine("Enter name of student");
			string name = Console.ReadLine();
			return name;
		}

		public static void ErrorMessage()
		{
			Console.WriteLine("No student of this name exists: ");
		}
	}
}
	
