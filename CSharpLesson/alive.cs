using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson
{
	class alive
	{
		static void main(string[] args)
		{
			int byear = 1997;
			int bmonth = 4;
			int bday = 8;
			int year = 2018;
			int month = 5;
			int day = 29;
			int years = year - byear;
			int days = (30 - bday) + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31;
			int dayyears = 31 + 28 + 31 + 30 + 29;
			int daysold = (years * 365) + day + dayyears;
			Console.WriteLine(daysold);
		}
	}
}
