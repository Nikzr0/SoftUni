using System;
using System.Linq;

namespace Ex01.RecursiveArraySum
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine(SumOfNums(numbers,0));
        }
        public static int SumOfNums(int[] numbers, int index)
        {
            if (index == numbers.Length - 1)
            {
                return numbers[index];
            }
            return numbers[index] + SumOfNums(numbers, index + 1);
        }
    }
}