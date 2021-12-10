using System;
using System.Collections.Generic;

namespace CarRegNumbers
{
	class Nums
	{
		List<string> regPlates, numList;
		public Nums()
		{
			regPlates = new List<string>();
			numList = new List<string>();
			GetData();
			RemoveZeroes();
			RemoveDuplicates();
		}
		void GetData()
		{
			string a = "";
			Console.WriteLine("Запълване на списъка");
			do
			{
				Console.Write("Въведете номер (--- за край): ");
				regPlates.Add(Console.ReadLine());
			}
			while(!(regPlates.Contains("---")));
			regPlates.Remove("---");
		}
		void RemoveZeroes()
		{
			Console.WriteLine("Премахване на номерата с 0 от списъка");
			numList.AddRange(regPlates);
			for(int i = 0; i < numList.Count; )
			{
				if(numList[i].IndexOf('0') >= 0)
				{
					numList.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
		}
		void RemoveDuplicates()
		{
			Console.WriteLine("Премахване на дублиранията на номера в списъка");
			for(int i = 0; i < numList.Count; )
			{
				if(numList.LastIndexOf(numList[i]) != i)
				{
					numList.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
		}
		public void PrintLists()
		{
			Console.WriteLine("Начален списък");
			Console.WriteLine(string.Join("  ", regPlates));
			Console.WriteLine("Редактиран списък");
			if(numList.Count > 0)
			{
				Console.WriteLine(string.Join("  ", numList));
			}
			else
			{
				Console.WriteLine("Списъкът е празен :(");
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Nums n = new Nums();
			n.PrintLists();
			Console.ReadKey(true);
		}
	}
}