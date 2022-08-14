using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex08.CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Predicate<int> evenNumbers = x => x % 2 == 0;
            Predicate<int> oddNumbers = x => x % 2 != 0;

            List<int> result = numbers.Where(x => evenNumbers(x)).OrderBy(x => x).ToList();
            foreach (var item in numbers.Where(x=> oddNumbers(x)).OrderBy(x => x))
            {
                result.Add(item);
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}