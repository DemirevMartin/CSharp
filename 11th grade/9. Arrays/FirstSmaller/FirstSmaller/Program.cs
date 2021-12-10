using System;
namespace FirstSmaller
{
	class FirstSmaller
	{
		int[] a;
		public FirstSmaller()
		{
			a = new int[10];
			Read();
		}
		void Read()
		{
			Console.WriteLine("Въведете последователно реални числа, като след всяко натискате Enter!");
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write("Въведете  {0}. число: ", i+1);
				a[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine(new String('-', 60));
		}
		public void ShowFirstSmaller()
		{
			int m = 0;
			bool isFound=false;
			for (int i = 0; i < a.Length-1; i++)
			{
				if(a[i] < a[9])
				{
					m = a[i];
					isFound=true;
					Console.WriteLine("Намереното число е {0}", a[i]);
					break;
				}
			}
			if(!isFound)
			{
				Console.WriteLine("Не е намерено такова число!");
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			FirstSmaller fsm = new FirstSmaller();
			fsm.ShowFirstSmaller();
			Console.ReadKey(true);
		}
	}
}