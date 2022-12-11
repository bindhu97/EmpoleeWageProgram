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
                "8) Find Employee Wage For Multiple Companies\n" + 
                "9) Find Employee Wage & Save TotalWage by each Company\n" + 
                "10) Find Employee Wage In Multiple Companies using Interface Approach\n" + 
                "11) Find Employee Store Daily Wage Aong With Total Wage\n");
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

                    case 9:
                    Console.WriteLine("Employee Wage & Save total wage by each Company");
                    SaveTotalWage Amazon = new SaveTotalWage("Amazon", 40, 15, 200);
                    SaveTotalWage BigBazar = new SaveTotalWage("BigBazar", 20, 20, 100);
                    Amazon.computeEmpWage();
                    Console.WriteLine(Amazon.ToString());
                    BigBazar.computeEmpWage();
                    Console.WriteLine(BigBazar.ToString());
                    break;

                    case 10:
                        EmpWageInterfaceApproach empWageInterface = new EmpWageInterfaceApproach();
                    empWageInterface.addCompanyEmpWage("Amazon", 40, 15, 200);
                    empWageInterface.addCompanyEmpWage("BigBazar", 20, 20, 100);
                    empWageInterface.computeEmpWage();
                    break;

                    case 11:
                        StoreDailyWage storeDailyWage = new StoreDailyWage();
                    storeDailyWage.addCompanyEmpWage("Amazon", 40, 15, 200);
                    storeDailyWage.addCompanyEmpWage("BigBazar", 20, 20, 100);
                    storeDailyWage.computeEmpWage();
                    Console.WriteLine("Total Wage for Amazon Company: " + storeDailyWage.getTotalWage("Amazon"));
                    Console.WriteLine("Total Wage for BigBazar Company: " + storeDailyWage.getTotalWage("BigBazar"));
                    break;

                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}







