using System;
namespace Стойности_в_диапазон
{
	class MathC
	{
		public static bool IsClamp(double value)
		{
			if(value >= 0 && value <= 1)
			{
				return true;
			}
			else 
			{
				return false;
			}
		}
		public static bool IsClamp(int value, int min, int max)
		{
			if(min>= max)
			{
                throw new System.ArgumentException("Не е въведена коректна стойност за min!");
			}
			
			if(value >= min && value <= max)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Точка в квадрат");
			double x, y;
			Console.Write("x: ");
			x = double.Parse(Console.ReadLine());
			Console.Write("y: ");
			y = double.Parse(Console.ReadLine());
			
			if(MathC.IsClamp(x) && MathC.IsClamp(y))
			{
				Console.WriteLine("Точката принадлежи на квадрата.");
			}
			else
			{
				Console.WriteLine("Точката НЕ принадлежи на квадрата!");
			}
			Console.WriteLine("");
			
			Console.WriteLine("Здравен статус");
			int value, min, max;
			min = 1;
			max = 100;
			Console.Write("Въведете вашите точки: ");
			value = int.Parse(Console.ReadLine());
			
			if(MathC.IsClamp(value, min, max))
			{
				if(value >= min && value <= 20)
				{
					Console.WriteLine("Вие сте в лошо здраве!");
				}
				else if(value<= 50)
				{
					Console.WriteLine("Вие сте в добро здраве!");
				}
				else if(value <= max)
				{
					Console.WriteLine("Вие сте в отлично здраве!");
				}
			}
			else
			{
				Console.WriteLine("Не може да се определи по тази скала!");
			}
			Console.ReadKey(true);
		}
	}
}