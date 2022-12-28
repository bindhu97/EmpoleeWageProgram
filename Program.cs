using System;

namespace EmployeeWageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageCompute.computeEmpWage("DMart", 20, 2, 10);
            EmployeeWageCompute.computeEmpWage("Reliance", 20, 4, 10);
        }
    }
}