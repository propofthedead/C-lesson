using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson
{
	class Program
	{
		static void Main(string[] args)
		{
			int a=23*37;
			int b = a -41;
			string aStr = a.ToString();
			Console.WriteLine(b/7);
			string name = "Foster";
			int days = 6;
			Console.WriteLine("My name is " + name + " I've been in bootcamp for " + days + " days");
			int byear = 1997;
			int bmonth = 4;
			int bday = 8;
			int year = 2018;
			int month = 5;
			int day = 29;
			int years = year - byear;
			int dayss = (30 - bday) + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31;
			int dayyears = 31 + 28 + 31 + 30 + 29;
			int daysold = (years * 365) + dayss + dayyears;
			Console.WriteLine(daysold);
		}
	}
}
