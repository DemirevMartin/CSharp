using System;
namespace FindingMinMax
{
	static class MinMax
	{
		static void FindMinMax(int[] arr, out int min, out int max)
		{
			min = arr[0];
			max = arr[0];
			for(int i = 1; i < arr.Length; i++)
			{
				if(arr[i] < min) min = arr[i];
				if(arr[i] > max) max = arr[i];
			}
		}
		public static void PrintMinMax()
		{
			int smallest, biggest;
			int[] a = new int[25];
			Random r = new Random();
			
			for(int i = 0; i < 25; i++)
			{
				a[i] = r.Next(1, 101);
			}
			Console.WriteLine("Числа на масива:");
			Console.WriteLine(string.Join(", ", a));
			MinMax.FindMinMax(a, out smallest, out biggest);
			Console.WriteLine("Най-малко число: {0}", smallest);
			Console.WriteLine("Най-голямо число: {0}", biggest);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			MinMax.PrintMinMax();
			Console.ReadKey(true);
		}
	}
}