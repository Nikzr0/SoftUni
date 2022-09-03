using System;
using System.Linq;

namespace Ex4.Froggy
{
    public class Program
    {
        static void Main()
        {
            int[] stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Lake lake = new Lake(stones);

            Console.WriteLine(string.Join(" ", lake));
        }
    }
}