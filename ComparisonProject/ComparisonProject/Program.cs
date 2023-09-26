using System;

namespace ComparisonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a title for the Anonymous Income Comparison Program
            Console.WriteLine("Anonymous Income Comparison Program");

            // Ask for information about Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int personOneHourlyRate = Convert.ToInt32(Console.ReadLine()); // Get the hourly rate of Person 1
            Console.WriteLine("Hours worked per week?");
            int personOneHoursWorked = Convert.ToInt32(Console.ReadLine()); // Get the hours worked per week for Person 1

            // Ask for information about Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int personTwoHourlyRate = Convert.ToInt32(Console.ReadLine()); // Get the hourly rate of Person 2
            Console.WriteLine("Hours worked per week?");
            int personTwoHoursWorked = Convert.ToInt32(Console.ReadLine()); // Get the hours worked per week for Person 2

            // Calculate the annual salary of Person 1 and Person 2
            int personOneAnnualSalary = personOneHourlyRate * personOneHoursWorked * 52;
            int personTwoAnnualSalary = personTwoHourlyRate * personTwoHoursWorked * 52;

            // Display the annual salaries of Person 1 and Person 2
            Console.WriteLine("Annual salary of Person 1:\n" + personOneAnnualSalary);
            Console.WriteLine("Annual salary of Person 2:\n" + personTwoAnnualSalary);

            // Compare the annual salaries of Person 1 and Person 2
            bool personOneMorePersonTwo = personOneAnnualSalary > personTwoAnnualSalary;

            // Display whether Person 1 makes more money than Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + personOneMorePersonTwo);

            Console.ReadLine(); // Wait for the user to press Enter before closing the program
        }
    }
}