using System;
namespace Код_на_Цезар
{
	static class Caesаr
	{
		public static string CodeIt(string message)
		{
			string code = "";
			for(int i = 0; i < message.Length; i++)
		    {
				char mes = message[i];
			    for(char c = 'a'; c <= 'z'; c++)
			    {
			    	if(c == mes)
					{
						if(c == 'z')
						{
							c = 'a';
						}
						else
						{
							c++;
						}
						code += c.ToString().ToUpper();
						break;
			    	}
				}
			}
			return code;
		}
		public static string CodeIt(string message, int step)
		{
			string code = "";
			for(int i = 0; i < message.Length; i++)
		    {
				char mes = message[i];
			    for(char c = 'a'; c <= 'z'; c++)
			    {
			    	if(c == mes)
					{
			    		for(int j = 1; j <= step; j++)
			    		{
			    			if(c == 'z')
						    {
							    c++;
							    c = 'a';
						    }
						    else
						    {
							    c++;
						    }
			    		}
			    		code += c.ToString().ToUpper();
						break;
			    	}
				}
			}
			return code;
		}
		public static string CodeIt(string message, char was, char toBe)
        {
            string code = "";
            int interactions = 0;
            for (char a = was; a < toBe; a++)
            {
                interactions++;
            }
            
            for(int i = 0; i < message.Length; i++)
		    {
				char mes = message[i];
			    for(char c = 'a'; c <= 'z'; c++)
			    {
			    	if(c == mes)
					{
			    		for(int j = 1; j <= interactions; j++)
			    		{
			    			if(c == 'z')
						    {
							    c++;
							    c = 'a';
						    }
						    else
						    {
							    c++;
						    }
			    		}
			    		code += c.ToString().ToUpper();
						break;
			    	}
				}
			}
			return code;
        }
		public static string DecodeIt(string message)
		{
			string decode = "";
			for(int i = 0; i < message.Length; i++)
		    {
				char mes = message[i];
			    for(char c = 'z'; c >= 'a'; c--)
			    {
			    	if(c == mes)
					{
						if(c == 'a')
						{
							c = 'z';
						}
						else
						{
							c--;
						}
						decode += c.ToString().ToUpper();
						break;
			    	}
				}
			}
			return decode;
		}
		public static string DecodeIt(string message, int step)
		{
			string decode = "";
			for(int i = 0; i < message.Length; i++)
		    {
				char mes = message[i];
			    for(char c = 'z'; c >= 'a'; c--)
			    {
			    	if(c == mes)
					{
			    		for(int j = 1; j <= step; j++)
			    		{
			    			if(c == 'a')
						    {
						 	    c = 'z';
						    }
						    else
						    {
							    c--;
						    }
			    		}
			    		decode += c.ToString().ToUpper();
						break;
			    	}
				}
			}
			return decode;
		}
		public static string DecodeIt(string message, char was, char toBe)
		{
			string decode = "";
            int interactions = 0;
            for (char a = toBe; a < was; a++)
            {
                interactions++;
            }
            
            for(int i = 0; i < message.Length; i++)
		    {
				char mes = message[i];
			    for(char c = 'z'; c >= 'a'; c--)
			    {
			    	if(c == mes)
					{
			    		for(int j = 1; j <= interactions; j++)
			    		{
			    			if(c == 'a')
						    {
							    c--;
							    c = 'z';
						    }
						    else
						    {
							    c--;
						    }
			    		}
			    		decode += c.ToString().ToUpper();
						break;
			    	}
				}
			}
			return decode;
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{ 
			Console.WriteLine("Въведете текст за кодиране:");
			string a = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Изберете вид на кодирането: 1) С едно напред   2) С посочена стъпка   3) С посочени символи");
			int type = int.Parse(Console.ReadLine());
			
			if(type == 1)
			{
				Console.WriteLine("Кодиран текст:");
				Console.WriteLine(Caesаr.CodeIt(a));
			}
			else if(type == 2)
			{
				Console.Write("Посочете стъпка за кодиране: ");
				int s = int.Parse(Console.ReadLine());
				Console.WriteLine("Кодиран текст:");
			    Console.WriteLine(Caesаr.CodeIt(a, s));
			}
			else if(type == 3)
            {
                Console.Write("Посочете стар символ: ");
                char o = char.Parse(Console.ReadLine());
                Console.Write("Посочете нов символ: ");
                char n = char.Parse(Console.ReadLine());
                Console.WriteLine("Кодиран текст:");
                Console.WriteLine(Caesаr.CodeIt(a, o, n));
            }
			
			// Decoding
			
			Console.WriteLine("Въведете текст за декодиране:");
			string b = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Изберете вид на кодирането: 1) С едно напред   2) С посочена стъпка   3) С посочени символи");
			int m = int.Parse(Console.ReadLine());
			if(m == 1)
			{
				Console.WriteLine("Декодиран текст:");
		        Console.WriteLine(Caesаr.DecodeIt(b));
			}
			else if(m == 2)
			{
				Console.Write("Посочете стъпка за декодиране: ");
				int p = int.Parse(Console.ReadLine());
				Console.WriteLine("Декодиран текст:");
		        Console.WriteLine(Caesаr.DecodeIt(b, p));
			}
		    else if(m == 3)
            {
                Console.Write("Посочете стар символ: ");
                char q = char.Parse(Console.ReadLine());
                Console.Write("Посочете нов символ: ");
                char z = char.Parse(Console.ReadLine());
                Console.WriteLine("Декодиран текст:");
                Console.WriteLine(Caesаr.DecodeIt(b, q, z));
            }
			Console.ReadKey(true);
		}
	}
}
