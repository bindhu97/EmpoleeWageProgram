using System;

namespace EmployeeWageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageCompute Dmart = new EmployeeWageCompute("Dmart", 20, 2, 10);
            EmployeeWageCompute Reliance = new EmployeeWageCompute("Reliance", 20, 4, 10);
            Dmart.computeEmpWage();
            Console.WriteLine(Dmart.toString());
            Reliance.computeEmpWage();
            Console.WriteLine(Reliance.toString());
        }
    }
}