using System;

namespace Ex02.KnightsOfHonor
{
    internal class Program
    {
        static void Sir(string[] names)
        {
            foreach (var item in names)
            {
                Console.WriteLine($"Sir {item}");
            }
        }
        static void Main()
        {
            string[] names = Console.ReadLine().Split(" ");
            Action<string[]> action = Sir;
            action(names);
        }
    }
}
