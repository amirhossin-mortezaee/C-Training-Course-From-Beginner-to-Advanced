using System;

namespace TryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your first number : ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second number : ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"Result : {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero! Please enter a nonzero number.");
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }
}
