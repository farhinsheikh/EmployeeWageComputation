using System;

namespace EmployeeWageComputation
{
    class Program
	{
		//const int EmpWagePerHr = 20;
		//const int Num_Of_Working_Days = 20;
		//const int Max_Working_Hrs = 100;
		const int Is_FullTime = 1;
		const int Is_PartTime = 2;
		public static int computeEmpWage(string company, int EmpRatePerHr, int Num_of_Working_Days, int MaxHrsPerMonth)
		{
			int EmpHrs = 0, EmpWage = 0, TotalHrs = 0, WorkingDays = 0;
			while (TotalHrs < MaxHrsPerMonth && WorkingDays < Num_of_Working_Days)
			{
				WorkingDays++;
				Random random = new Random();
				int empCheck = random.Next(1, 3);
				switch (empCheck)
				{
			     case Is_FullTime:
				 EmpHrs = 8;
				 break;
				 case Is_PartTime:
				 EmpHrs = 4;		
				 break;
				 default:
				 EmpHrs = 0;
				 break;
				}
				TotalHrs = TotalHrs + EmpHrs;
				Console.WriteLine(" Day : " + WorkingDays + " Employee Hrs : " + TotalHrs);
			}
			EmpWage = EmpHrs * EmpRatePerHr;
			Console.WriteLine("Total Emp Wages = " + EmpWage);
			return EmpWage;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Employee Wage Computation Problem");
			Console.WriteLine("Employee wage for DMart");
			computeEmpWage("DMart", 20, 2, 10);
			Console.WriteLine("Employee wage for Reliance");
			computeEmpWage("Reliance", 10, 4, 20);
		}
	}
}
