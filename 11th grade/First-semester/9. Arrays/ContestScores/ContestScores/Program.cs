using System;
namespace ContestScores
{
	class ContestScores
	{
		int[] scores;
		public ContestScores(int n)
		{
			scores = new int[n];
			GetScores();
		}
		void GetScores()
		{
			Console.WriteLine("Списък с резултати:");
			Random rnd=new Random();
			for (int i = 0; i<scores.Length; i++)
			{
				scores[i] = rnd.Next(0, 61);
				Console.Write(scores[i] + "  ");
			}
			Console.WriteLine();
		}
		double GetAverageScore()
		{
			int sum = 0;
			foreach(int m in scores)
			{
				sum += m;
			}
			return Math.Round((double)sum/(double)scores.Length, 1);
		}
		int NumberOfScoresAbove(double d)
		{
			int counter = 0;
			d = GetAverageScore();
			for (int i = 0; i < scores.Length; i++)
			{
				if(scores[i]>d)
				{
					counter++;
				}
			}
			return counter;
		}
		int GetMaxScore()
		{
			int max = 0;
			for(int i = 0; i < scores.Length; i++)
			{
				if(scores[i]>max)
				{
					max=scores[i];
				}
			}
			return max;
		}
		public void PrintScoresInfo()
		{
			int goldenMedals = 0;
			for(int i = 0; i < scores.Length; i++)
			{
				if(scores[i] > GetMaxScore()*90/100)
				{
					goldenMedals++;
				}
			}
			Console.WriteLine("Най-висок резултат: {0}", GetMaxScore());
			Console.WriteLine("Брой златни медали: {0}", goldenMedals);
			Console.WriteLine("Среден резултат: {0}", GetAverageScore());
			Console.WriteLine("Брой резултати над средния: {0}", NumberOfScoresAbove(GetAverageScore()));
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Въведете броя на резултатите: ");
			int j = int.Parse(Console.ReadLine());
			ContestScores cs = new ContestScores(j);
			cs.PrintScoresInfo();
			Console.ReadKey(true);
		}
	}
}