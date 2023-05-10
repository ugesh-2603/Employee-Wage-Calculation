namespace Employee_Wage_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation");

            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;

            const int EMP_RATE_PER_HOUR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HOURS = 100;

            int empHrs = 0;

            int empWage = 0;

            int totalWage = 0;

            int day = 1;

            int totalWrkHrs = 0;

            while (day <= MAX_WORKING_DAYS && totalWrkHrs <= MAX_WORKING_HOURS)
            {
                Random random = new Random();

                int empCheck = random.Next(0, 3);

                switch (empCheck)

                {
                    case IS_PART_TIME:
                        Console.WriteLine("Parttime Employee is Present");
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        Console.WriteLine("Fulltime Employee is Present");
                        empHrs = 8;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;

                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalWage += empWage;
                totalWrkHrs += empHrs;
                Console.WriteLine("Emp Wage for Day {0}: {1} ", day , empWage);
                day++;
            }
            Console.WriteLine("\n\nEmployee Wage for {0} Days & {1} Hours is: {2}", day - 1, totalWrkHrs, totalWage);
            Console.ReadLine();
        }
    }
}