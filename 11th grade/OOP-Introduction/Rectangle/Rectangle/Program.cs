using System;
namespace Rectangle
{
	class Rectangle
	{
		public double width;
		public double length;
		public double S;
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Rectangle r = new Rectangle();
			
			r.length = 7.7;
			r.width = 4.9;
			r.S = r.length * r.width;
			
			Console.WriteLine("Length: " + r.length);
			Console.WriteLine("Width: " + r.width);
			Console.WriteLine("S: " + r.S);
			
			Console.ReadKey(true);
		}
	}
}