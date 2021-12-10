using System;
namespace ArrayRearrangement
{
	class ArrRearrangement
	{
		double[] a;
		public ArrRearrangement(int n)
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
		public void ShowArray()
		{
			Console.WriteLine(new String('-', 70));
			for(int i = 0; i < a.Length / 2; i++)
			{
				Console.Write(a[i] + "  ");
				Console.Write(a[a.Length - i - 1] + "  ");
			}
			if(a.Length % 2 != 0) { Console.WriteLine(a[(a.Length / 2)]) ; }
			Console.WriteLine();
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			ArrRearrangement m = new ArrRearrangement(int.Parse(Console.ReadLine()));
			m.ShowArray();
			Console.ReadKey(true);
		}
	}
}