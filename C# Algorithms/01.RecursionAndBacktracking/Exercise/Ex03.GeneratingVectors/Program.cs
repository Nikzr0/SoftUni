using System;

namespace Ex03.GeneratingVectors
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            Generator(numbers, 0);
        }

        public static void Generator(int[] numbers, int index)
        {
            if (index == numbers.Length)
            {
                Console.WriteLine(String.Join("", numbers));
                return;
            }
             
            for (int i = 0; i <= 1; i++)
            {
                numbers[index] = i;
                Generator(numbers, index + 1);
            }
        }
    }
}