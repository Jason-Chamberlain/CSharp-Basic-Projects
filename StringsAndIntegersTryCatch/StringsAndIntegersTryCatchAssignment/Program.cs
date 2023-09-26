using System;
using System.Collections.Generic;

namespace StringsAndIntegersTryCatchAssignment
{
    // Defining the main class
    class Program
    {
        // Main method where the program execution starts
        static void Main(string[] args)
        {
            // Creating a list of integers
            List<int> numList = new List<int>() { 17, 20, 40, 80, 175 };

            // Prompting the user to input a divisor
            Console.WriteLine("Please pick a number for the divisor:");

            try
            {
                // Reading the user's input and converting it to an integer
                int divisor = Convert.ToInt32(Console.ReadLine());

                // Iterating through each number in the list
                foreach (int number in numList)
                {
                    // Dividing the number by the user-provided divisor and displaying the result
                    Console.WriteLine(number + " divided by " + divisor + " equals " + number / divisor);
                }
            }
            catch (Exception ex)
            {
                // Handling any exceptions that might occur during the execution of the try block
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please pick a non-zero whole number for the divisor");
            }
            finally
            {
                // Ensuring that the program waits for user input before exiting
                Console.ReadLine();
            }
        }
    }
}