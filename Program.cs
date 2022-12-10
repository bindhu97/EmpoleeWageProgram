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
                "3) Find Employee PartTime Wage\n" +
                "4) Find Switch Case Condition\n" + 
                "5) Find Employee Monthly Wage\n" + 
                "6) Find Employee Total Working Hours\n" + 
                "7) Find Refactor method\n" + 
                "8) Find Employee Wage For Multiple Companies\n");
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

                case 4:
                    Console.WriteLine("Switch Case Condition");
                    SwitchCase switchCase = new SwitchCase();
                    switchCase.Switch();
                    break;

                    case 5:
                    Console.WriteLine("Employee Monthly Wage");
                    MonthlyWage monthlyWage = new MonthlyWage();
                    monthlyWage.monthy();
                    break;

                case 6:
                    Console.WriteLine("Employee Total Working Hours");
                    TotalWorkingHours totalWorkingHours = new TotalWorkingHours();
                    totalWorkingHours.WorkingHourWage();
                    break;

                    case 7:
                    Console.WriteLine("Refactor method");
                    Refactor refactor = new Refactor();
                    refactor.Refactor1();
                    break;

                    case 8:
                    Console.WriteLine("Employee Wage For Multiple Companies");
                    MultipleCompanies company = new MultipleCompanies();
                    MultipleCompanies.multiple("Amazon", 40, 15, 200);
                    MultipleCompanies.multiple("BigBazar", 20, 20, 100);
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}







