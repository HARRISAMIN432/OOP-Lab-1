using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;

namespace Task01.DataLayer
{
	internal class StudentDL
	{
		public static List<Student> StudentsList = new List<Student>();

		public static void AddToList(Student obj)
		{
			StudentsList.Add(obj);
		}

		public static void AdmissionOnMerit()
		{
			int SeatsCounterFirst = 0;
			int SeatsCounterSecond = 0;
			int SeatsCounterThird = 0;
			foreach(var i in StudentsList)
			{
				if (!(i.StudentPreferences[0].Seats == SeatsCounterFirst))
				{
					Console.WriteLine(i.Name + " have been admitted to " + i.StudentPreferences[0].Degree);
					i.registered = i.StudentPreferences[0];
					SeatsCounterFirst++;
				}
				else if (!(i.StudentPreferences[1].Seats == SeatsCounterSecond))
				{
					Console.WriteLine(i.Name + " have been admitted to " + i.StudentPreferences[1].Degree);
					i.registered = i.StudentPreferences[1];
					SeatsCounterSecond++;
				}
				else if (!(i.StudentPreferences[2].Seats == SeatsCounterThird))
				{
					Console.WriteLine(i.Name + " have been admitted to " + i.StudentPreferences[2].Degree);
					i.registered = i.StudentPreferences[2];
					SeatsCounterThird++;
				}
			}
		}

		public static void SortMeritList()
		{
			for(int i = 0; i < StudentsList.Count() - 1; i++)
			{
				if (StudentsList[i].Merit < StudentsList[i+1].Merit)
				{
					Student temp = StudentsList[i];
					StudentsList[i] = StudentsList[i + 1];
					StudentsList[i + 1] = temp;
				}
			}
		}

		public static void NameOfStudent(string degree)
		{
			foreach (var i in StudentDL.StudentsList)
			{
				if (i.registered.Degree == degree)
					Console.WriteLine(i.Name + "\t" + i.Age + "\t" + i.Fsc + "\t" + i.Ecat);
				else
				{
					Console.WriteLine("Not registered!");
					break;
				}
			}
		}

		public static void WriteStudentFile(Student obj)
		{
			StreamWriter file = new StreamWriter("D:\\OOP\\Week4\\Task01\\Task01\\Student.txt", false);
			file.Write(obj.Name + "," + obj.Age + "," + obj.Fsc + "," + obj.Ecat + "," + obj.Merit + "," + obj.registered.Degree);
			for(int i = 0; i < obj.StudentPreferences.Count() - 1; i++)
			{
				file.Write("," + obj.StudentPreferences[i].Degree + ";");
			}
			file.Write(obj.StudentPreferences[obj.StudentPreferences.Count() - 1].Degree);
			file.Write("\n");
			file.Close();
		}

		public static void ReadStudentFile()
		{
			StreamReader file = new StreamReader("D:\\OOP\\Week4\\Task01\\Task01\\Student.txt");
			string record;
			while((record = file.ReadLine()) != null)
			{
				string[] splittedRecord = record.Split(',');
				string name = splittedRecord[0];
				int Age = int.Parse(splittedRecord[1]);
				int Fsc = int.Parse(splittedRecord[2]);
				int Ecat = int.Parse(splittedRecord[3]);
				Student obj = new Student(name, Age, Fsc, Ecat);
				obj.Merit = double.Parse(splittedRecord[4]);
				obj.registered.Degree = splittedRecord[5];
				string DegreePreferences = splittedRecord[6];
				string[] splittedDegrees = DegreePreferences.Split(';');
				for(int i = 0; i < splittedDegrees.Count(); i++)
				{
					foreach(var j in DegreeProgramCRUD.DegreePrograms)
					{
						if (splittedDegrees[i] == j.Degree)
							obj.StudentPreferences.Add(j);
					}
				}
			}
		}
	}
}
