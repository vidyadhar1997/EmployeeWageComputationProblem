using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageComputationProblems
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWages;
        public int dailyWage;
        public int totalWageAlongWithDailyWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWages)
        {
            this.totalEmpWages = totalEmpWages;
        }

        public string toString()
        {
            return "Total emp wages for company " + this.company + " is= " + this.totalEmpWages;
        }
    }
}

