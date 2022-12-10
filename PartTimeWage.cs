using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class PartTimeWage
    {
        public void PartTime()
        {
            int wagePerHour = 20;
            int fullTimeHour = 8;
            int partTimeHour = 4;
            int dailyWage = 0;

            Random rand = new Random();
            int employeeCheck = rand.Next(0, 3);
            if (employeeCheck == 2)
            {
                dailyWage = fullTimeHour * wagePerHour;
                Console.WriteLine("Employee is present full time");
            }
            else if (employeeCheck == 1)
            {
                dailyWage = partTimeHour * wagePerHour;
                Console.WriteLine("Employee is present half time");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            Console.WriteLine("Employee total wage is: " + dailyWage);
        }
    }
}