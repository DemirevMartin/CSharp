using System;
namespace RentACar
{
	public interface IRentalCar
	{
		void ShowModel();
		void ShowFuel();
		string HasDriver();
		int CalcNumberOfDays();
		double CalcAmount();
		double CalcTotal();
	}
	public class Opel : IRentalCar
	{
		string model, fuel;
		bool isDriver;
		DateTime startDate, endDate;
		double price24;
		public Opel(string m, string f, bool isDr, DateTime start, DateTime end, double price)
		{
			model = m;
			fuel = f;
			isDriver = isDr;
			startDate = start;
			endDate = end;
			price24 = price;
		}
		public void ShowModel()
		{
			Console.WriteLine("Модел: {0}", model);
		}
		public void ShowFuel()
		{
			Console.WriteLine("Гориво: {0}", fuel);
		}
		public string HasDriver()
		{
			if(isDriver)
			{
				return "Да";
			}
			else
			{
				return "Не";
			}
		}
		public int CalcNumberOfDays()
		{
			return (endDate - startDate).Days;
		}
		public double CalcAmount()
		{
			return price24 * CalcNumberOfDays();
		}
		public double CalcTotal()
		{
			if(isDriver)
			{
				return CalcAmount() + CalcNumberOfDays() * 15;
			}
			else 
			{
				return CalcAmount();
			}
		}
		public virtual void Print()
		{
			ShowModel();
			ShowFuel();
			Console.WriteLine("Шофьор: {0}", HasDriver());
			Console.WriteLine("Дата на наемане: {0:d.M.yyyy}", startDate);
			Console.WriteLine("Дата на връщане: {0:d.M.yyyy}", endDate);
			Console.WriteLine("Брой дни на наемане на автомобила: {0}", CalcNumberOfDays());
			Console.WriteLine("Дължима сума: {0} лв.", CalcAmount().ToString("F2"));
			Console.WriteLine("Обща сума: {0} лв.", CalcTotal().ToString("F2"));
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Автомобили \"Опел\" под наем");
			Console.WriteLine(new String('-', 26));
			Opel op1 = new Opel("Корса", "дизел", true, new DateTime(2020, 7, 5), new DateTime(2020, 7, 10), 25);
			op1.Print();
			Console.WriteLine("");
            Opel op2 = new Opel("Вектра", "газ", false, new DateTime(2020, 7, 2), new DateTime(2020, 7, 15), 20);
            op2.Print();
			Console.ReadKey(true);
		}
	}
}