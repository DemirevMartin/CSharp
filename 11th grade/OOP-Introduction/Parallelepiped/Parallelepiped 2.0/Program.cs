using System;
namespace Parallelepiped
{
	class RPrlpd
	{
		double length, width, height;
		Random r=new Random();
		
		public void GenerateDimensions()
		{
			length=r.Next(0,101);
			width=r.Next(0,101);
			height=r.Next(0,101);
		}
		public void BriefData()
		{
			Console.WriteLine("Parallelepiped");
			Console.WriteLine("Length: "+length);
			Console.WriteLine("Width: "+width);
			Console.WriteLine("Height: "+height);
		}
		public double GetSurfaceArea()
		{
			return 2*(length*width+length*height+width*height);
		}
		public double GetVolume()
		{
			return length*width*height;
		}
		public void ChangeDimsBy(double d1, double d2, double d3)
		{
			if (length+d1>0)
			{
				length+=d1;
				Console.WriteLine("Length changed successfully by {0}", d1);
			}
			if(width+d2>0)
			{
				width+=d2;
				Console.WriteLine("Length changed successfully by {0}", d2);
			}
			if(height+d3>0)
			{
				height+=d3;
				Console.WriteLine("Length changed successfully by {0}", d3);
			}
		}
		public void Info()
		{
			BriefData();
			Console.WriteLine("SurfaceArea: "+GetSurfaceArea());
			Console.WriteLine("Volume: "+GetVolume());
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			RPrlpd p1=new RPrlpd();
			p1.GenerateDimensions();
			p1.BriefData();
			Random r=new Random();
			p1.ChangeDimsBy(-10 + 20*r.NextDouble(), -10 + 20*r.NextDouble(), -10 + 20*r.NextDouble());
			p1.Info();
			Console.ReadKey(true);
		}
	}
}