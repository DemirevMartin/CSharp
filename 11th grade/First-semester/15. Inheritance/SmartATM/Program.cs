using System;
namespace SmartATM
{
	public class BankAccount
	{
		protected double balance;
		public BankAccount()
		{
			balance = 0;
		}
		public BankAccount(double b)
		{
			balance = b;
		}
		public virtual void Deposit(double amount)
		{
			balance = balance + amount;
		}
		public virtual void Withdraw(double amount)
		{
			balance = balance - amount;
			if(balance < 0)
			{
				Console.WriteLine("Insufficient availability!");
				balance += amount;
			}
		}
		public void PrintBalance()
		{
			if(balance == 0)
			{
				Console.WriteLine("Balance: 0,00");
			}
			else
			{
				Console.WriteLine("Balance: {0:#.00}", balance);
			}
		}
	}
	class SavingAccount : BankAccount
	{
		private double interestRate, minBalance;
		public SavingAccount()
		{
			interestRate = 0;
			minBalance = 0;
			Console.WriteLine("You have created a Saving Account!");
		}
		public SavingAccount(double rate, double mnBalance, double balance)
			: base (balance)
		{
			interestRate = rate;
			minBalance = mnBalance;
			Console.WriteLine("You have created a Saving Account!");
		}
		public override void Withdraw(double amount)
		{
			base.Withdraw(amount);
			PrintBalance();
		}
		public void MonthEnd()
		{
			balance += balance*interestRate/100;
			PrintBalance();
		}
	}
	class CheckingAccount : BankAccount
	{
		protected int withdraws;
		public CheckingAccount()
		{
			withdraws = 0;
		}
		public CheckingAccount(int wdr, double balance)
			: base(balance)
		{
			withdraws = wdr;
			Console.WriteLine("You have created a Checking Account!");
		}
		public override void Withdraw(double amount)
		{
			base.Withdraw(amount);
			withdraws++;
			if(withdraws > 3)
			{
				balance -= 1;
			}
			PrintBalance();
		}
		public void NewMonth()
		{
			withdraws = 0;
			PrintBalance();
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Select an account:");
			Console.Write("(C) Checking account\t(S) Saving account\t(Q) Quit: ");
			string a = Convert.ToString(Console.ReadLine());
			string j;
			string z;
			if(a == "c" || a == "C")
			{
				CheckingAccount ch = new CheckingAccount(0, 0);
				Console.WriteLine("Select an action:");
				do
				{
					Console.Write("(D) Deposit\t(W) Withdraw\t(N) New month\t(Q) Quit: ");
					j = Convert.ToString(Console.ReadLine());
					if(j == "d" || j == "D")
					{
						Console.Write("What amount do you want to deposit: ");
						double amo = double.Parse(Console.ReadLine());
						ch.Deposit(amo);
						ch.PrintBalance();
					}
					if(j == "w" || j == "W")
					{
						Console.Write("What amount do you want to withdraw: ");
						double amo = double.Parse(Console.ReadLine());
						ch.Withdraw(amo);
					}
					if(j == "n" || j == "N")
					{
						ch.NewMonth();
					}
				}
				while(j != "Q");
				Console.WriteLine("Press any key to continue . . . ");
			}
			if(a == "s" || a == "S")
			{
				SavingAccount sa = new SavingAccount(1, 0, 0);
				Console.WriteLine("Select an action:");
				do
				{
					Console.Write("(D) Deposit\t(W) Withdraw\t(M) Month end\t(Q) Quit: ");
					z = Convert.ToString(Console.ReadLine());
					if(z == "d" || z == "D")
					{
						Console.Write("What amount do you want to deposit: ");
						double amo = double.Parse(Console.ReadLine());
						sa.Deposit(amo);
						sa.PrintBalance();
					}
					if(z == "w" || z == "W")
					{
						Console.Write("What amount do you want to withdraw: ");
						double amo = double.Parse(Console.ReadLine());
						sa.Withdraw(amo);
					}
					if(z == "m" || z == "M")
					{
						sa.MonthEnd();
					}
				}
				while(z != "Q");
				Console.WriteLine("Press any key to continue . . . ");
			}
			if(a == "q" || a == "Q")
			{
				Console.WriteLine("Press any key to continue . . . ");
			}
			
			Console.ReadKey(true);
		}
	}
}