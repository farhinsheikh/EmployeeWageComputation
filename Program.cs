using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;

        public static void Main(string[] args)
        {
         int emphrs = 0;
         int empWage = 0;
         int totalempwage = 0;
         int hrs = 0;
         int workingDays = 1;
         Random random = new Random();
         while (hrs < MAX_WORKING_HRS && workingDays <= MAX_WORKING_DAYS)
         {
              workingDays++;
              int EmpCheack = random.Next(0, 3);
              switch (EmpCheack)
              {
                case FULL_TIME:
                emphrs = 8;
                break;
                case PART_TIME:
                emphrs = 4;
                break;
                default:
                emphrs = 0;
                break;
              }
                empWage = EMP_RATE_PER_HOUR * emphrs;
                hrs += emphrs;
                totalempwage = totalempwage + empWage;
         }
            Console.WriteLine("Employe Wage Per Day :- " + empWage);
            Console.WriteLine("Total Employe Month Wage :- " + totalempwage);
            Console.WriteLine("Employee wage for " + workingDays + " days " + totalempwage);
            Console.WriteLine("Working hours " + hrs);
        }
    }
}