using System;

namespace MathPoints2D
{
	static class MathPoints2D
	{
		public static double DistanceBetween(double xA, double yA, double xB, double yB)
		{
			double distanceAB = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
			return Math.Round(distanceAB, 3);
		}
		public static double DistanceToTheCenter(double x, double y)
		{
			// 2 начина:
			// double resultOO = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
			// return Math.Round(resultOO, 3);
			return MathPoints2D.DistanceBetween(0, 0, x, y);
		}
		public static string TriangleТype(double xA, double yA, double xB, double yB, double xC, double yC)
		{
			double ab = MathPoints2D.DistanceBetween(xA, yA, xB, yB);
			double ac = MathPoints2D.DistanceBetween(xA, yA, xC, yC);
			double bc = MathPoints2D.DistanceBetween(xB, yB, xC, yC);
			if(ab == 0 || ac == 0 || bc == 0 || ab >= ac + bc || ac >= ab + bc || bc >= ab + ac)
			{
				return "не съществува";
			}
			else if (ab == ac && ab == bc)
			{
				return "равностранен";
			}
			else if (ab == ac || ab == bc || ac == bc)
			{
				return "равнобедрен";
			}
			else
			{
				return "разностранен";
			}
		}
		public static double TrianglePerimeter(double xA, double yA, double xB, double yB, double xC, double yC)
		{
			double P;
			double ab = MathPoints2D.DistanceBetween(xA, yA, xB, yB);
			double ac = MathPoints2D.DistanceBetween(xA, yA, xC, yC);
			double bc = MathPoints2D.DistanceBetween(xB, yB, xC, yC);
			P = ab + bc + ac;
			return P;
		}
		public static double TriangleArea(double xA, double yA, double xB, double yB, double xC, double yC)
		{
			double p;
			double ab = MathPoints2D.DistanceBetween(xA, yA, xB, yB);
			double ac = MathPoints2D.DistanceBetween(xA, yA, xC, yC);
			double bc = MathPoints2D.DistanceBetween(xB, yB, xC, yC);
			p = (ab + bc + ac)/2;
			double S = Math.Sqrt(p*(p - ab)*(p - ac)*(p - bc));
			return Math.Round(S, 3);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			double xA, yA, xB, yB, xC, yC;
			Console.WriteLine("Въведете координати за точка A");
			Console.Write("х = ");
			xA = Convert.ToDouble(Console.ReadLine());
			Console.Write("у = ");
			yA = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Въведете координати за точка B");
			Console.Write("x = ");
			xB = Convert.ToDouble(Console.ReadLine());
			Console.Write("y = ");
			yB = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Въведете координати за точка C");
			Console.Write("x = ");
			xC = Convert.ToDouble(Console.ReadLine());
			Console.Write("y = ");
			yC = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Дължини на отсечки: OA = {0}  OB = {1}  OC = {2}  AB = {3}  AC = {4}  BC = {5}", 
			MathPoints2D.DistanceToTheCenter(xA, yA), MathPoints2D.DistanceToTheCenter(xB, yB), 
			MathPoints2D.DistanceToTheCenter(xC, yC), MathPoints2D.DistanceBetween(xA, yA, xB, yB),
			MathPoints2D.DistanceBetween(xA, yA, xC, yC), MathPoints2D.DistanceBetween(xB, yB, xC, yC));
			Console.WriteLine();
			
			Console.WriteLine("Тип на триъгълник ABC - {0}", MathPoints2D.TriangleТype(xA, yA, xB, yB, xC, yC));
			Console.WriteLine("Обиколка на триъгълник ABC - {0}", MathPoints2D.TrianglePerimeter(xA, yA, xB, yB, xC, yC));
			Console.WriteLine("Лице на триъгълник ABC - {0}", MathPoints2D.TriangleArea(xA, yA, xB, yB, xC, yC));
			Console.ReadKey(true);
		}
	}
}