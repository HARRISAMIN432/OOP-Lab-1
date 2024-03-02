using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.BL
{
	internal class Subject
	{
		public Subject(string c, int CH, string ST, int SF)
		{
			Code = c;
			CreditHours = CH;
			SubjectType = ST;
			SubjectFees = SF;
		}
		public string Code;
		public int CreditHours;
		public string SubjectType;
		public int SubjectFees;
	}
}
