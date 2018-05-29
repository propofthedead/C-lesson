using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson
{
	class Program
	{
		struct gamer
		{
			public string name;
			public int favnbr;
		}
		static void Main(string[] args)
		{
			int a = 23 * 37;
			int b = a - 41;
			string aStr = a.ToString();
			Console.WriteLine(b / 7);
			string fname = "Foster";
			int days = 6;
			Console.WriteLine("My name is " + fname + " I've been in bootcamp for " + days + " days");
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

			int[] frames = new int[10];
			frames[0] = 30;
			frames[1] = 17;
			frames[2] = 10;
			frames[3] = 15;
			frames[4] = 26;
			frames[5] = 7;
			frames[6] = 28;
			frames[7] = 20;
			frames[8] = 6;
			frames[9] = 4;
			int total = 0;
			for (int i = 0; i < 10; i++) {
				total = total + frames[i];
			}
			Console.WriteLine(total);
			string[] names = { "Greg", "Michael", "Dan", "Anna", "Marcus", "Foster", "Jermain", "Mitchell", "Jonathan", "Larry", "William" };
			foreach (string name in names) {
				Console.WriteLine("hi " + name);
			}
			string[] me = { "Foster Stulen", "Mason, OH", "camodude5@yahoo.com" };
			foreach (string stuff in me) {
				Console.WriteLine(stuff);
			};


	
			gamer ken;
			ken.name="ken";
			ken.favnbr=10;
			gamer nick;
			nick.name = "nick";
			nick.favnbr = 7;
			gamer[] gamers = { ken, nick };
			foreach (gamer grm in gamers) 
			{
				Console.WriteLine("{0} {1}", grm.name, grm.favnbr);
			}
		}
	}
}
