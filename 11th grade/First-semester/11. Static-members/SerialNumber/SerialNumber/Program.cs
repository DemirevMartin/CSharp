using System;

namespace SerialNumber
{
	class Product
	{
		string serialNum;
		static string part = "AA";
		static int amount = 0;
		
		public Product()
		{
			serialNum = GetNextSN();
			Product.amount++; 
		}
		static string GetNextSN()
		{
			if((Product.amount % 100 == 0) && (Product.amount > 0))
			{
				char first = Product.part[0];
				char second = Product.part[1];
				if(second == 'Z')
				{
					second = 'A';
					first++;
				}
				else second++;
				Product.part = first + "" + second;
			}
			return Product.part + string.Format("{0:d2}", Product.amount % 100);
		}
		public void PrintSN()
		{
			Console.WriteLine("Създаден е нов продукт със сериен №: {0}", serialNum);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Random rnd = new Random();
			int a = rnd.Next(50, 551);
			for(int i = 0; i < a; i++)
			{
				Product p = new Product();
				p.PrintSN();
			}
			Console.WriteLine("Създадени са общо {0} продукта!", a);
			Console.ReadKey(true);
		}
	}
}