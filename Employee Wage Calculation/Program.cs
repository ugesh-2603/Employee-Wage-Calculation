namespace Employee_Wage_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            Class1 employee = new Class1();
            int totalWage = employee.ComputeWage();
            Console.WriteLine("\n\tEmployee Wage is: " + totalWage);

            Console.ReadLine();
        }
    }
}