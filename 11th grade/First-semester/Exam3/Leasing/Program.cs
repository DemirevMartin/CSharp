using System;
namespace Stock
{
	public class Stock
	{
		string brand;
		double price;
		protected int numberOfDeposits;
		public Stock(string br, double pr, int deposits)
		{
			brand = br;
			price = pr;
			numberOfDeposits = deposits;
		}
		public virtual double MonthlyPayment()
		{
			return price / numberOfDeposits;
		}
		public virtual void PrintLeasing()
		{
			Console.WriteLine("Марка: {0}", brand);
			Console.WriteLine("Цена (лв.): {0:f2}", price);
			Console.WriteLine("Брой вноски: {0}", numberOfDeposits);
		}
	}
	class Refrigerator : Stock
	{
		public Refrigerator(string brand, double price, int numberOfDeposits)
			: base(brand, price, numberOfDeposits)
		{
			Console.WriteLine("Артикул: Хладилник");
		}
		public override double MonthlyPayment()
		{
			double total = (base.MonthlyPayment()) + (base.MonthlyPayment()*1676/10000);
			return total;
		}
		public override void PrintLeasing()
		{
			base.PrintLeasing();
			Console.WriteLine("Име на лизинговата схема: Jet Credit 12");
			Console.WriteLine(new String('-', 40));
			Console.WriteLine("Месечна вноска: {0} лв.", MonthlyPayment().ToString("F2"));
			Console.WriteLine("Крайна сума: {0} лв.", (MonthlyPayment()*numberOfDeposits).ToString("F2"));
		}
	}
	class Freezer : Stock
	{
		public Freezer(string brand, double price, int numberOfDeposits)
			: base(brand, price, numberOfDeposits)
		{
			Console.WriteLine("Артикул: Фризер");
		}
		public override double MonthlyPayment()
		{
			double total = (base.MonthlyPayment()) + (base.MonthlyPayment()*10/100);
			return total;
		}
		public override void PrintLeasing()
		{
			base.PrintLeasing();
			Console.WriteLine("Име на лизинговата схема: Euroline 6");
			Console.WriteLine(new String('-', 40));
			Console.WriteLine("Месечна вноска: {0} лв.", MonthlyPayment().ToString("F2"));
			Console.WriteLine("Крайна сума: {0} лв.", (MonthlyPayment()*numberOfDeposits).ToString("F2"));
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Refrigerator r = new Refrigerator("Beko", 395, 12);
			r.PrintLeasing();
			Console.WriteLine("");
			Freezer f = new Freezer("Sang", 600, 6);
			f.PrintLeasing();
			Console.Write(". . .");
			Console.ReadKey(true);
		}
	}
}