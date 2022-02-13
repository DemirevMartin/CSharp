using System;
namespace GenerateAndPrint
{
	class GPArr
	{
		int[] arr;
		public GPArr()
		{
			int[] arr = new int[10];
			Fill();
		}
		private void Fill()
		{
			Console.WriteLine("Въведете 10 последователни числа, като след всяко натискате Enter!");
			for(int i = 0; i<arr.Length; i++)
			{
				Console.Write("Въведете {0}. число: ", i);
				arr[i]=int.Parse(Console.ReadLine());
			}
		}
		public void PrintArray(string delim)
		{
			delim="  ";
			Console.WriteLine("Съдържание на масива:");
			for (int i = 0; i <arr.Length; i++)
			{
				Console.Write(arr[i] + ";" + delim);
			}
		}
		public void CheckSymm()
		{
			int m = arr.Length;
			for (int i = 0; i < arr.Length; i++)
			{
				if(arr[i] == arr[m] && arr [i++] == arr[m--])
				{
					i++;
					m--;
					Console.WriteLine("Този масив е симетричен!");
				}
				else 
				{
					Console.WriteLine("Този масив не е симетричен!");
				}
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			GPArr test = new GPArr();
			string dlm = "  ";
			test.PrintArray(dlm);
			test.CheckSymm();
			
			Console.ReadKey(true);
		}
	}
}