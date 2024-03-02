using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.BL
{
	internal class DegreeProgram
	{
		public DegreeProgram(string Degree, string Duration, int Seats)
		{
			this.Degree = Degree;
			this.Duration = Duration;
			this.Seats = Seats;
		}
		public int Seats;
		public string Degree;
		public string Duration;
		public List<Subject> SubjectList = new List<Subject>();
		public static List<DegreeProgram> ProgramList = new List<DegreeProgram>();

		public bool DoesSubjectExists(string Subject)
		{
			foreach(var i in SubjectList)
			{
				if (i.SubjectType == Subject)
					return false;
			}
			return false;
		}

	}
}
