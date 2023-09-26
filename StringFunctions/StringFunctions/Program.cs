using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jason";
            Console.WriteLine(name);

            string quote = "The man said \"Strings are Immutable.\", Jason.\nHello on a new line.\n\tHello on a tab.";
            Console.WriteLine(quote);

            string fileName = @"C:\Users\Jason";
            Console.WriteLine(fileName);

            bool trueOrFalse = name.Contains("s");
            Console.WriteLine(trueOrFalse);

            trueOrFalse = name.EndsWith("s");
            Console.WriteLine(trueOrFalse);

            int length = name.Length;
            Console.WriteLine(length);

            name = name.ToUpper();
            Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jason."); name = "Jason";
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
