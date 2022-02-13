using System;
namespace PseudoGraphics
{
	
    static class ConsoleGr
    {
    	public static void DrawRect(int size)
    	{
    		for(int i = 1; i <= size; i++)
    		{
    			for(int j = 1; j <= size; j++)
    			{
    				Console.Write("*");
    			}
    			Console.WriteLine();
    		}
    	}
    	public static void DrawRect(int size, char c)
    	{
    		for(int i = 1; i <= size; i++)
    		{
    			for(int j = 1; j <= size; j++)
    			{
    				Console.Write(c);
    			}
    			Console.WriteLine();
    		}
    	}
    	public static void DrawRect(int rows, int cols)
    	{
    		for(int i = 1; i <= rows; i++)
    		{
    			for(int j = 1; j <= cols; j++)
    			{
    				Console.Write("*");
    			}
    			Console.WriteLine();
    		}
    	}
    	public static void DrawRect(int rows, int cols, char c)
    	{
    		for(int i = 1; i <= rows; i++)
    		{
    			for(int j = 1; j <= cols; j++)
    			{
    				Console.Write(c);
    			}
    			Console.WriteLine();
    		}
    	}
    	public static void DrawRect(int rows, int cols, char outer, char inner)
    	{
    		for(int i = 1; i <= rows; i++)
    		{
    			for(int j = 1; j <= cols; j++)
    			{
    				if(i == 1 || i == rows)
    			    {
    				    Console.Write(outer);
    			    }
    				else if(j==1 || j==cols)
    				{
    					Console.Write(outer);
    				}
    				else 
    				{
    					Console.Write(inner);
    				}
    			}
    			Console.WriteLine();
    		}
    	}
    }
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Графика в конзолата");
			Console.WriteLine("1. Фигура от * с равен брой редове и колони");
			Console.WriteLine("2. Фигура от избран символ с равен брой редове и колони");
			Console.WriteLine("3. Фигура от * с различен брой редове и колони");
			Console.WriteLine("4. Фигура от избран символ с различен брой редове и колони");
			Console.WriteLine("5. Фигура от два избрани символа с различен брой редове и колони");
			Console.Write("Вашият избор е: ");
			int a = int.Parse(Console.ReadLine());
			
			if(a == 1)
			{
				Console.WriteLine("Въведете размер за фигурата:");
				int b = int.Parse(Console.ReadLine());
				ConsoleGr.DrawRect(b);
			}
			else if(a == 2)
			{
				Console.WriteLine("Въведете размер за фигурата:");
				int c = int.Parse(Console.ReadLine());
				Console.WriteLine("Въведете символ:");
				char d = Char.Parse(Console.ReadLine());
				ConsoleGr.DrawRect(c, d);
			}
			else if(a == 3)
			{
				Console.WriteLine("Въведете редовете на фигурата:");
				int f = int.Parse(Console.ReadLine());
				Console.WriteLine("Въведете колоните на фигурата");
				int g = int.Parse(Console.ReadLine());
				ConsoleGr.DrawRect(f, g);
			}
			else if(a == 4)
			{
				Console.WriteLine("Въведете редовете на фигурата:");
				int h = int.Parse(Console.ReadLine());
				Console.WriteLine("Въведете колоните на фигурата:");
				int k = int.Parse(Console.ReadLine());
				Console.WriteLine("Въведете символ:");
				char l = Char.Parse(Console.ReadLine());
				ConsoleGr.DrawRect(h, k, l);
			}
			else if(a == 5)
			{
				Console.WriteLine("Въведете редовете на фигурата:");
				int m = int.Parse(Console.ReadLine());
				Console.WriteLine("Въведете колоните на фигурата:");
				int n = int.Parse(Console.ReadLine());
				Console.WriteLine("Въведете символ за контура:");
				char p = Char.Parse(Console.ReadLine());
				Console.WriteLine("Въведете символ за вътрешността:");
				char q = Char.Parse(Console.ReadLine());
				ConsoleGr.DrawRect(m, n, p, q);
			}
			Console.ReadKey(true);
		}
	}
}