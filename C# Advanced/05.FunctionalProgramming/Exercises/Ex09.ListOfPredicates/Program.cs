using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex09.ListOfPredicates
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbersToDevide = Console.ReadLine().Split(" ").Select(int.Parse).Distinct().ToArray();
            int[] allNumbers = Enumerable.Range(1, n).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var item in numbersToDevide)
            {
                predicates.Add(x => x % item == 0);
            }

            foreach (var item in allNumbers)
            {
                bool isDivisible = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(item))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}