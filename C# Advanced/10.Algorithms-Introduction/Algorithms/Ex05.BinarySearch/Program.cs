using System;
using System.Globalization;
using System.Linq;

namespace Ex05.BinarySearch
{
    internal class Program
    {
        public static string GetElIndex(int[] elements, int element)
        {
            int result = 0;
            int counter = 0;

            if (elements.Length == 1 && elements[0] == element)
            {
                return $"Index of {element} is 0";

            }
            while (true)
            {
                if (elements[elements.Length / 2 + counter] == element)
                {
                    return $"Index of {element} is {elements.Length / 2 + counter}";
                }
                else if (elements[elements.Length / 2 - counter] == element)
                {
                    return $"Index of {element} is {elements.Length / 2 - counter}";
                }
                counter++;
            } 

            return $"Index of {element} is {result}";
        }
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetElIndex(numbers, n));
        }
    }
}
