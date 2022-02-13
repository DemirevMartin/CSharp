using System;
namespace AvgOverload
{
	class Program
	{
		public static double Avg(int a, int b)
		{
			return (a + b) / 2;
		}
		public static double Avg(int a, int b, int c)
		{
			return (a + b + c) / 3;
		}
		public static double Avg(int a, int b, int c, int d)
		{
			return (a + b + c + d) / 4;
		}
		public static double Avg(int[] arr)
		{
			int sum = 0;
			for(int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			return sum / arr.Length;
		}
		public static void Main(string[] args)
		{
			Console.WriteLine("Средно ариметично на двете числа: {0}", Avg(15, 15));
			Console.WriteLine("Средно ариметично на трите числа: {0}", Avg(51, 15, 51));
			Console.WriteLine("Средно ариметично на четирите числа: {0}", Avg(1, 5, 15, 51));
			Random r = new Random();
			Random j = new Random();
			int a = r.Next(4, 11);
			Console.WriteLine("Дължината на масива е: {0}", a);
			int[] arr = new int[a];
			Console.Write("Числата в масива са: ");
			for(int i = 0; i < a; i++)
			{
				int fill = j.Next(1, 51);
				arr[i] = fill;
			}
			Console.Write(string.Join(", ", arr));
			Console.WriteLine();
			Console.WriteLine("Средно ариметично на всички числа в масива: {0}", Avg(arr));
			Console.ReadKey(true);
		}
	}
}