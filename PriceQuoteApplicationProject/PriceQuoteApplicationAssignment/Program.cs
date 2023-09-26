using System;

namespace PriceQuoteApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the weight of the package and read the input as an integer
            Console.WriteLine("How much does the package weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if the weight exceeds the maximum limit (50). If so, inform the user and end the program.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a nice day.");
                Console.ReadLine();
                return;
            }

            // Prompt the user to enter the package width and read the input as an integer
            Console.WriteLine("What is the package width?");
            int width = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the package height and read the input as an integer
            Console.WriteLine("What is the package height?");
            int height = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the package length and read the input as an integer
            Console.WriteLine("What is the package length?");
            int length = Convert.ToInt32(Console.ReadLine());

            // Calculate the size of the package by summing the width, height, and length
            int size = width + height + length;

            // Check if the size of the package exceeds the maximum limit (50). If so, inform the user and end the program.
            if (size > 50)
            {
                Console.WriteLine("Package too large to be shipped via Package Express. Have a nice day.");
                Console.ReadLine();
                return;
            }

            // Calculate the shipping quote by multiplying the dimensions (width * height * length) with the weight and dividing the result by 1000
            int quote = (width * height * length * weight) / 1000;

            // Display the estimated total shipping cost to the user
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00\nThank you!");

            // Wait for the user to press Enter before exiting the program
            Console.ReadLine();
        }
    }
}
