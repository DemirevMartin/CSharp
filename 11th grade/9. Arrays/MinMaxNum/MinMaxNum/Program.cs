/*
 * Created by SharpDevelop.
 * User: zlati
 * Date: 10.11.2020 г.
 * Time: 08:05 ч.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MinMaxNum
{
	class MinMaxNum
	{
		private int num, minNum, maxNum;
		public MinMaxNum(int n)
		{
			num=n;
			CalcMinMax();
		}
		void CalcMinMax()
		{
			int [] c = new int[num.ToString().Length];
			int nm = num;
			for(int i = 0; i < c.Length; i++)
            {
				c[i] = nm % 10;
				nm /= 10;
            }
			Array.Sort(c);
			minNum=0;
			for(int i = 0; i < c.Length; i++)
			{
				minNum = minNum * 10 + c[i];
			}
			Array.Reverse(c);
			maxNum = 0;
			for(int i = 0; i < c.Length; i++)
			{
				maxNum = maxNum * 10 + c[i];
			}
		}
		public void PrintNumbers()
		{
			Console.WriteLine("От цифрите на числото {0} могат да се образуват: ", num);
			Console.WriteLine("Най-малко число: {0} и най-голямо число: {1}", minNum, maxNum);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Въведете естествено число: ");
			int a = int.Parse(Console.ReadLine());
			MinMaxNum m = new MinMaxNum(a);
			m.PrintNumbers();
			
			Console.ReadKey(true);
		}
	}
}