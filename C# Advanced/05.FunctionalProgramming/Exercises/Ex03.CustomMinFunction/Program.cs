using System;
using System.Linq;

namespace Ex03.CustomMinFunction
{
    internal class Program
    {
        static int MinValue(int[] numbers)
        {
            int minValue = int.MaxValue;
            foreach (var item in numbers)
            {
                if (item < minValue)
                {
                    minValue = item;
                }
            }

            return minValue;
        }
        static void Main()
        {
            Func<int[], int> func = MinValue;
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Console.WriteLine(func(nums));
        }
    }
}