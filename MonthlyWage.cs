using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class MonthlyWage
    {
        public void monthy()
        {
            int wagePerHour = 20;
            int fullTimeHour = 8;
            int partTimeHour = 4;
            int workingDays = 20;
            int dailyWage = 0;
            decimal monthlyWage;

            for (int day = 0; day <= workingDays; day++)
            {
                Random rand = new Random();
                int employeeCheck = rand.Next(0, 3);
                switch (employeeCheck)
                {
                    case 2:
                        dailyWage = dailyWage + fullTimeHour * wagePerHour;
                        Console.WriteLine("Employee is present full time: " + dailyWage);
                        break;
                    case 1:
                        dailyWage = dailyWage + partTimeHour * wagePerHour;
                        Console.WriteLine("Employee is present half time: " + dailyWage);
                        break;
                    default:
                        Console.WriteLine("Employee is absent: " + dailyWage);
                        break;
                }
            }
            monthlyWage = (wagePerHour * (decimal)workingDays);
            Console.WriteLine("Employee total wage for month is: " + dailyWage);
        }
    }
}
