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
                "2) Find Employee Daily Wage\n" + 
                "3) Find Employee PartTime Wage\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Employee Present or Absent");
                    EmpPresentAbsent emppresentabsent = new EmpPresentAbsent();
                    emppresentabsent.PresentAbsent();
                    break;

                case 2:
                    Console.WriteLine("Employee Daily Wage");
                    DailyWage dailyWage = new DailyWage();
                    dailyWage.EmployeeWage();
                    break;

                    case 3:
                    Console.WriteLine("Employee PartTime Wage");
                    PartTimeWage partTimeWage = new PartTimeWage();
                    partTimeWage.PartTime();
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}







