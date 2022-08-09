using System;
using System.Collections.Generic;

namespace Ex06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesNum = int.Parse(Console.ReadLine());
            var wardrob = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < linesNum; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrob.ContainsKey(color))
                {
                    wardrob.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in clothes)
                {
                    if (!wardrob[color].ContainsKey(item))
                    {
                        wardrob[color].Add(item, 1);
                    }
                    else
                    {
                        wardrob[color][item]++;
                    }
                }
            }
            string[] finalInput = Console.ReadLine().Split(" ");
            string theChosenColor = finalInput[0];
            string theChosenCloth = finalInput[1];
            Console.WriteLine();
            foreach (var item in wardrob)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item2 in item.Value)
                {
                    if (item.Key == theChosenColor && item2.Key == theChosenCloth)
                    {
                        Console.WriteLine($"* {item2.Key} - {item2.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item2.Key} - {item2.Value}");
                    }
                }
            }
        }
    }
}
