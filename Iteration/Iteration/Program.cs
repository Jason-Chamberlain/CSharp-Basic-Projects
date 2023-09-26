using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        for (int i = 0; i < testScores.Length; i++)
        {
            if (testScores[i] > 85)
            {
                Console.WriteLine("Passing test score: " + testScores[i]);
            }
        }

        Console.ReadLine();

        string[] names1 = { "Jason", "Erik", "Daniel", "Adam" };

        for (int i = 0; i < names1.Length; i++)
        {
            Console.WriteLine(names1[i]);
        }

        Console.ReadLine();

        List<int> testScores1 = new List<int>();
        testScores1.Add(98);
        testScores1.Add(99);
        testScores1.Add(81);
        testScores1.Add(72);
        testScores1.Add(70);

        foreach (int score in testScores1)
        {
            if (score > 85)
            {
                Console.WriteLine("Passing test score: " + score);
            }
        }

        Console.ReadLine();

        List<string> names = new List<string>() { "Jason", "Erik", "Daniel", "Adam" };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.ReadLine();

        List<int> testScores2 = new List<int>() { 98, 99, 17, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores2)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }
}
