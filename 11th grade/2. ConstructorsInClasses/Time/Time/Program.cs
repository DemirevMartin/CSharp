using System;
namespace Time
{
    class Time
    {
        int minutes, seconds;
        
        public Time()
        {
            minutes=1;
            seconds=1;
        }
        public Time(int mi, int se)
        {
            minutes=mi;
            seconds=se;
        }
        public void Normalize()
        {
        	if(seconds>60) minutes=minutes+seconds/60;
        	seconds=seconds%60;
        }
        public int GetTimeInSeconds()
        {
            return minutes*60+seconds;
        }
        public void AddSeconds(int sec)
        {
            seconds+=sec;
            Normalize();
        }
        public void PrintTime()
        {
        	Console.WriteLine("Time interval");
        	if(minutes<10) Console.Write("0"+minutes+":");
        	else Console.Write(minutes+":");
        	if(seconds<10) Console.WriteLine("0"+seconds);
        	else Console.WriteLine(seconds);
        	Console.WriteLine("In Seconds: " + GetTimeInSeconds());
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
        	Time t1=new Time();
        	t1.AddSeconds(239);
        	t1.PrintTime();
        	int min, s;
        	Console.Write("Enter minutes: ");
        	min=Int32.Parse(Console.ReadLine());
        	Console.Write("Enter seconds: ");
        	s=Int32.Parse(Console.ReadLine());
        	Time t2=new Time(min, s);
        	t2.AddSeconds(239);
        	t2.PrintTime();
        
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}