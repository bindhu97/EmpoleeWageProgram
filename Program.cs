using EmployeeWageProgram;

public class Program
{
    public static void Main(string[] args)
    {
        bool check = true;
        while (check)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Select Option:\n" +
                "1) Find Employee Present or Absent\n" +
                "2) Find Employee Daily Wage\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Calling Employee Present or Absent");
                    EmpPresentAbsent emppresentabsent = new EmpPresentAbsent();
                    emppresentabsent.PresentAbsent();
                    break;

                case 2:
                    Console.WriteLine("Calling Employee Present or Absent");
                    DailyWage dailyWage = new DailyWage();
                    dailyWage.EmployeeWage();
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}







