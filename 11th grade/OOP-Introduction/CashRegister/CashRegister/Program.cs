using System;
namespace CashRegister
{
	class CashRegister
	{
		public int itemCount;
		public double totalPrice;
		public double custMoney;
		
		public void AddItem()
		{
			double price = -1;
		    Console.WriteLine("Enter the price of an item: ");
			while(price != 0)
			{
				price = Convert.ToDouble(Console.ReadLine());
				if(price>0)
				{
					itemCount++;
					totalPrice=totalPrice+price;
				}
			}
		}
		public double GetTotal()
		{
			return totalPrice;
		}
		public int GetCount()
		{
			return itemCount;
		}
		public void Display()
		{
			Console.WriteLine("ItemCount: " + GetCount());
			Console.WriteLine("TotalPrice: " + GetTotal().ToString("f2"));
		}
		public void DisplayResto()
		{
			Console.Write("Enter customer's money: ");
			custMoney=Convert.ToDouble(Console.ReadLine());
			
			if(custMoney>totalPrice)
			{
				Console.WriteLine("Resto: "+(custMoney-totalPrice).ToString("f2"));
			}
			else if(custMoney<totalPrice)
			{
				Console.WriteLine("Less than: "+(totalPrice-custMoney).ToString("f2"));
			}
			else
			{
				Console.WriteLine("");
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			CashRegister reg=new CashRegister();
			reg.AddItem();
			reg.Display();
			reg.DisplayResto();
			
			Console.ReadKey(true);
		}
	}
}