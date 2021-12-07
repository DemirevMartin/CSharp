using System;
namespace Products
{
	class Product
	{
		public string description;
		public int partNum;
		public double cost;
	}
	class Program
	{
		public static void Main(string[] args)
		{
            Product p1=new Product();
			Product p2=new Product();
			
			p1.description="screw-driver";
			p1.partNum=456;
			p1.cost=5.50;
			
			p2.description="hammer";
			p2.partNum=324;
			p2.cost=8.20;
			
			Console.WriteLine("Description: "+p1.description);
			Console.WriteLine("PartNum: "+p1.partNum);
			Console.WriteLine("Cost: "+p1.cost.ToString("f2"));
			Console.WriteLine();
			Console.WriteLine("Description: "+p2.description);
			Console.WriteLine("PartNum: "+p2.partNum);
			Console.WriteLine("Cost: "+p2.cost.ToString("f2"));

			Console.ReadKey(true);
		}
	}
}