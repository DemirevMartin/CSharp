using System;
using System.Collections.Generic;
namespace Shapes
{
	public class Shape
	{
		string type;
		protected Shape (string t)
		{
			type = t;
		}
		public virtual void Describe() 
		{
			Console.WriteLine("Тази фигура е {0}", type);
		}
		public virtual void CalcAndPrintPerimeter() 
		{
			Console.WriteLine("Няма обща формула за обиколка :(");
		}
		public virtual void CalcAndPrintArea() 
		{
			Console.WriteLine("Няма обща формула за лице :(");
		}
	}
	class Square : Shape
	{
		private double side;
		public Square(double s) : base("квадрат")
		{
			side = s;
		}
		public override void Describe()
		{
			base.Describe();
			Console.WriteLine("Страната на квадрата е {0}", side);
		}
		public override void CalcAndPrintPerimeter()
		{
			Console.WriteLine("Формулата за обиколка на квадрат е Р = 4 . а");
			Console.WriteLine("За този квадрат Р = 4 . {0} = {1}", side, side*4);
		}
		public override void CalcAndPrintArea()
		{
			Console.WriteLine("Формулата за лице на квадрат е S = a . а");
			Console.WriteLine("За този квадрат S = {0} . {0} = {1}", side, side*side);
		}
	}
	class Rectangle : Shape
	{
		private double sideA, sideB;
		public Rectangle(double sA, double sB) : base("правоъгълник")
		{
			sideA = sA;
			sideB = sB;
		}
		public override void Describe()
		{
			base.Describe();
			Console.WriteLine("Страните на правоъгълника са {0} и {1}", sideA, sideB);
		}
		public override void CalcAndPrintPerimeter()
		{
			Console.WriteLine("Формулата за обиколка на правоъгълник е Р = 2 . (a + b)");
			Console.WriteLine("За този правоъгълник Р = 2 . ({0} + {1}) = {2}", sideA, sideB, 2*(sideA + sideB));
		}
		public override void CalcAndPrintArea()
		{
			Console.WriteLine("Формулата за лице на правоъгълник е S = a . b");
			Console.WriteLine("За този правоъгълник S = {0} . {1} = {2}", sideA, sideB, sideA*sideB);
		}
	}
	class Circle : Shape
	{
		private double radius;
		public Circle(double r) : base("окръжност")
		{
			radius = r;
		}
		public override void Describe()
		{
			base.Describe();
			Console.WriteLine("Радиусът на окръжността е {0}", radius);
		}
		public override void CalcAndPrintPerimeter()
		{
			double C = 2 * radius * Math.PI;
			Console.WriteLine("Формулата за дължина на окръжност е C = 2.п.r");
			Console.WriteLine("За тази окръжност C = 2.п.{0} = {1}", radius, C);
		}
		public override void CalcAndPrintArea()
		{
			double S = radius * radius *Math.PI;
			Console.WriteLine("Формулата за лице на кръг е S = п.r.r");
			Console.WriteLine("За този кръг S = п.{0}.{0} = {1}", radius, S);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			List <Shape> shapes = new List<Shape>(){new Square(3), new Rectangle(4, 5.5), new Circle(4), new Square(1.5), new Rectangle(2, 3), new Circle(10)};
			foreach (Shape s in shapes)
			{
				s.Describe();
				s.CalcAndPrintPerimeter();
				s.CalcAndPrintArea();
				Console.WriteLine("");
			}
			Console.ReadKey(true);
		}
	}
}