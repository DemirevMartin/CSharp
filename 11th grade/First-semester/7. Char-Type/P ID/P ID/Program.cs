/*
 * Created by SharpDevelop.
 * User: zlati
 * Date: 29.10.2020 г.
 * Time: 07:33 ч.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace P_ID
{
	class Personal_Id
	{
		string pid, status;
		bool isOK;
		public Personal_Id (string t)
		{
			pid=t;
			CheckStatus();
		}
		void CheckStatus()
		{
			if(pid.Length!=10)
			{
				isOK=false;
				status="Incorrect number of symbols";
				return;
			}
			// Всеки от символите е десетична цифра.
			for(int i=0;i<pid.Length;i++)
			{
				if(! char.IsDigit(pid[i]))
				{
				   	isOK=false;
				   	status="Invalid symbol(s) detected";
				   	return;
				}
			}
			int year,month,day;
			year=1900 + (pid[0] - '0')*10 + (pid[1]-'0');
			month=(pid[2] - '0')*10 + (pid[3]-'0');
			day=(pid[4]-'0')*10 + (pid[5]-'0');
			if(month>40 && month<53)
			{
				year+=100;
				month-=40;
			}
			DateTime bd;
			// Проверка за валидност.
			try
			{
				bd=new DateTime(year,month,day);
			}
			catch (Exception)
			{
				isOK=false;
				status="Incorrect date";
				return;
			}
			
			int sum=(pid[0]-'0')*2 + (pid[1]-'0')*4 + (pid[2]-'0')*8 + (pid[3]-'0')*5 + (pid[4]-'0')*10 +
				(pid[5]-'0')*9 + (pid[6]-'0')*7 + (pid[7]-'0')*3 + (pid[8]-'0')*6;
			if((sum % 11) % 10 !=(pid[9]-'0'))
			{
				isOK=true;
				status="Icorrect control digit";
				return;
			}
			isOK=true;
			status=string.Format("Birth date: {0, -15:dd.MM.yyyy}sex: ", bd);
			
			if((pid[8]-'0') % 2 == 0)
			{
				status+="male";
			}
			else 
			{
				status+="female";
			}
		}
		public void PrintInfo()
		{
			if(isOK)
			{
				Console.WriteLine("{0} is a valid PID record" + Environment.NewLine + "Record data:{2}{1}", 
				                 pid, status, Environment.NewLine);
			}
			else
			{
				Console.WriteLine("{0} is NOT a valid PID record" + Environment.NewLine + "Error: {1}", pid, status);
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter a test data: ");
			Personal_Id p = new Personal_Id(Console.ReadLine());
			p.PrintInfo();
				
			Console.ReadKey(true);
		}
	}
}