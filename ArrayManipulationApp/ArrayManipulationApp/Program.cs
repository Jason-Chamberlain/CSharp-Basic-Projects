using System;
using System.Collections.Generic;

namespace ArrayManipulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of strings to store prompts
            string[] strArray = { "Input 1: ", "Input 2: ", "Input 3: ", "Input 4: ", "Input 5: " };

            // Ask the user to input some text
            Console.WriteLine("Input text here:");
            string input = Console.ReadLine();

            // Loop to update each array element by appending user input
            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] += input;
            }

            // Display each string in the array
            foreach (string element in strArray)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            // Initialize a counter for the while loop
            int counter = 0;

            // Loop while counter is less than 5
            while (counter < 5)
            {
                Console.WriteLine("Loop using '<' sign: " + counter);
                counter++;
            }

            // Reset the counter
            counter = 0;

            // Loop while counter is less than or equal to 5
            while (counter <= 5)
            {
                Console.WriteLine("Loop using '<=' sign: " + counter);
                counter++;
            }
            Console.ReadLine();

            // Create a list of days of the week
            List<string> days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", };

            // Ask the user to select a day
            Console.WriteLine("Select a day of the week: ");
            string selectedDay = Console.ReadLine();
            bool foundMatch = false;

            // Loop through the list of days and check for a match
            for (int i = 0; i < days.Count; i++)
            {
                if (selectedDay == days[i])
                {
                    Console.WriteLine("List index is: " + i);
                    foundMatch = true;
                    break;
                }
            }

            // Display a message if no valid day is entered
            if (!foundMatch)
            {
                Console.WriteLine("You must enter a valid day of the week.");
            }
            Console.ReadLine();

            // Create a list of months
            List<string> months = new List<string>() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "January" };

            // Ask the user to select a month
            Console.WriteLine("Select a month: ");
            string selectedMonth = Console.ReadLine();
            foundMatch = false;

            // Loop through the list of months and check for a match
            for (int i = 0; i < months.Count; i++)
            {
                if (selectedMonth == months[i])
                {
                    Console.WriteLine("List index is: " + i);
                    foundMatch = true;
                }
            }

            // Display a message if no valid month is entered
            if (!foundMatch)
            {
                Console.WriteLine("You must enter a valid month.");
            }
            Console.ReadLine();

            // Create a list of letters
            List<string> letters = new List<string>()
            {
                "B", "A", "O", "M", "G", "R",
                "W", "S", "A", "P", "K", "P",
                "P", "W", "C", "B", "G", "R"
            };

            // Create a list to track seen letters
            List<string> seenLetters = new List<string>();

            // Loop through the list of letters and check for duplicates
            foreach (string letter in letters)
            {
                if (seenLetters.Contains(letter))
                {
                    Console.WriteLine(letter + " - this item is a duplicate.");
                }
                else
                {
                    seenLetters.Add(letter);
                    Console.WriteLine(letter + " - this item is unique.");
                }
            }
            Console.ReadLine();
        }
    }
}
