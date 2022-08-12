using System;
using System.Linq;

namespace Ex02.SumNumbers
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());
        }
    }
}