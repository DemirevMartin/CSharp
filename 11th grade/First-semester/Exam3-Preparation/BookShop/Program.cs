using System;
namespace Library
{
	public class Book
	{
		string title, author;
		double price;
		public Book(string tit, string auth, double pr)
		{
			title = tit;
			author = auth;
			price = pr;
		}
		public virtual double CalcPrice()
		{
			return price;
		}
		public virtual void BookInfo()
		{
			Console.WriteLine("Заглавие на книгата: {0}", title);
			Console.WriteLine("Автор: {0}", author);
			Console.WriteLine("Цена: {0:0.00} лева\n", CalcPrice());
		}
	}
	class SilverEditionBook : Book
	{
		public SilverEditionBook(string title, string author, double price)
			: base(title, author, price)
		{
			Console.WriteLine("Специални издания с надценка от 20%");
		}
		public override double CalcPrice()
		{
			return (base.CalcPrice() + base.CalcPrice()*20/100);
		}
		public override void BookInfo()
		{
			Console.WriteLine("Тип: Сребърно издание");
			base.BookInfo();
		}
	}
	class GoldenEditionBook : Book
	{
		public GoldenEditionBook(string title, string author, double price)
			: base (title, author, price)
		{
			Console.WriteLine("Специални издания с надценка от 30%");
		}
		public override double CalcPrice()
		{
			return (base.CalcPrice() + base.CalcPrice()*30/100);
		}
		public override void BookInfo()
		{
			Console.WriteLine("Тип: Златно издание");
			base.BookInfo();
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Book b = new Book("Младините на Пешо в картинки", "Петър Петров", 20);
			b.BookInfo();
			Console.WriteLine("");
            SilverEditionBook seb = new SilverEditionBook("В годините на зрелия ми живот", "Петър Петров", 20);
            seb.BookInfo();
            Console.WriteLine("");
            GoldenEditionBook geb = new GoldenEditionBook("Старините на Пешо", "Петър Петров", 20);
            geb.BookInfo();
			Console.WriteLine("");
			Console.WriteLine(". . .");
			Console.ReadKey(true);
		}
	}
}