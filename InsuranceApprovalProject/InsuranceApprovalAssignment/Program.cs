using System;

namespace InsuranceApprovalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age and read the input as an integer
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter whether they have had a DUI and read the input as a boolean value
            Console.WriteLine("Have you ever had a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            // Prompt the user to enter the number of speeding tickets they have and read the input as an integer
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Determine if the user is qualified for insurance based on their age, DUI status, and number of speeding tickets
            bool qualified = (age > 15 && dui == false && tickets <= 3);

            // Display whether the user is qualified for insurance, using the previously calculated 'qualified' boolean value
            Console.WriteLine("Qualified?\n" + qualified);

            // Wait for the user to press Enter before exiting the program
            Console.ReadLine();
        }
    }
}
