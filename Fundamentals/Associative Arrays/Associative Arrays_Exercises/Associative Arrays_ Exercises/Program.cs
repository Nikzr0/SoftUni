using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> wordsLetters = new Dictionary<string, int>();

        string input = Console.ReadLine();


        for (int i = 0; i < input.Length; i++)
        {
            if (input.Substring(i,1) != " ")
            {
                if (!wordsLetters.ContainsKey(input.Substring(i,1)))
                {
                    wordsLetters.Add(input.Substring(i, 1), 1);
                }
                else
                {
                    wordsLetters[input.Substring(i, 1)]++;
                }

            }
        }

        foreach (var item in wordsLetters)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}