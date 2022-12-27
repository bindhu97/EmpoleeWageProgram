using EmployeeWageProgram;
using static EmployeeWageProgram.EmployeeWageCompute;

internal class Program
{
    private static void Main(string[] args)
    {
        EmployeeWageCompute EmpPresentAbsent = new EmployeeWageCompute();
        //EmpPresentAbsent.EmployeePresentAbsent();
        //EmployeeWageCompute.DailyEmployeeWage();
        //EmployeeWageCompute.EmployeePartTimeWage();
        //EmployeeWageCompute.EmployeeWageSwitchCase();
        //EmployeeWageCompute.MonthlyWage();
        //EmployeeWageCompute.TotalWorkingHours();
        //EmployeeWageCompute.Refactor();
        //EmployeeWageCompute.EmployeeWageMultipleCompany("Dmart", 20, 20, 100);
        //EmployeeWageCompute.EmployeeWageMultipleCompany("Reliance", 10, 20, 100);
        EmpWageForMultipleCompany Dmart = new EmpWageForMultipleCompany("Dmart", 20, 20, 100);
        EmpWageForMultipleCompany Reliance = new EmpWageForMultipleCompany("Reliance", 10, 20, 100);
        Dmart.ComputeEmpWage();
        Console.WriteLine(Dmart.ToString());
        Reliance.ComputeEmpWage();
        Console.WriteLine(Reliance.ToString());
    }
}