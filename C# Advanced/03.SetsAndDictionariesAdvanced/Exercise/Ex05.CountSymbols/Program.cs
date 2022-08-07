using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, SortedDictionary<char, int>> letterPosition = new Dictionary<int, SortedDictionary<char, int>>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                int temp = input[i];
                if (!letterPosition.ContainsKey(input[i]))
                {
                    letterPosition.Add(temp, new SortedDictionary<char, int>());
                    letterPosition[temp].Add(input[i], 1);
                }
                else
                {
                    letterPosition[temp][input[i]]++;
                }
            }

            foreach (var item in letterPosition.OrderBy(x=>x.Key))
            {
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item2.Key}: {item2.Value} time/s");
                }
            }
        }
    }
}
