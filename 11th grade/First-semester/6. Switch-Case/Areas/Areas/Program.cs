using System;
namespace Areas
{
	class Area 
	{
		private int x;
		private double a;
		
		public Area(int _x, double _a)
		{
			x=_x;
			a=_a;
		}
		public void CalcArea()
		{
			switch(x)
			{
				case 1:
				Console.WriteLine("Perimeter of the triangle: {0}", (a*3).ToString("f2"));
				break;
				case 2: 
				Console.WriteLine("Area of the square: {0}", (a*a).ToString("f2"));
				break;
				case 3:
				Console.WriteLine("Area of the circle: {0}", (a*a*Math.PI).ToString("f2"));
				break;
			    default:
				Console.WriteLine("Error!");
				break;
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			int x1;
			double a1;
			Console.Write("Enter a value for a: ");
			a1=Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter code(1, 2 or 3): ");
			x1=Convert.ToInt32(Console.ReadLine());
			Area figure=new Area(x1, a1);
			figure.CalcArea();
			
			Console.ReadKey(true);
		}
	}
}