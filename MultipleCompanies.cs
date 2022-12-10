using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class MultipleCompanies
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public static int multiple(string company, int wageRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int totalEmpHrs = 0, empHrs = 0, totalWorkingDays = 0, day = 1;
            Console.WriteLine("Details of " + company + " employee");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Wage Rate per hour:" + wageRatePerHour);
            Console.WriteLine("Number working days:" + numOfWorkingDays);
            Console.WriteLine("Maximum Hours Per Month:" + maxHoursPerMonth);
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empType = random.Next(0, 3);
                switch (empType)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * wageRatePerHour;
            Console.WriteLine("Total Empwage for a month of: " + company + " employee is " + totalEmpWage);
            return totalEmpWage;
        }
        //static void Main(string[] args)
        //{
        //    multiple("Amazon", 40, 15, 200);
        //    multiple("BigBazar", 20, 20, 100);
        //}
    }
}
