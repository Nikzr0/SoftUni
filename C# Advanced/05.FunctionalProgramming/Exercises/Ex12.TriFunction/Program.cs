using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex12.TriFunction
{
    internal class Program
    {
        static void Main() // Solved with dictionary
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            int sumOfLetters = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ");

            foreach (var item in names)
            {
                if (!people.ContainsKey(item))
                {
                    int itemCount = 0;
                    foreach (var letter in item)
                    {
                        itemCount += (int)letter;
                    }

                    people.Add(item, itemCount);
                }
            }

            foreach (var item in people)
            {
                if (item.Value >= sumOfLetters)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}