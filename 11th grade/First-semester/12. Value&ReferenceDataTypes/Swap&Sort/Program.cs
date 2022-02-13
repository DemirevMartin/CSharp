using System;
namespace Swap_and_order
{
	static class SwapAndSort
	{
		static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
		public static void Sort3(ref int a, ref int b, ref int c)
		{
			if(a>b) Swap(ref a, ref b);
			if(b>c) Swap(ref b, ref c);
			if(a>b) Swap(ref a, ref b);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			int x, y, z;
			Random r = new Random();
			x = r.Next(1, 1001);
			y = r.Next(1, 1001);
			z = r.Next(1, 1001);
			Console.WriteLine("В началото x = {0}  y = {1}  z = {2}", x, y, z);
			SwapAndSort.Sort3(ref x, ref y, ref z);
			Console.WriteLine("След подреждането x = {0}  y = {1}  z = {2}", x, y, z);
			Console.ReadKey(true);
		}
	}
}