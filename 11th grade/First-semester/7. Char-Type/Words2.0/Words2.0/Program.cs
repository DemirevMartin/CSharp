/*
 * Created by SharpDevelop.
 * User: zlati
 * Date: 2.11.2020 г.
 * Time: 19:42 ч.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Words2._
{
	class WordsCounter
	{
		string wrds;
		public WordsCounter(string wr)
		{
			wrds=wr;
		}
		public int CountWords()
		{
			int countOfWords = 0;
			
			for(int i = 1; i<wrds.Length; i++)
			{
				if(char.IsLetter(wrds, i) && char.IsWhiteSpace(wrds, i - 1))
				{
					countOfWords++;
				}
			}
			if(char.IsLetter(wrds, 0))
			{
				countOfWords++;
			}
			return countOfWords;
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter text: ");
			string mn=Console.ReadLine();
			WordsCounter wl=new WordsCounter(mn);
			Console.WriteLine("Number of words in the text: {0}", wl.CountWords());
			
			Console.ReadKey(true);
		}
	}
}