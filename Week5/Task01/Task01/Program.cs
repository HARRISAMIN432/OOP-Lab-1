using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;
using Task01.DataLayer;
using Task01.UI;

namespace Task01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Clear();
				MenuUI.Header();
				string option = MenuUI.MainMenu();
				if (option == "1")
				{
					Console.Clear();
					Student obj = StudentUI.TakeUserInput();
					StudentDL.AddToList(obj);
					DegreeProgramUI.ShowPrograms();
					StudentUI.Preferences(obj);
					StudentDL.WriteStudentFile(obj);
					MenuUI.PressAnyKeyToContinue();
					Console.ReadKey();
				}
				if (option == "2")
				{
					Console.Clear();
					DegreeProgram obj = DegreeProgramUI.TakeUserInput();
					DegreeProgramCRUD.AddData(obj);
					DegreeProgramCRUD.WriteDegreeFile(obj);
					MenuUI.PressAnyKeyToContinue();
					Console.ReadKey();
				}
				if (option == "3")
				{
					Console.Clear();
					StudentDL.AdmissionOnMerit();
					MenuUI.PressAnyKeyToContinue();
					Console.ReadKey();
				}
				if (option == "4")
				{
					Console.Clear();
					StudentUI.DisplayRegisteredStudents();
					Console.ReadKey();
				}
				if (option == "5")
				{
					Console.Clear();
					string degree = StudentUI.SearchStudentByDegree();
					StudentDL.NameOfStudent(degree);
					Console.ReadKey();
				}
				if (option == "6")
				{
					Console.Clear();
					StudentUI.NameOfStudent();
					Console.ReadKey();
				}
				if (option == "7")
				{
					Console.Clear();
					string name = StudentUI.EnterNameOfStudent();
					foreach (var i in StudentDL.StudentsList)
					{
						if (i.Name == name)
						{
							int Fees = i.CalculateFees();
							StudentUI.PrintFees(Fees);
							Console.ReadKey();
						}
						else
						{
							StudentUI.ErrorMessage();
							Console.ReadKey();
							continue;
						}
					}
					if (option == "8")
						return;
				}
			}
		}
	}
}
