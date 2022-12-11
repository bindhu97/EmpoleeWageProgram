using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class CompanyEmpWage
    {
        public string COMPANY_NAME;
        public int EMP_WAGE_PER_HR;
        public int NUM_WORKING_DAYS;
        public int MAX_WORKING_HRS;
        public int totalEmpwage;

        public CompanyEmpWage(string COMPANY_NAME, int EMP_WAGE_PER_HR, int NUM_WORKING_DAYS, int MAX_WORKING_HRS)
        {
            this.COMPANY_NAME = COMPANY_NAME;
            this.EMP_WAGE_PER_HR = EMP_WAGE_PER_HR;
            this.NUM_WORKING_DAYS = NUM_WORKING_DAYS;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
        }
        public void setTotalEmpWage(int totalEmpwage)
        {
            this.totalEmpwage = totalEmpwage;
        }
        public string toString()
        {
            return "Total Emp wage for a company: " + this.COMPANY_NAME + "is: " + this.totalEmpwage;
        }
    }
}
