using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class EmployeeWageCompute
    {
        public static void PresentAbsent()
        {
            int Full_Time = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}