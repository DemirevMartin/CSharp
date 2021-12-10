using System;
namespace EqualNumbers
{
class EqNumbers
{
    int a, b, num;
    public EqNumbers(int _a)
    {
        a = _a;
    }

    int CountEqNumbers()
    {
       int c = 0, m = 1;
       b = a;
       do
       {
          if(a == b) { c++; num = b;}
          else
          {
              if(m < c) { m = c; }
              c = 1; b = a;
          }
      Console.Write("Въведете цяло число (0 за край): ");
      a = int.Parse(Console.ReadLine());
      }
     while(a != 0);
     Console.WriteLine(new String('-', 40));
     if(m < c) { m = c; }
     return m;
	}
	public void Print()
	{
		Console.WriteLine("Брой повторения: " + CountEqNumbers());
		Console.WriteLine("Последователно повтарящо се число: " + num);
		Console.WriteLine(new String('-', 40));
	}
}
class Program
{
public static void Main(string[] args)
{
     Console.Write("Въведете цяло число (0 за край): ");
     int a = int.Parse(Console.ReadLine());
     EqNumbers en = new EqNumbers(a);
     en.Print();
     Console.Write(". . . ");
     Console.ReadKey(true);
}
}
}