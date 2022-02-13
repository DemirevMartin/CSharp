using System;
namespace Workers
{
	public class Worker
	{
		string name;
		public Worker(string workerName)
		{
			name = workerName;
		}
		public virtual double WeeklyPay(int hoursWorked)
		{
			return 0;
		}
		public virtual string ToText()
		{
			return string.Format("Име на работника: {0}", name);
		}
	}
	class HourlyWorker : Worker
	{
		private double hourlyWage;
		public HourlyWorker(string name, double wage)
			: base (name)
		{
			hourlyWage = wage;
		}
		public override double WeeklyPay(int hoursWorked)
		{
			double salary = hoursWorked*hourlyWage;
			if(hoursWorked > 40)
			{
				return (salary + ((hoursWorked - 40)*  hourlyWage)/2)/10;
			}
			else 
			{
				return salary;
			}
		}
		public override string ToText()
		{
			Console.WriteLine(base.ToText());
			Console.WriteLine(new String('-', 33));
			Console.Write("Въведете заработените часове: ");
			int hours = int.Parse(Console.ReadLine());
			Console.WriteLine("Седмичното заплащане за {0} часа е {1:#.00} лева", hours, WeeklyPay(hours));
			return string.Format("");
		}
	}
	class SalariedWorker : Worker
	{
		private double annualSalary;
		public SalariedWorker(string name, double salary) 
			: base (name)
		{
			annualSalary = salary;
		}
		public override double WeeklyPay(int hoursWorked)
		{
			double wage = (annualSalary / 52);
			return wage;
		}
		public override string ToText()
		{
			Console.WriteLine(base.ToText());
			Console.WriteLine(new String('-', 33));
			Console.Write("Въведете годишна заплата: ");
			annualSalary = double.Parse(Console.ReadLine());
			Console.WriteLine("Седмичното заплащане за годишна заплата от {0} лева е {1} лева", annualSalary, WeeklyPay(1).ToString("F2"));
			return string.Format("");
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			HourlyWorker hw = new HourlyWorker("Долф Лундгрен", 300);
			hw.ToText();
			Console.WriteLine("");
			
            SalariedWorker sw = new SalariedWorker("Силвестър Сталоун", 0);
            sw.ToString();
			sw.ToText();
			Console.Write(". . . ");
			Console.ReadKey(true);
		}
	}
}