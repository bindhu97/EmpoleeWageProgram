using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class EmployeeWageCompute
    {
        public static void EmpWage()
        {
            int Full_Time = 1;
            int Emp_Per_Hours = 20;
            int empHrs = 0, empWage;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == Full_Time)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * Emp_Per_Hours;
            Console.WriteLine("Daily Employee Wage : " + empWage);
        }
    }
}