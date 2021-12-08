using System;
namespace Date2020
{
	class Date2020
	{
		private int month, day;
		
		public Date2020 (int m, int d)
		{
			month=m;
			day=d;
		}
		public int Month
		{
			get {return month;}
			set 
			{
				if(value>=1 && value<=12) month=value;
				else throw new ArgumentException();
			}
		}
		public int Day
		{
			get {return day;}
			set
			{
				if(month==2)
				{
					if(value>=1 && value<=29) day=value;
					else throw new ArgumentException();
				}
				else if(value==4 || value==6 || value==9 || value==11)
				{
					if(value>=1 && value<=30) day=value;
					else throw new ArgumentException();
				}
				else
				{
					if(value>=1 && value<=31) day=value;
					else throw new ArgumentException();
				}
			}
		}
		private int DaysLeft()
		{
			if(month==2)
			{
				return 29-day;
			}
			else if(month==4 || month==6 || month==9 || month==11)
			{
				return 30-day;
			}
			else 
			{
				return 31-day;
			}
		}
		private bool IsInTheSummer()
		{
			if(month==6 && day>=22)
			{
				return true;
			}
			else if(month==7 || month==8)
			{
				return true;
			}
			else if(month==9 && day<=22)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public void Print()
		{
			Console.WriteLine("Date: {0:D2}.{1:D2}.2020", day, month);
			Console.WriteLine("Remaining days in this month: {0}", DaysLeft());
			Console.Write("This date: ");
			if(IsInTheSummer()==true)
			{
				Console.WriteLine("is in the summer");
			}
			else
			{
				Console.WriteLine("is not in the summer");
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			int m;
			Date2020 date=new Date2020(9, 15);
			date.Print();
			Console.Write("Enter a month number: ");
			m=Convert.ToInt32(Console.ReadLine());
			date.Month=m;
			date.Day=3*m+5;
			date.Print();
			
			Console.ReadKey(true);
		}
	}
}