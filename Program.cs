using System;

namespace EmployeeWageComputation
{
    class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Employee Wage Computation Problem");
			EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
			empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
			empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
			empWageBuilder.computeEmpWage();
		}
	}
}

