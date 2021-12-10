using System;

namespace EvenOddPositions
{
	class EvenOdd
	{
		double[] a;
		public EvenOdd(int n)
		{
			a = new double[n];
			Read();
		}
		void Read()
		{
			Console.WriteLine("Въведете последователно реални числа, като след всяко натискате Enter!");
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write("Въведете  {0}. число: ", i+1);
				a[i] = Convert.ToDouble(Console.ReadLine());
			}
		}
		void FindEven()
		{
			for (int i = 1; i < a.Length; i+=2)
			{
				Console.Write(a[i] + "  ");
			}
		}
		void FindOdd()
		{
			for (int i = 0; i < a.Length; i+=2)
			{
				Console.Write(a[i] + "  ");
			}
		}
		public void Print()
		{
			Console.WriteLine(new String('-', 60));
			FindEven();
			FindOdd();
			Console.WriteLine();
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			EvenOdd m = new EvenOdd(int.Parse(Console.ReadLine()));
			m.Print();
			
			Console.ReadKey(true);
		}
	}
}