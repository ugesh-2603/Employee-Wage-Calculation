﻿namespace Employee_Wage_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation");
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {

                Console.WriteLine("Employee is Present");

            }

            else

            {

                Console.WriteLine("Employee is Absent");

            }
        }
    }
}