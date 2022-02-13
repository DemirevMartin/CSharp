using System;
namespace CharCount
{
	static class CharCounter
	{		
		public static void NumberOfChar(string str, char c)
		{
			int n = 0;
			for(int i = 0; i < str.Length; i++)
			{
				char mes = str[i];
				if(mes == c)
				{
					n++;
				}
			}
			Console.Write(n);
		}
		public static void NumberOfChar(string str)
		{
			for(int i = 0; i < str.Length; i++)
			{
				int n = 0;
				for(int j = 0; j < str.Length; j++)
				{
					if(str[i] == str [j])
					{
						if(i > j)
						{
							break;
						}
						else
						{
							n++;
						}
					}
				}
				if(n > 0)
				{
					Console.WriteLine("{0} - {1}", str[i], n);
				}
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Меню:");
			Console.WriteLine("1. За брой повторения на всеки символ");
			Console.WriteLine("2. За брой повторения на избран символ");
			Console.Write("Вашият избор е: ");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("Въведете текст: ");
			string m = Convert.ToString(Console.ReadLine());
			
			if(n == 1)
			{
				Console.WriteLine("Символи и съответстващите им повторения:");
				CharCounter.NumberOfChar(m);
			}
			else if(n == 2)
			{
				Console.Write("Въведете символ: ");
			    char s = char.Parse(Console.ReadLine());
			    Console.Write("Повторения на символ {0} - ", s);
			    CharCounter.NumberOfChar(m, s);
			}
			
			Console.ReadKey(true);
		}
	}
}