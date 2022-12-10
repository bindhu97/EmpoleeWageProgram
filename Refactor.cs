using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class Refactor
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public const int WAGE_PER_HR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_WORKING_HRS = 100;

        public int Refactor1()
        {
            int totalWage = 0, day = 1, workingHrs = 0, totalWorkingDays = 0, totalWorkingHrs = 0;
            Console.WriteLine("Day" + "Workinghrs" + "Wage" + "Total working hrs");
            while (totalWorkingDays < MAX_WORKING_DAYS && totalWorkingHrs <= MAX_WORKING_HRS)
            {
                totalWorkingDays++;
                Random rand = new Random();
                int empType = rand.Next(0, 3);
                switch (empType)
                {
                    case 1:
                    FULL_TIME:
                        workingHrs = 8;
                        break;
                    case 2:
                    PART_TIME:
                        workingHrs = 4;
                        break;
                    default:
                        workingHrs = 0;
                        break;
                }
                totalWorkingHrs += workingHrs;
                Console.WriteLine("day:" + totalWorkingHrs + "WorkingHrs:" + workingHrs);
            }
            int totalEmpwage = totalWorkingHrs * WAGE_PER_HR;
            Console.WriteLine("Total Emp wage for a month is " + totalEmpwage);
            return totalWage;
        }
    }
}
