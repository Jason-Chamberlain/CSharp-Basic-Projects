using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            int difference = 10 - 5;
            int product = 10 * 5;
            int quotient = 100 / 5;
            double quotient2 = 100.0 / 17.0;
            int remainder = 10 % 2;
            int remainder2 = 11 % 2;

            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.WriteLine(combined);
            Console.WriteLine("Ten minus Five = " + difference.ToString());
            Console.WriteLine("Ten times Five = " + product.ToString());
            Console.WriteLine("One Hundred divided by Five = " + quotient.ToString());
            Console.WriteLine("One Hundred divided by Seventeen = " + quotient2.ToString());
            Console.WriteLine("Ten % 2 = " + remainder + " (remainder)");
            Console.WriteLine("Eleven % 2 = " + remainder2 + " (remainder)");
            Console.ReadLine();

            bool trueOrFalse = 12 > 5;
            bool trueOrFalse2 = 12 < 5;
            int roomTemp = 70;
            int currentTemp = 72;
            bool isWarm = currentTemp > roomTemp;
            bool isWarm2 = currentTemp >= roomTemp;
            bool isWarm3 = currentTemp == roomTemp;
            bool isWarm4 = currentTemp != roomTemp;


            Console.WriteLine("12 > 5: " + trueOrFalse.ToString());
            Console.WriteLine("12 < 5: " + trueOrFalse2.ToString());
            Console.WriteLine("Current Temp is greater than Room Temp: " + isWarm.ToString());
            Console.WriteLine("Current Temp is greater than or equal to Room Temp: " + isWarm2.ToString());
            Console.WriteLine("Current Temp is equal to Room Temp: " + isWarm3.ToString());
            Console.WriteLine("Current Temp is NOT equal to Room Temp: " + isWarm4.ToString());
            Console.ReadLine();
        }
    }
}
