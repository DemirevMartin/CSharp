using System;
namespace Sequence
{
	class Sequence
	{
		int[] a;
		
		public Sequence()
		{
			a = new int[12];
			Read();
		}
		void Read()
		{
			Console.WriteLine("Въведете 12 цели числа:");
			for (int i = 0; i < 12; i++)
			{
				Console.Write("Въведете {0}. число: ", i+1);
				a[i] = int.Parse(Console.ReadLine());
			}
		}
		int CountOdd()
		{
			int counter = 0;
			for(int i = 0; i<a.Length; i++)
			{
				if(a[i] % 2 != 0)
				{
					counter++;
				}
			}
			return counter;
		}
		int FirstEven()
		{
			for(int i = 0; i < a.Length; i++)
			{
				if(a[i] % 2 == 0)
				{
					return i;
				}
			}
			return -1; //Излизаме от масива!;
		}
		void ShowOdd()
		{
			if(FirstEven()==CountOdd())
			{
				Console.Write("Нечетни числа в редицата: ");
				for (int i = 0; i < 12; i++)
				{
					if(a[i] % 2 == 1) 
					{
						Console.Write(a[i] + "  ");
					}
				}
			}
			else 
			{
				Console.WriteLine("Броят на нечетните числа в редицата НЕ СЪВПАДА с индекса на първото четно число.");
			}
		}
		public void PrintArray()
		{
			string s=string.Join("  ", a);
			Console.WriteLine(new String('-', 35));
			Console.WriteLine("Съдържание на редицата:");
			Console.WriteLine(s);
			Console.WriteLine(new String('-', 35));
			Console.WriteLine("Брой нечетни: {0}", CountOdd());
			Console.WriteLine("Индекс на първото четно: {0}", FirstEven());
			ShowOdd();
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Sequence m = new Sequence();
			m.PrintArray();
			
			Console.ReadKey(true);
		}
	}
}