using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01.SortEvenNumbers
{
    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            List<int> output = new List<int>();
            foreach (var item in input.Where(x=>x % 2 == 0).OrderBy(y=>y))
            {
                output.Add(item);
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}