/*
 * Created by SharpDevelop.
 * User: zlati
 * Date: 3.11.2020 г.
 * Time: 15:23 ч.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TextToNumbers
{
	class Encryption
	{
		string message, action;
		public Encryption (string m, string a)
		{
			message=m;
			action=a;
		}
		string Encode()
		{
			string enc = "";
		    
			for (int i = 0;i < message.Length; i++)
			{
				enc +=(300-message[i]).ToString();
			}
			return enc;
		}
		string Decode()
		{
			string dec = "";
		    for(int i=0;i<message.Length;i+=3)
			{
		    	int a = (message[i] - '0') * 100 + (message[i+1] - '0') * 10 + (message[i+2] - '0');
		    	dec+=(char)(300-a);
			}
		    return dec;
		}
		public void PrintMessage()
		{
			Console.WriteLine(new String('-', 50));
			if(action == "encode") Console.WriteLine(Encode());
			if(action == "decode") Console.WriteLine(Decode());
			Console.WriteLine(new String('-', 50));
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter a message:");
			string mes1=Console.ReadLine();
			Console.Write("Choose an action (encode/decode): ");
			string act1=Console.ReadLine();
			
			Encryption encr1=new Encryption(mes1, act1);
			encr1.PrintMessage();
		
			Console.WriteLine("Enter a message:");
			string mes2=Console.ReadLine();
			Console.Write("Choose an action (encode/decode): ");
			string act2=Console.ReadLine();
			
			Encryption encr2=new Encryption(mes2, act2);
			encr2.PrintMessage();
			
			Console.ReadKey(true);
		}
	}
}