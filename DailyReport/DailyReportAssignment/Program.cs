using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main()
        {
            // Display a title for the Daily Report form
            Console.WriteLine("The Tech Academy\nStudent Daily Report\n");

            // Ask the user to input their name and store it in the 'name' variable
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Ask the user to input the course they are currently enrolled in and store it in the 'course' variable
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Ask the user to input the current page number of their course materials and store it in the 'pageNumber' variable
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask the user if they need any help and store their response (true/false) in the 'helpRequired' variable
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool helpRequired = Convert.ToBoolean(Console.ReadLine());

            // Ask the user to share any positive experiences they have had and store it in the 'experiences' variable
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            // Ask the user for any additional feedback they would like to provide and store it in the 'feedback' variable
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Ask the user to input the number of hours they have studied today and store it in the 'hoursStudied' variable
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            // Display a thank-you message to the user and inform them that an instructor will respond shortly
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); // Wait for the user to press Enter before closing the program
        }
    }
}