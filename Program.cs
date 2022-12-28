// See https://aka.ms/new-console-template for more information
using EmployeeWage;

Console.WriteLine("Welcome to Employee Wage Computation Program");

Console.WriteLine("Calling Employee Present or Absent");
EmployeeWageCompute emppresentabsent = new EmployeeWageCompute();
emppresentabsent.PresentAbsent();
