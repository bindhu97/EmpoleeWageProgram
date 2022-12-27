using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class CompanyEmpWage
    {
        public string company;
        public int empRatePerHrs;
        public int numberOfWorkingDays;
        public int maxHrsPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHrs, int numberOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + "is: " + this.totalEmpWage();
        }
    } 
}
