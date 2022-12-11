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

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

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
            return this.companyEmpWageList.Count;
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpwage;
        }
    }
}
