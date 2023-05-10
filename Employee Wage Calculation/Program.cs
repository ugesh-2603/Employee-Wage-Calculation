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

            int empHrs = 0;

            int empWage = 0; 
            
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
            Console.WriteLine("Emp Wage: " + empWage);
    
        }
    }
}