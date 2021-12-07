using System;
namespace Tournament
{
	class ArcherScore
    {
        string nickname;
        int shot1, shot2, shot3;
        Random r=new Random();
        
        public void SetData(string nm, int a, int b, int c)
        {
            this.nickname=nm;
            this.shot1=a;
            this.shot2=b;
            this.shot3=c;
        }
        public int GetTotalScore()
        {
            return (this.shot1+this.shot2+this.shot3);
        }
        public void ShowPoints()
        {
            Console.WriteLine("Archer: "+this.nickname);
            Console.WriteLine("Shot1: {0}\nShot2: {1}\nShot3: {2}", shot1, shot2, shot3);
            Console.WriteLine("Total score: "+GetTotalScore());
        }
        public void BetterArcherThan(ArcherScore ar) 
        {
        	this.ShowPoints();
            ar.ShowPoints();
            int tfs = this.GetTotalScore();
            int arfs = ar.GetTotalScore();

            if (tfs > arfs ) Console.WriteLine("This time {0} is better than {1}", this.nickname, ar.nickname);
            else if (tfs < arfs ) Console.WriteLine("This time {1} is better than {0}", this.nickname, ar.nickname);
            else if (this.shot3 > ar.shot3 ) Console.WriteLine("This time {0} is better than {1}", this.nickname, ar.nickname);
            else if (this.shot3 < ar.shot3 ) Console.WriteLine("This time {1} is better than {0}", this.nickname, ar.nickname);
            else Console.WriteLine("The scores are completely equal, so there should be a shootout");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            ArcherScore a, b;
            a = new ArcherScore();
            b = new ArcherScore();
            Random r = new Random();
            Console.Write("The first archer's nickname: ");
            a.SetData(Console.ReadLine(), r.Next(1, 21), r.Next(1, 21), r.Next(1, 21));
            Console.Write("The second archer's nickname: ");
            b.SetData(Console.ReadLine(), r.Next(1, 21), r.Next(1, 21), r.Next(1, 21));
            a.BetterArcherThan(b);
            
            Console.ReadKey(true);
        }
    }
}