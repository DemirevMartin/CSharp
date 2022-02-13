using System;
namespace Lakes
{
	class BGLake
    {
        string name;
        int area;
        double depth;
        
        public BGLake()
        {
            Console.WriteLine("Creating a lake object!");
            Console.Write("What's the name of this lake? ");
            name=Console.ReadLine();
            Console.Write("How big is this lake? (sq. mt) ");
            area=Int32.Parse(Console.ReadLine());
            Console.Write("How deep is this lake? ");
            depth=double.Parse(Console.ReadLine());
            Console.WriteLine("------End of constructor------");
        }
        public BGLake(string nm, int ar, double dp)
        {
            this.name=nm;
            this.area=ar;
            this.depth=dp;
            Console.WriteLine("Creating a lake object!");
            Console.WriteLine("------End of constructor------");
        }
        public void EditArea(int newArea)
        {
            Console.WriteLine("Lake " + name + " area editted. Old value: "+ area + " New value: " + newArea);
            area = newArea;
        }
        public void EditName(string newName)
        {
            Console.WriteLine("Lake "+ name + " name editted. Old value: "+ name + "New value: "+newName);
            name=newName;
        }
        public void Print()
        {
            Console.WriteLine("Lake: " + name);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Depth: " + depth);
            Console.WriteLine();
        }
        public void IsBiggerThan(BGLake other)
        {
        	if(this.area>other.area) 
        	{
        		Console.WriteLine("Lake " + this.name +" is bigger than lake " + other.name + ".");
        	}
        	else if(area<other.area) 
        	{
        		Console.WriteLine("Lake " + other.name +" is bigger than lake " + this.name + ".");
        	}
        	else 
        	{
        		Console.WriteLine(name + "'s area is equal to "+ other.name + "'s area");
        	}
        }
        public void IsDeeperThan(BGLake other)
        {
        	if(this.depth>other.depth) 
        	{
        		Console.WriteLine("Lake " + this.name +" is bigger than lake " + other.name + ".");
        	}
        	else if(this.area<other.area) 
        	{
        		Console.WriteLine("Lake " + other.name + " is bigger than lake " + this.name + ".");
        	}
        	else 
        	{
        		Console.WriteLine(this.name + "'s depth is equal to "+ other.name + "'s depth");
        	}
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
        	BGLake m1=new BGLake();
            m1.Print();
            BGLake m2 = new BGLake("Mokroto ezero", 16500, 12.5);
            m2.Print();
            m1.EditArea(12000);
            m1.EditName("Lokvata");
            m1.IsBiggerThan(m2);
            m1.IsDeeperThan(m2);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}