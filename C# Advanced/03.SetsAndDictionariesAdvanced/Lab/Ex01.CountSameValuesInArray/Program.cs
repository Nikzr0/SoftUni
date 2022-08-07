using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01.CountSameValuesInArray
{
    public class Program
    {
        public static void Main()
        {
            double[] input = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            Dictionary<double, int> dicOfNumbers = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (dicOfNumbers.ContainsKey(input[i]))
                {
                    dicOfNumbers[input[i]]++; 
                }
                else
                {
                    dicOfNumbers.Add(input[i], 0);
                }
            }

            foreach (var item in dicOfNumbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value + 1} times");
            }
        }
    }
}