using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesNumber = int.Parse(Console.ReadLine());
            SortedSet<string> periodTable = new SortedSet<string>();

            for (int i = 0; i < linesNumber; i++)
            {
                string[] elements = Console.ReadLine().Split(" ");

                for (int j = 0; j < elements.Length; j++)
                {
                    periodTable.Add(elements[j]);
                }
            }

            Console.WriteLine(string.Join(" ", periodTable));
        }
    }
}
