using System;
using System.Linq;

namespace Ex04.GenericSwapMethodIntegers
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Swaper<int> swapper = new Swaper<int>();

            for (int i = 0; i < n; i++)
            {
                swapper.Add(int.Parse(Console.ReadLine()));
            }

            int[] indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            swapper.Swap(indexes[0], indexes[1]);

            Console.WriteLine(swapper.ToString());
        }

    }
}