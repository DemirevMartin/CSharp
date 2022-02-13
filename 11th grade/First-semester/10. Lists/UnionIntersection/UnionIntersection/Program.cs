using System;
using System.Collections.Generic;

namespace Действия_с_множества
{
	class UID_Sets
	{
		List<int> listA, listB;
		public UID_Sets()
		{
			listA = new List<int>();
			listB = new List<int>();
			FillTheLists();
		}
		void FillTheLists()
		{
			int s = 0;
			Random rnd = new Random();
			for(int i = 1; i <= 100; i++)
			{
				s = rnd.Next(1, 101);
				if(listA.IndexOf(s) == -1)
				{
					listA.Add(s);
				}
				else
				{
					break;
				}
			}
			Console.WriteLine("A = {" + string.Join(", ", listA) + "}");
			
			int m = 0;
			Random mms = new Random();
			for(int j = 1; j <= 100; j++)
			{
				m = mms.Next(1, 101);
				if(listB.IndexOf(m) == -1)
				{
					listB.Add(m);
				}
				else
				{
					break;
				}
			}
			Console.WriteLine("B = {" + string.Join(", ", listB) + "}");
		}
		public void Print()
		{
			Union_AB();
			Intersection_AB();
			Difference_AB();
		}
		void Union_AB()
		{
			List<int> union = new List<int>();
			union.AddRange(listA);
			union.AddRange(listB);
			for(int k = 0; k < union.Count; )
			{
				if(union.LastIndexOf(union[k]) != k)
				{
					union.RemoveAt(k);
				}
				else{k++;}
			}
			Console.WriteLine("A U B = {" + string.Join(", ", union) + "}");
		}
		void Intersection_AB()
		{
			List<int> reunion = new List<int>();
			reunion.AddRange(listA);
			reunion.AddRange(listB);
			for(int k = 0; k < reunion.Count; )
			{
				if(reunion.LastIndexOf(reunion[k]) != k)
				{
					k++;
				}
				else
				{
					reunion.RemoveAt(k);
				}
			}
			Console.WriteLine("A n B = {" + string.Join(", ", reunion) + "}");
		}
		void Difference_AB()
		{
			List<int> difference = new List<int>();
			difference.AddRange(listA);
			difference.AddRange(listB);
			List<int> result = new List<int>();
			result.AddRange(listA);
			for(int m = 0; m < difference.Count; )
			{
				if(difference.LastIndexOf(difference[m]) != m)
	            {
					difference.RemoveAt(difference.LastIndexOf(difference[m]));
					result.Remove(difference[m]);
				}
				else{m++;}
			}
			Console.WriteLine("A - B = {" + string.Join(", ", result) + "}");
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			UID_Sets m = new UID_Sets();
			m.Print();
			Console.ReadKey(true);
		}
	}
}