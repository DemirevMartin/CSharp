/*
 * Created by SharpDevelop.
 * User: User
 * Date: 24.10.2020 г.
 * Time: 15:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Age_in_words
{
	class Age
    {
        private int y;
        public Age(int _y)
        {
            y=_y;
        }
        public void ShowAgeInWords()
        { 
        	int mod=y%10;
        	int h=y/10;
            string one="";
            
            switch (h)
            {
                case 2:
                    one="twenty";
                    break;
                case 3:
                    one="thirty";
                    break;
                case 4:
                    one="forty";
                    break;
                case 5:
                    one="fifty";
                    break;
                case 6:
                    one="sixty";
                    break;                    
            }
            
            switch(mod)
            {    
                case 1: one+="-one years"; break;
                case 2: one+="-two years"; break;
                case 3: one+="-third years"; break;
                case 4: one+="-four years"; break;
                case 5: one+="-five years"; break;
                case 6: one+="-six years"; break;
                case 7: one+="-seven years"; break;
                case 8: one+="-eight years"; break;
                case 9: one+="-nine years"; break;
                default: one+=" years"; break;
            }
            Console.WriteLine(one);
        }
        public void OlderPersonThan(Age other)
        {
            int th=this.y;
            int oth=other.y;
            if(th>oth) Console.WriteLine("The first person is older than the second.");
            else if(th<oth) Console.WriteLine("The second person is older than the first.");
            else Console.WriteLine("They are both the same age.");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
        	Random rnd=new Random();
        	int years1;
        	years1=rnd.Next(20, 70);
        	Age person1=new Age(years1);
        	Console.Write("Age of the first person is: ");
        	person1.ShowAgeInWords();
        	
        	int years2;
        	years2=rnd.Next(20, 70);
        	Age person2=new Age(years2);
        	Console.Write("Age of the second person is: ");
        	person2.ShowAgeInWords();
        	
        	person1.OlderPersonThan(person2);
            Console.ReadKey(true);
        }
    }
}
