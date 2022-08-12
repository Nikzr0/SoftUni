using System;
using System.Linq;

namespace Ex03.CountUppercaseWords
{
    internal class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Any(char.IsUpper))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}