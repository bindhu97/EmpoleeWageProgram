using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class SaveTotalWage
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

        private string COMPANY_NAME;
        private int EMP_WAGE_PER_HR;
        private int NUM_WORKING_DAYS;
        private int MAX_WORKING_HRS;
        private string totalEmpwage;

        public SaveTotalWage(string COMPANY_NAME, int EMP_WAGE_PER_HR, int NUM_WORKING_DAYS, int MAX_WORKING_HRS)
        {
            this.COMPANY_NAME = COMPANY_NAME;
            this.EMP_WAGE_PER_HR = EMP_WAGE_PER_HR;
            this.NUM_WORKING_DAYS = NUM_WORKING_DAYS;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
        }
        public int computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.MAX_WORKING_HRS && totalWorkingDays < this.NUM_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
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
                Console.WriteLine("Days:" + totalWorkingDays + "EmpHrs:" + empHrs);
            }
            int totalEmpwage = totalWorkingDays * EMP_WAGE_PER_HR;
            Console.WriteLine("Total Emp wage for a company: " + COMPANY_NAME + "is: " + totalEmpwage);
            return totalEmpwage;
        }
        //static void Main(string[] args)
        //{
        //    multiple("Amazon", 40, 15, 200);
        //    multiple("BigBazar", 20, 20, 100);
        //}
    }
}
