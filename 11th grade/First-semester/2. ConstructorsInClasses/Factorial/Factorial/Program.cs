/*
 * Created by SharpDevelop.
 * User: mega
 * Date: 1.10.2020 г.
 * Time: 7:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Numerics;

namespace Factorial
{
	class Fact
	{
		int x;
		public Fact()
		{
			x=3;
		}
		public Fact(int a)
		{
			x=a;
		}
		public int Value()
		{
			int f=1;
			for(int i=1;i<=x;i++)
			{
				f *= i;
			}
			return f;
		}
		public void PrintFact()
		{
			Console.WriteLine(x+"! = "+Value());
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Fact factorial1=new Fact();
			factorial1.PrintFact();
			Console.Write("Enter number: ");
			int c=Int32.Parse(Console.ReadLine());
			Fact frac=new Fact(c);
			frac.PrintFact();
			
			Console.ReadKey(true);
		}
	}
}