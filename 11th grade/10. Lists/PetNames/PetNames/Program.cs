using System;
using System.Collections.Generic;

namespace PetNames
{
	class PetNames
	{
		List<string> favNames;
		public PetNames()
		{
			favNames = new List<string>();
			GetNames();
		}
		void GetNames()
		{
			Console.WriteLine("Запълване на списъка!");
			string s = "";
			do
			{
				Console.Write("Въведете име: ");
				s=Console.ReadLine();
				if(favNames.IndexOf(s) == -1) favNames.Add(s);
			}
			while(favNames[favNames.Count - 1] != "***");
			favNames.Remove("***");
			Console.WriteLine("Край на запълването!");
		}
		public void RemoveNames()
		{
			Console.WriteLine("Редакция на списъка - възможност за изтриване!");
			string s = "";
			do
			{
				PrintList();
				Console.Write("Изберете име за изтриване: ");
				s = Console.ReadLine();
				favNames.Remove(s);
			}
			while (s != "***");
			Console.WriteLine("Край на изтриването!");
		}
		public void MoveToPosition()
		{
			Console.WriteLine("Редакция на списъка - възможност за преместване!");
			string s = "";
			int pos;
			PrintList();
			Console.Write("Изберете име за преместване: ");
			s = Console.ReadLine();
			while(s != "***")
			{
				Console.Write("Посочете номера за новата позиция: ");
				pos = int.Parse(Console.ReadLine());
				if(favNames.Contains(s))
				{
					favNames.Remove(s);
					favNames.Insert(pos - 1, s);
				}
				PrintList();
				Console.Write("Изберете име за преместване: ");
				s = Console.ReadLine();
			}
			Console.WriteLine("Край на разместването!");
		}
		public void PrintList()
		{
			Console.WriteLine("Списък: {0}", string.Join("//", favNames));
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			PetNames pn = new PetNames();
			pn.RemoveNames();
			pn.MoveToPosition();
			pn.PrintList();
			Console.ReadKey(true);
		}
	}
}