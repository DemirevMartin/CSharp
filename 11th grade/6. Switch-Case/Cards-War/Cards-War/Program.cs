using System;
namespace Cards-War
{
	class Card
	{
		private int n, m;
		
		public Card(int _n, int _m)
	    {
			m=_m;
			n=_n;
	    }
		public void ShowCard()
		{
			string play="";
			switch(n)
			{ 
				case 7:
					play="seven of ";
				    break;
				case 8:
				    play="eight of ";
				    break;
				case 9:
				    play="nine of ";
				    break;
				case 10:
				    play="ten of ";
				    break;
				case 11:
				    play="jack of ";
				    break;
				case 12:
				    play="queen of ";
				    break;
				case 13:
				    play="king of ";
				    break;
				case 14:
				    play="ace of ";
				    break;
			}
			switch(m)
		    {
				case 1:
					play+="spades";
					break;
				case 2:
					play+="clubs";
					break;
				case 3:
					play+="diamonds";
					break;
				case 4:
					play+="hearts";
					break;
		    }
			Console.WriteLine("Card value: {0}\tSuit: {1}", n, m);
			Console.WriteLine("Card: {0}", play);
			Console.WriteLine(new String('-', 25));
		}
		public void BetterCardThan(Card other)
		{
			int th=this.n;
			int oth=other.n;
			if(th>oth) Console.WriteLine("First player wins!");
			if(th<oth) Console.WriteLine("Second player wins!");
			else Console.WriteLine("War!!!");
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			int card1, color1;
			Random rnd=new Random();
			card1=rnd.Next(7, 15);
			color1=rnd.Next(1, 5);
			Card gamer1=new Card(card1, color1);
			Console.WriteLine("First player card:");
			gamer1.ShowCard();
			
			int card2, color2;
			card2=rnd.Next(7, 15);
			color2=rnd.Next(1, 5);
			Card gamer2=new Card(card2, color2);
			Console.WriteLine("Second player card:");
			gamer2.ShowCard();
			
			gamer1.BetterCardThan(gamer2);
			Console.ReadKey(true);
		}
	}
}