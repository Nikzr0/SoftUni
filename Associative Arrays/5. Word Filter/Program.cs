using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> words = Console.ReadLine().Split(" ").ToList();
        List<string> finalWords = new List<string>();   


        foreach (var item in words)
        {
            if (item.Length % 2 == 0)
            {
                finalWords.Add(item);
            }
        }

        foreach (var item in finalWords)
        {
            Console.WriteLine(item);
        }

    }
}