using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageComputationProblems
{
    class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        LinkedList<CompanyEmpWage> companyEmpWageList;
        Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company,companyEmpWage);
        }

        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmployeeHour = 0;
            while (totalEmployeeHour <= companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage.numOfWorkingDays)
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
                totalEmployeeHour += empHrs;
                Console.WriteLine("Day=" + totalWorkingDays + " Emplyee hours=" + empHrs);
            }
            companyEmpWage.dailyWage = empHrs * companyEmpWage.empRatePerHour;
            Console.WriteLine("Daily employee wages is = " + companyEmpWage.dailyWage);
            companyEmpWage.totalWageAlongWithDailyWage = totalEmployeeHour * companyEmpWage.empRatePerHour + companyEmpWage.dailyWage;
            Console.WriteLine("total wage along with daily wage = "+ companyEmpWage.totalWageAlongWithDailyWage);
            return totalEmployeeHour * companyEmpWage.empRatePerHour;
        }

        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWages;
        }
    }
}    


