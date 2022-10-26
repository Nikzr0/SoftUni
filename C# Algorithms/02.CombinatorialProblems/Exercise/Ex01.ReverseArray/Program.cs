using System;
using System.Linq;

namespace Ex01.ReverseArray
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToArray();

            Reverse(numbers, 0);

            Console.WriteLine(String.Join(" ", numbers));
        }

        private static void Reverse(int[] numbers, int start)
        {
            if (start == numbers.Length / 2)
            {
                return;
            }

            Swap(numbers,  start, numbers.Length - 1 - start);
        }

        private static void Swap(int[] numbers, int start, int end)
        {
            int temp = numbers[start];
            numbers[start] = numbers[end];
            numbers[end] = temp;
        }
    }
}