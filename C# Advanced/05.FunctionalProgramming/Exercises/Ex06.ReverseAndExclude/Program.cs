using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06.ReverseAndExclude
{
    internal class Program
    {
        static void Main()
        {
            Func<int, int, bool> isDevided = (x, y) => x % y == 0;
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            int[] result = numbers.Where(x => !isDevided(x, n)).Reverse().ToArray();
            Console.WriteLine(String.Join(" ", result));
        }
    }
}