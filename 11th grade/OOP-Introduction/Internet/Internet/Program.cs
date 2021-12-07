using System;
namespace Internet_Article
{
    class Article
    {
        public int readers;
        public int likes;
        public int dislikes;
        public string name;
        
        public void Initialize()
        {
            Console.WriteLine("Initializing... ");
            Console.Write("Name: ");
            name=Console.ReadLine();
            Console.Write("Number of Readers: ");
            readers=int.Parse(Console.ReadLine());
            Console.Write("Likes: ");
            likes=int.Parse(Console.ReadLine());
            Console.Write("Dislikes: ");
            dislikes=int.Parse(Console.ReadLine());
        }

        public double GetPositiveIndex()
        {
            return(double)likes/(likes + dislikes);
        }
        
        public double GetEmotionalIndex()
        {
            return(double)(likes + dislikes)/readers;
        }
        
        public void Info()
        {
            Console.WriteLine(name);
            Console.WriteLine("Readers: "+readers);
            Console.WriteLine("Likes: "+likes);
            Console.WriteLine("Dislikes: "+dislikes);
            Console.WriteLine("Emotional index "+GetEmotionalIndex().ToString());
            Console.WriteLine("Positive index: "+GetPositiveIndex().ToString());
        }
        
        public void ComparePop(Article other)
        {
            Console.Clear();
            this.Info();
            other.Info();
            double a1=this.GetPositiveIndex();
            double b1=other.GetPositiveIndex();
            
            if(this.readers>other.readers)
            {
                Console.WriteLine("More readers: the first article");
            }
        
            else 
            {
                Console.WriteLine("More readers: the second article");
            }
            
            if(a1>b1)
            {
                Console.WriteLine("Higher positive index: the first article");
            }
        
            else 
            {
                Console.WriteLine("Higher positive index: the second article");
            }
    
            double a=this.GetEmotionalIndex();
            double b=other.GetEmotionalIndex();
            
            if(a>b)
            {
                Console.WriteLine("Higher emotional index: the first article");
            }
        
            else
            {
                Console.WriteLine("Higher emotional index: the second article");
            }
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            Article a, b;
            a=new Article();
            b=new Article();
            a.Initialize();
            b.Initialize();
            a.GetPositiveIndex();
            b.GetPositiveIndex();
            a.GetEmotionalIndex();
            b.GetEmotionalIndex();
            a.ComparePop(b);
            Console.ReadKey(true);
        }
    }
}   

