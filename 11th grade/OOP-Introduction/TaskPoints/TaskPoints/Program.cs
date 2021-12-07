using System;
namespace TaskPoints
{
	class Pnts
	{
		double x1, x2, y1, y2;
		
		public void CreatePoints()
		{
			Console.Write("point 1 (x): ");
			x1=Convert.ToDouble(Console.ReadLine());
			Console.Write("point 1 (y): ");
			y1=Convert.ToDouble(Console.ReadLine());
			Console.Write("point 2 (x): ");
			x2=Convert.ToDouble(Console.ReadLine());
			Console.Write("point 2 (y): ");
			y2=Convert.ToDouble(Console.ReadLine());
		}
		public void ShowPoints()
		{
			Console.WriteLine("Points:");
			Console.WriteLine("point 1: "+x1+"; "+y1);
			Console.WriteLine("point 2: "+x2+"; "+y2);
		}
		public double Segment()
		{
			return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Pnts pn=new Pnts();
			pn.CreatePoints();
			pn.ShowPoints();
			double seg=pn.Segment();
			Console.WriteLine("Distance between points: " + seg.ToString("f2"));
		
			Console.ReadKey(true);
		}
	}
}