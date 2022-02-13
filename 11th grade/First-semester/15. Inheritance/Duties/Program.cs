using System;
namespace Cars
{
	public class Car
	{
		string model;
		double price;
		protected int volumeEngine;
		public Car(string m, double pr, int volume)
		{
			model = m;
			price = pr;
			volumeEngine = volume;
		}
		public virtual double CalcDuty()
		{
			return price;
		}
		public virtual void PrintInfo()
		{
			Console.WriteLine("Модел: {0}", model);
			Console.WriteLine("Обем на двигателя: {0} к.с.", volumeEngine);
			Console.WriteLine("Цена (лв): {0:0.00}", price);
		}
	}
	public class CarFromGermany : Car
	{
		public CarFromGermany(string model, double price, int volumeEngine)
			: base (model, price, volumeEngine)
		{
			Console.WriteLine("Държава производител: Германия");
		}
		public override double CalcDuty() 
		{
			if(volumeEngine >= 0 && volumeEngine <=1000)
			{
				return (base.CalcDuty() + 550)*15/100;
			}
			else if(volumeEngine >= 1001 && volumeEngine <=3000)
			{
				return (base.CalcDuty() + 550)*20/100;
			}
			else if(volumeEngine>=3001)
			{
				return (base.CalcDuty() + 550)*25/100;
			}
			else 
			{
				return 0;
			}
		}
		public override void PrintInfo()
		{
			Console.WriteLine("Марка: Golf");
			base.PrintInfo();
			Console.WriteLine(new String('-', 30));
			Console.WriteLine("Мито (лв): {0}", CalcDuty().ToString("F2"));
		}
	}
	class CarFromFrance : Car
	{
		public CarFromFrance(string model, double price, int volumeEngine)
			: base (model, price, volumeEngine)
		{
			Console.WriteLine("Държава производител: Франция");
		}
		public override double CalcDuty()
		{
			if(volumeEngine >= 0 && volumeEngine <=1000)
			{
				return (base.CalcDuty() + 600)*15/100;
			}
			else if(volumeEngine >= 1001 && volumeEngine <=3000)
			{
				return (base.CalcDuty() + 600)*20/100;
			}
			else if(volumeEngine>=3001)
			{
				return (base.CalcDuty() + 600)*25/100;
			}
			else 
			{
				return 0;
			}
		}
		public override void PrintInfo()
		{
			Console.WriteLine("Марка: Renault");
			base.PrintInfo();
			Console.WriteLine(new String('-', 30));
			Console.WriteLine("Мито (лв): {0}", CalcDuty().ToString("F2"));
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			CarFromGermany cg = new CarFromGermany("VW", 28000, 1800);
			cg.PrintInfo();
			Console.WriteLine("");
            CarFromFrance cf = new CarFromFrance("Clio", 12000, 1300);
            cf.PrintInfo();
            Console.WriteLine(". . .");
			Console.ReadKey(true);
		}
	}
}