/*
 * Created by SharpDevelop.
 * User: User
 * Date: 19.10.2020 г.
 * Time: 18:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Поръчки_за_бира2._
{
	class Order
    {
        private string packaging;
        private int year, month, day, quantity;
        private double price;
        
        public Order(string pck, int y, int m, int d, int q, double p)
        {
            packaging=pck;
            year=y;
            month=m;
            day=d;
            quantity=q;
            price=p;
        }
        public double CalcTotal()
        {
            return quantity*price;
        }
        public void Status()
        {
        	DateTime dt=DateTime.Today;
            DateTime dayt=new DateTime(year, month, day);
            if(dt>dayt)
            {
                Console.WriteLine("Status: unfulfilled!");
            }
            else
            {
                Console.WriteLine("Status: fulfilled!");
            }
        }
        public void PrintOrder()
        {
            Console.WriteLine("\nInformation on ordering beer:");
            Console.WriteLine("\n{0,9}{1,12}{2,17}{3,12}{4,19}", "Packaging", "Quantity", "Order date", "Price", "Total");
            Console.WriteLine(new String('-', 70));
            DateTime newdt=new DateTime(year, month, day);
            Console.WriteLine("{0,6}{1,12}{2,21:dd MMMM yyyy}{3,13:c2}{4,18:c2}", packaging, quantity, newdt, price, CalcTotal().ToString("f2")+" лв.");
            Console.WriteLine(new String('-', 70));
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
        	string pk;
        	int y, m, d, q;
        	double p;
        	Console.Write("Enter packaging: ");
            pk=Convert.ToString(Console.ReadLine());
            Console.Write("Enter year of the order: ");
            y=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month of the order: ");
            m=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day of the order: ");
            d=Convert.ToInt32(Console.ReadLine());
            Console.Write("Requested quantity: ");
            q=Convert.ToInt32(Console.ReadLine());
            Console.Write("Price: ");
            p=Convert.ToDouble(Console.ReadLine());
        	
            Order beer=new Order(pk, y, m, d, q, p);
            beer.PrintOrder();
            beer.Status();
            Console.ReadKey(true);
        }
    }
}
