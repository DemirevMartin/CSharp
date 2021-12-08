/*
 * Created by SharpDevelop.
 * User: User
 * Date: 12.10.2020 г.
 * Time: 15:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Medicaments
{
	class Medicament
	{
		private int year, month, day, days;
		
		public Medicament(int y, int m, int d, int ds)
		{
			year=y;
			month=m;
			day=d;
			days=ds;
		}
		public DateTime CalcExpirationDate()
		{
		 	DateTime dt = new DateTime(year, month, day);
		 	return dt.AddDays(days);
		}
		public void Evaluation()
		{
			if(DateTime.Today<CalcExpirationDate())
			{
				Console.WriteLine("Suitable");
			}
			else{
				Console.WriteLine("Unsuitable");
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.Write("Enter year of production: ");
			int zear = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter month of production: ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter day of production: ");
			int t = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter expiration date (days): ");
			int exp = Convert.ToInt32(Console.ReadLine());
			Medicament med=new Medicament(zear, n, t, exp);
			Console.WriteLine("Exp: "+ med.CalcExpirationDate().ToString("dd MMMM yy"));
			med.Evaluation();
			
			Console.ReadKey(true);
		}
	}
}