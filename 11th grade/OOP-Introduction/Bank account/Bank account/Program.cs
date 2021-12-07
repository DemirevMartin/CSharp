/*
 * Created by SharpDevelop.
 * User: User
 * Date: 18.9.2020 г.
 * Time: 18:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Bank_account
{
	class Person
	{
		public string fName;
	    public string lName;
	}
	class Client
	{
		public double amount;
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Person ilko1=new Person();
			ilko1.fName="Ilko";
			ilko1.lName="Stoev";
			
			Client ilko2=new Client();
			ilko2.amount=1700.52;
			
			Console.WriteLine("Name: "+ilko1.fName+" "+ilko1.lName);
			Console.WriteLine("Amount: "+ilko2.amount);
			
			Console.ReadKey(true);
		}
	}
}