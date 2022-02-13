/*
 * Created by SharpDevelop.
 * User: zlati
 * Date: 4.11.2020 г.
 * Time: 08:25 ч.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Money
{
	class Banknotes
	{
		int total, billsOf5, billsOf10, billsOf20;
		public Banknotes()
		{
			SortAndCount();
		}
		private void SortAndCount()
		{
			int a, sum = 0;
			do
			{
				Console.Write("Въведи стойността на поредната банкнота - 5, 10, 20 или 0 за край: ");
				a = int.Parse(Console.ReadLine());
				sum+=a;
				if(a==5)
				{
					billsOf5++;
					total++;
				}
				else if(a==10)
				{
					billsOf10++;
					total++;
				}
				else if(a==20)
				{
					billsOf20++;
					total++;
				}
			}
			while (a!=0);
			
		}
		public void Print()
	    {
		    Console.WriteLine("Справка за наличността");	
		    Console.WriteLine("Банкноти от 5 лв.: {0} броя", billsOf5);
		    Console.WriteLine("Банкноти от 10 лв.: {0} броя", billsOf10);
		    Console.WriteLine("Банкноти от 20 лв.: {0} броя", billsOf20);
		    Console.WriteLine("Общо: {0} банкноти на стойност {1} лв.", total, billsOf5*5 + billsOf10*10 + billsOf20*20);
	    }
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Banknotes bank=new Banknotes();
			bank.Print();
			
			Console.ReadKey(true);
		}
	}
}