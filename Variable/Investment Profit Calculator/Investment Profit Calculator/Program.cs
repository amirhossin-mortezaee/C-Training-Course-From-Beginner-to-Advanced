using System;

namespace Investment_Profit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the initial investment from the user
            Console.WriteLine("Please enter the initial investment : ");
            int initialInvestment = int.Parse(Console.ReadLine());

            // Get the annual interest rate from the user and convert it to a decimal
            Console.WriteLine("Please enter the annual interest rate (in percentage) :");
            double annualInterestRate = double.Parse(Console.ReadLine()) / 100;

            // Get the number of years from the user
            Console.WriteLine("Please enter the number of years :");
            int years = int.Parse(Console.ReadLine());

            // Calculate the final investment amount using the compound interest formula
            double finalAmount = initialInvestment * Math.Pow(1 + annualInterestRate, years);

            // Display the final investment with two decimal places
            Console.WriteLine($"Final Investment : {finalAmount:F2}");// Display up to two decimal places

            // Wait for the user to press a key before closing the program
            Console.ReadKey();
        }
    }
}
