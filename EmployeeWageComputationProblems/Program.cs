using System;

namespace EmployeeWageComputationProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation program");
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is prsent");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
 