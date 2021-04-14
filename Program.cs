using System;

namespace EmployeeWageComputation
{
    class Program
    { 
        public const int FULL_TIME = 1;     
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void Main(string[] args)      
        {
            int emphrs = 0;
            int empWage = 0;
            Random random = new Random();
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
            // Calculate empWage
            empWage = EMP_RATE_PER_HOUR * emphrs;       
            Console.WriteLine("Employe Wage Per Day:- " + empWage);     
        }
    }
}
