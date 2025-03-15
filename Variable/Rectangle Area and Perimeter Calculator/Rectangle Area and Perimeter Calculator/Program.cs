using System;

namespace Rectangle_Area_and_Perimeter_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the length of the rectangle from the user
            Console.WriteLine("Please enter the length of the rectangle :");
            int lenght = int.Parse(Console.ReadLine());

            // Get the width of the rectangle from the user
            Console.WriteLine("Please enter the width of the rectangle : ");
            int width = int.Parse(Console.ReadLine());

            // Calculate the area and perimeter of the rectangle
            int area = lenght * width;
            int perimeter = (lenght + width) * 2;

            // Display the results
            Console.WriteLine($"The area of the rectangle is {area} The perimeter of the rectangle is {perimeter}");

            // Wait for a key press before closing the program
            Console.ReadKey();
        }
    }
}
