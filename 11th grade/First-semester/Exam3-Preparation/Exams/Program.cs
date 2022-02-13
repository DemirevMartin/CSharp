using System;
namespace Control
{
	public class Exam
	{
		string subject;
		int courseProject;
		public Exam(string subj, int pointsCP)
		{
			subject = subj;
			courseProject = pointsCP;
		}
		public virtual double CalcPoints()
		{
			return (double)courseProject;
		}
		public virtual void PrintResult()
		{
			Console.WriteLine("Учебна дисциплина: {0}", subject);
			Console.WriteLine("Среден брой точки от курсови проекти: {0}", courseProject);
		}
	}
	class TheoryExam : Exam
	{
		private DateTime dtTheory;
		private int pointsTheory;
		public TheoryExam(string subject, int courseProject, int ptTheory, DateTime dt)
			: base (subject, courseProject)
		{
			pointsTheory = ptTheory;
			dtTheory = dt;
		}
		public override double CalcPoints()
		{
			double totalPt = (((double)pointsTheory/5) + base.CalcPoints());
			return totalPt;
		}
		public override void PrintResult()
		{
			Console.WriteLine("Теоретичен изпит, проведен на: {0:dd.M.yyyy} г.", dtTheory);
			base.PrintResult();
			Console.WriteLine("Среден брой точки от теоретичен изпит: {0}", pointsTheory);
			Console.WriteLine("Текущ контрол: {0} точки", CalcPoints());
		}
	}
	class PracticeExam : Exam
	{
		private DateTime dtTheory;
		private int pointsTheory;
		public PracticeExam(string subject, int courseProject, int ptTheory, DateTime dt)
			: base (subject, courseProject)
		{
			pointsTheory = ptTheory;
			dtTheory = dt;
		}
		public override double CalcPoints()
		{
			double totalPt = ((double)pointsTheory*2/5) + base.CalcPoints();
			return totalPt;
		}
		public override void PrintResult()
		{
			Console.WriteLine("Теоретичен изпит, проведен на: {0:dd.M.yyyy} г.", dtTheory);
			base.PrintResult();
			Console.WriteLine("Среден брой точки от теоретичен изпит: {0}", pointsTheory);
			Console.WriteLine("Текущ контрол: {0} точки", CalcPoints());
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Текущ контрол на студентите от I курс в специалност Счетоводство");
			Console.WriteLine(new String('-', 64));
			TheoryExam te = new TheoryExam("Информатика", 65, 28, new DateTime(2021, 1, 11));
			//TheoryExam te = new TheoryExam("Финансов контрол", 70, 25, new DateTime(2021, 1, 12));
			te.PrintResult();
			Console.WriteLine("");
            //PracticeExam pe = new PracticeExam("Информатика", 100, 95, new DateTime(2021, 1, 12));
            PracticeExam pe = new PracticeExam("Финансов контрол", 98, 78, new DateTime(2021, 1, 13));
            pe.PrintResult();
			Console.Write(". . .");
			Console.ReadKey(true);
		}
	}
}