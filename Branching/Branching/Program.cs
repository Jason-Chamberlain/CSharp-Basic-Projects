using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemp = 80;
            int roomTemp = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi " + name + "!  What is the temperature where you are?");
            currentTemp = Convert.ToInt32(Console.ReadLine());

            if (currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temperature");
            }
            else if (currentTemp > roomTemp)
            {
                Console.WriteLine("It is warmer than room temperature");
            }
            else 
            {
                Console.WriteLine("It is cooler than room temperature");
            }

            string comparisonResult = currentTemp == roomTemp ? "It is exactly room temperature" : "It is NOT exactly room temperature";
            Console.WriteLine(comparisonResult);

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 17 ? name + ", your number is AWESOME" : "Come on " + name + ", 17 is way better than your number";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
