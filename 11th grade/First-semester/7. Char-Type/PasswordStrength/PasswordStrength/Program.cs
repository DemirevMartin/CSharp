using System;

namespace PasswordStrength
{
	class PasswordStrength
    {
        string pswd;
        int strength;
        public PasswordStrength (string pass)
        {
            pswd=pass;
            strength=GetStrength();
        }
        public int GetStrength()
        {
            int a=0, b=0, c=0, m=0;
            if(pswd.Length>=12) { strength++; }
            for (int i = 0;i<pswd.Length; i++)
            {
                if(Char.IsUpper(pswd[i])){ a=1; }
                if(Char.IsLower(pswd[i])){ b=1; }
                if(Char.IsNumber(pswd[i])){ c=1; }
                if(Char.IsSymbol(pswd[i]) || Char.IsPunctuation(pswd[i])){ m=1; }
            }
            strength = strength +a+b+c+m;
            return strength;
        }
        public void PrintEvaluation()
        {
            if(strength==0){ Console.WriteLine("This password is a failure – 0 / 5"); }
            if(strength==1){ Console.WriteLine("This password is extremely weak – 1 / 5"); }
            if(strength==2){ Console.WriteLine("This password is weak – 2 / 5"); }
            if(strength==3){ Console.WriteLine("This password is not strong enough – 3 / 5"); }
            if(strength==4){ Console.WriteLine("This password is relatively strong – 4 / 5"); }
            if(strength==5){ Console.WriteLine("This password is strong enough – 5 / 5"); }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a password to check its strength: ");
            string z = Console.ReadLine();
            PasswordStrength pass = new PasswordStrength(z);
            pass.PrintEvaluation();
            Console.ReadKey(true);
        }
    }
}
