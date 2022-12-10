using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class TotalWorkingHours
    {
        public void WorkingHourWage()
        {
            int wagePerHour = 20;
            int fullTimeHour = 8;
            int partTimeHour = 4;
            int totalWorkingDays = 0;
            int totalHour = 0;
            int totalDailyWage = 0;

            while (totalHour < 100 && totalWorkingDays < 20)
            {
                Random rand = new Random();
                int employeeCheck = rand.Next(0, 3);
                totalWorkingDays++;

                switch (employeeCheck)
                {
                    case 2:
                        totalHour = totalHour + fullTimeHour;
                        totalDailyWage = totalDailyWage + fullTimeHour * wagePerHour;
                        Console.WriteLine("Employee is present full time: " + totalDailyWage);
                        break;
                    case 1:
                        totalHour = totalHour + partTimeHour;
                        totalDailyWage = totalDailyWage + partTimeHour * wagePerHour;
                        Console.WriteLine("Employee is present half time: " + totalDailyWage);
                        break;
                    default:
                        Console.WriteLine("Employee is absent: " + totalDailyWage);
                        break;
                }
                Console.WriteLine("Working Days is: " + totalWorkingDays + " Hours: " + totalHour);
            }
            Console.WriteLine("Employee total wage for month is: " + totalDailyWage);
        }
    }
}
