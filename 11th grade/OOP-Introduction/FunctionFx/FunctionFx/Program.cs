using System;
namespace FunctionFx
{
	class Fx
	{
		int x;
		public void Readx()
		{
			Console.Write("x: ");
			x=Convert.ToInt32(Console.ReadLine());
		}
		public int CalcFx()
		{
			if(x>=-2 && x<=2)
			{
				return x*(-3);
			}
			else 
			{
				return x*2;
			}
		}
		public void PrintResult()
		{
			Console.WriteLine("f(x): " + CalcFx());
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Fx m = new Fx();
			m.Readx();
			m.PrintResult();
			Console.ReadKey(true);
		}
	}
}