using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;

namespace Task01.DataLayer
{
	internal class DegreeProgramCRUD
	{
		public static List<DegreeProgram> DegreePrograms = new List<DegreeProgram>();
		public static void AddData(DegreeProgram obj)
		{
			DegreePrograms.Add(obj);
		}

		public static void ShowPrograms()
		{
			foreach (var i in DegreePrograms)
				Console.WriteLine(i.Degree);
		}

		public static bool Exists(string Program)
		{
			foreach (var i in DegreePrograms)
				if (Program == i.Degree)
					return true;
			return false;
		}

		public static DegreeProgram SearchDegreeProgram(string s)
		{
			foreach (var i in DegreePrograms)
				if (s == i.Degree)
					return i;
			return DegreePrograms[0];
		}

			public static void WriteDegreeFile(DegreeProgram obj)
			{
				StreamWriter file = new StreamWriter("D:\\OOP\\Week4\\Task01\\Task01\\Degree.txt", false);
				file.Write(obj.Degree + "," + obj.Duration + "," + obj.Seats);
				for (int i = 0; i < obj.SubjectList.Count() - 1; i++)
				{
					file.Write("," + obj.SubjectList[i].SubjectType + ";");
				}
				file.Write(obj.SubjectList[obj.SubjectList.Count() - 1].SubjectType);
				file.Write("\n");
				file.Close();
			}

		public static void WriteSubjectFile(Subject obj, DegreeProgram objects)
		{
			StreamWriter file = new StreamWriter("D:\\OOP\\Week4\\Task01\\Task01\\Subject.txt", false);
			file.WriteLine(obj.SubjectType + "," + obj.Code + "," + obj.CreditHours + "," + obj.SubjectFees);
			file.Close();
		}

			public static void ReadDegreeFile()
			{
				StreamReader file = new StreamReader("D:\\OOP\\Week4\\Task01\\Task01\\Degree.txt");
				string record;
				while ((record = file.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split(',');
					string Degree = splittedRecord[0];
					string Duration = splittedRecord[1];
					int Seats = int.Parse(splittedRecord[2]);
					string Subjects = splittedRecord[3];
					DegreeProgram obj = new DegreeProgram(Degree, Duration, Seats);
					string[] splittedSubjects = Subjects.Split(';');
					for(int i = 0; i < splittedSubjects.Count(); i++)
					{
					string Type = splittedSubjects[i];
					string Code = splittedRecord[i];
					int CH = int.Parse(splittedRecord[2]);
					int Fees = int.Parse(splittedRecord[3]);
					Subject o = new Subject(Code, CH, Type, Fees);
					}
				DegreePrograms.Add(obj);
				}
			}
	}
}

