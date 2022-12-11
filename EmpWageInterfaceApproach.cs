using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class EmpWageInterfaceApproach
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        public EmpWageInterfaceApproach()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string COMPANY_NAME, int EMP_WAGE_PER_HR, int NUM_WORKING_DAYS, int MAX_WORKING_HRS)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(COMPANY_NAME, EMP_WAGE_PER_HR, NUM_WORKING_DAYS, MAX_WORKING_HRS);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {    
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.MAX_WORKING_HRS && totalWorkingDays <= companyEmpWage.NUM_WORKING_DAYS)
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
            return totalEmpHrs * companyEmpWage.EMP_WAGE_PER_HR;
        }
        //static void Main(string[] args)
        //{
        //    multiple("Amazon", 40, 15, 200);
        //    multiple("BigBazar", 20, 20, 100);
        //}
    }
}
