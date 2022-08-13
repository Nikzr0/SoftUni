using System;

namespace Ex01.ActionPoint
{
    internal class Program
    {
        static void Printer(string[] names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
        static void Main()
        {
            Action<string[]> action = Printer;
            string[] input = Console.ReadLine().Split(" ");
            action(input);
        }
    }
}