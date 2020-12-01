using System;

namespace EmployeeWageComputationProblems
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        { 
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmployeeHour = 0;
            while(empHrs<= maxHoursPerMonth && totalWorkingDays<= numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmployeeHour+=empHrs;
                Console.WriteLine("Day="+ totalWorkingDays + " Emplyee hours="+ empHrs);
            }
            int totalEmpWages = totalEmployeeHour * empRatePerHour;
            Console.WriteLine("total employee wage for company is="+company+"is"+totalEmpWages);
            return totalEmpWages;    
        }
        static void Main(string[] args)
        {
            computeEmpWage("DMart",20,2,10);
            computeEmpWage("Reliance",10,4,20);
        }
    }
}