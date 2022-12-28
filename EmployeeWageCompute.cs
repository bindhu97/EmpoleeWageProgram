using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class EmployeeWageCompute
    {
        public const int fullTime = 2;
        public const int partTime = 1;

        private string company;
        private int empRatePerHrs;
        private int numberOfWorkingDays;
        private int maxHrsPerMonth;
        private int totalEmpWage;
        public EmployeeWageCompute(string company, int empRatePerHrs, int numberOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHrsPerMonth && totalWorkingDays < this.numberOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case fullTime:
                        empHrs = 8;
                        break;
                    case partTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days " + totalWorkingDays + "EmpHrs: " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHrs;
            Console.WriteLine("Total Emp Wage for company: " + company + " is " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is " + this.totalEmpWage;
        }
    }
}