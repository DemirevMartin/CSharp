using System;
namespace SerialNumber2
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool endNow = false;
			Random rnd = new Random();
			int a = rnd.Next(50, 551);
			int total = a;
			for(char c = 'A'; c <= 'Z'; c++)
			{
				for(int j = 0; j < 100; j++)
				{
					a--;
					if(j < 10)
					{
						Console.WriteLine("Създаден е нов продукт със сериен номер №: A" + c + "0" + j);
					}
					else
					{
						Console.WriteLine("Създаден е нов продукт със сериен номер №: A" + c + j);
					}
						
					if(a == 0)
					{
						endNow = true;
						break;
					}
				}
				if(endNow)
				{
					break;
				}
			}
			Console.WriteLine("Създадени са общо {0} продукта!", total);
			Console.ReadKey(true);
		}
	}
}