using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;

            byte hoursWorked = 42;
            sbyte currentTemp = 73;

            char randomLetter = 'X';

            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 211.404943;
            float secondsLeft = 2.62f;
            int currentPinBallScore = 31324;
            uint pixelWidth = 1280;
            long moleculeDifference = -4843349238903;
            ulong airMoleculesInJar = 24328493492309;
            short temperatureOnMars = -341;
            ushort antarcticaPopulation = 302;

            string firstName = "John";
            string lastName = "Doe";
            string emptyString = "";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();
        }
    }
}
