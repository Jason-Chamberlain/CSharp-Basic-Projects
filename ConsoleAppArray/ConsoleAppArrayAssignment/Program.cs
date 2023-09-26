using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an array of strings
        string[] strArray = { "Hello", "World", "My", "name", "is", "Jason" };

        // Prompt the user to pick a location in the string array
        Console.WriteLine("Pick a location in the string array. It contains 6 strings.");
        int strSelected = Convert.ToInt32(Console.ReadLine());

        // Check if the selected index is within the array bounds,
        // if yes, retrieve the string at the selected index,
        // otherwise provide an error message
        string strResult = strSelected < strArray.Length ? strArray[strSelected] : "You selected an index that does not exist";

        // Display the selected string or error message
        Console.Write(strResult);

        // Create an array of integers
        int[] intArray = { 10, 12, 17, 22, 25 };

        // Prompt the user to pick a location in the integer array
        Console.WriteLine("\nPick a location in the integer array. It contains 5 numbers.");
        int intSelected = Convert.ToInt32(Console.ReadLine());

        // Check if the selected index is within the array bounds,
        // if yes, retrieve the integer at the selected index,
        // otherwise provide an error message
        string intResult = intSelected < intArray.Length ? Convert.ToString(intArray[intSelected]) : "You selected an index that does not exist";

        // Display the selected integer or error message
        Console.Write(intResult);

        // Create a list of strings
        List<string> strList = new List<string> { "Hello", "World", "My", "name", "is", "Jason" };

        // Prompt the user to pick a location in the string list
        Console.WriteLine("\nPick a location in the string list. It contains 6 strings.");
        int listSelected = Convert.ToInt32(Console.ReadLine());

        // Check if the selected index is within the list bounds,
        // if yes, retrieve the string at the selected index,
        // otherwise provide an error message
        string listResult = listSelected < strList.Count ? strList[listSelected] : "You selected an index that does not exist";

        // Display the selected string or error message
        Console.Write(listResult);

        // Wait for user input before exiting the program
        Console.ReadLine();
    }
}