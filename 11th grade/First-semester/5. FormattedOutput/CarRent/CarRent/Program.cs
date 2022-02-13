using System;
namespace CarRent
{
	class CarRental
	{
		private string model;
		private DateTime dateTake, dateReturn;
		private double price;
		
		public CarRental(string m, DateTime d1, DateTime d2, double p)
		{
			model=m;
			dateTake=d1;
			dateReturn=d2;
			price=p;
		}
		int DateDiff()
		{
			return (dateReturn-dateTake).Days;
		}
		double CalcSum()
		{
			return DateDiff()*price;
		}
		double CalcDiscount()
		{
			double discount;
			if(DateDiff()==2 || DateDiff()==3)
			{
				return discount=CalcSum()*5/100;
			}
			else if(DateDiff()==4 || DateDiff()==5 || DateDiff()==6)
			{
			    return discount=CalcSum()*10/100;	
			}
			else if(DateDiff()==7)
			{
			    return discount=CalcSum()*15/100;	
			}
			else
			{
			    return 0;
			}
		}
		public void PrintInfo()
		{
			double total=CalcSum()-CalcDiscount();
			Console.Write("Car rental information: {0}", model);
			Console.WriteLine();
			Console.WriteLine(new String('-',90));
			Console.WriteLine("{0, 11}{1, 15}{2, 18}{3, 12}{4, 19}{5, 12}", "Rental date", "Return date", "Number of days", "Sum", "Discount", "Total");
			Console.WriteLine("{0, 11:dd MMMM yyyy}{1, 15:dd MMMM yyyy}{2, 11}{3, 23:c2}{4, 16:c2}{5, 14:c2}", dateTake, dateReturn, DateDiff(), CalcSum(), CalcDiscount(),  total);
			Console.WriteLine(new String('-',90));
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			CarRental car=new CarRental("Mazda 6", new DateTime(2020, 5, 3), new DateTime(2020, 5, 8), 35);
			car.PrintInfo();
			
			Console.ReadKey(true);
		}
	}
}