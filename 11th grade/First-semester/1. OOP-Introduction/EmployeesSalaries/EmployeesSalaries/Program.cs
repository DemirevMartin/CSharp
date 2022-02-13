using System;
namespace EmployeesSalaries
{
	class Employee
	{
		double hours, salary;
		public void Read()
		{
			Console.Write("Hours: ");
			hours=Convert.ToDouble(Console.ReadLine());
			Console.Write("Salary: ");
			salary=Convert.ToDouble(Console.ReadLine());
		}
		public double CalcTotalSalary()
		{
			return salary*hours;
		}
		public void PrintTotal()
		{
			Console.WriteLine("Total salary (hours*salary): "+CalcTotalSalary().ToString("f2"));
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Employee m15=new Employee();
			m15.Read();
			m15.PrintTotal();
			
			Console.ReadKey(true);
		}
	}
}