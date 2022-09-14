using System;
using System.Linq;

namespace Ex01.RecursiveArraySum
{
    public class Program
    {
        static int Sum(int[] numbers,int index)
        {
            if (index == numbers.Length)
            {
                return 0;
            }

            int sum = numbers[index] + Sum(numbers, index + 1);

            return sum;
        }
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine(Sum(nums, 0));
        }
    }
}