using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Welcome to Employee Wage Computation Problem");
           
            int PRESENT = 1;
            Random random = new Random();
            int EmpCheack = random.Next(0, 2);
            if (EmpCheack == 1)
            {
             Console.WriteLine("Employee Is Present");
            }
            else
            {
             Console.WriteLine("Employe Is Absent");
            }
        }
    }
}
