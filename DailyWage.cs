using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class DailyWage
    {
        public void EmployeeWage()
        {
            int wagePerHour = 20;
            int fullDayHour = 8;
            int dailyWage = 0;
            Random rand = new Random();
            int employeeCheck = rand.Next(0, 2);

            if (employeeCheck == 1)
            {
                dailyWage = fullDayHour * wagePerHour;
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            Console.WriteLine("Employee total wage is: " + dailyWage);
        }
    }
}