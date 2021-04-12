using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Welcome to Employee Wage Computation Problem");

            int PRESENT = 1;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empWage = 0;
            Random random = new Random();
            int EmpCheack = random.Next(0, 2);
            if (EmpCheack == PRESENT)
            {
                emphrs = 8;

            }
            else
            {
                emphrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * emphrs;
            Console.WriteLine("Employe Wage Per Day:- " + empWage);
        }
    }
}
