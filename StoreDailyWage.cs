using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class StoreDailyWage: IComputeEmpWage
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public int totalEmpHrs = 0;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        private int MAX_WORKING_HRS;
        private int NUM_WORKING_DAYS;

        public StoreDailyWage()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string COMPANY_NAME, int EMP_WAGE_PER_HR, int NUM_WORKING_DAYS, int MAX_WORKING_HRS)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(COMPANY_NAME, EMP_WAGE_PER_HR, NUM_WORKING_DAYS, MAX_WORKING_HRS);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(COMPANY_NAME, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int totalEmpHrs = 0, empHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_WORKING_HRS && totalWorkingDays < NUM_WORKING_DAYS)
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
            return totalEmpHrs * companyEmpWage.EMP_WAGE_PER_HR;
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpwage;
        }
    }
}
