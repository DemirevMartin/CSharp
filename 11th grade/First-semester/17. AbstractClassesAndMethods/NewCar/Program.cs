using System;
using System.Collections.Generic;
namespace NewCar
{
	abstract class Car
	{
		protected abstract double CalcDuty();
		protected abstract double CalcExcise();
		protected abstract double CalcVAT();
		protected abstract double CalcTotal();
		public abstract void PrintInfo();
	}
	class CarFromEU : Car
	{
		private string country, model;
		private int volumeEngine, powerEngine;
		private double price, transportCosts;
		public CarFromEU(string country, string model, int volumeEngine, int powerEngine, double price, double transportCosts)
		{
			this.country = country;
			this.model = model;
			this.volumeEngine = volumeEngine;
			this.powerEngine = powerEngine;
			this.price = price;
			this.transportCosts = transportCosts;
		}
		protected override double CalcDuty()
		{
			if(volumeEngine >= 0 && volumeEngine <= 1000)
			{
				return (price + transportCosts) * 15/100;
			}
			else if(volumeEngine >= 1001 && volumeEngine <= 3000)
			{
				return (price + transportCosts) * 20/100;
			}
			else if(volumeEngine >= 3001)
			{
				return (price + transportCosts) * 25/100;
			}
			else 
			{
				return 0;
			}
		}
		protected override double CalcExcise()
		{
			if(powerEngine > 164)
			{
				return (price * 40 / 100);
			}
			else
			{
				return 0;
			}
		}
		protected override double CalcVAT()
		{
			double total = price + transportCosts + CalcDuty();
			return (total * 20 / 100);
		}
		protected override double CalcTotal()
		{
			double totAL = CalcDuty() + CalcExcise() + CalcVAT() + price;
			return totAL;
		}
		public override void PrintInfo()
		{
			Console.WriteLine("Държава: {0}", country);
			Console.WriteLine("Модел: {0}", model);
			Console.WriteLine("Обем на двигателя: {0}", volumeEngine);
			Console.WriteLine("Мощност на двигателя: {0} к.с.", powerEngine);
			Console.WriteLine("Цена (лв): {0}", price.ToString("F2"));
			Console.WriteLine(new String('-', 30));
			Console.WriteLine("Мито (лв): {0}", CalcDuty().ToString("F2"));
			Console.WriteLine("Акциз (лв): {0}", CalcExcise().ToString("F2"));
			Console.WriteLine("ДДС (лв): {0}", CalcVAT().ToString("F2"));
			Console.WriteLine("Обща стойност (лв): {0}", CalcTotal().ToString("F2"));
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			CarFromEU myCar = new CarFromEU("Германия", "VW Golf", 1800, 170, 28000, 600);
			myCar.PrintInfo();
			Console.ReadKey(true);
		}
	}
}