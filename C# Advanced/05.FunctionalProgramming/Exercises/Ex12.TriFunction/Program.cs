using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex12.TriFunction
{
    internal class Program
    {
        static void Main()
        {
            int lettersSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ");

            Func<string, int, bool> func = (name, sum) => name.Sum(x => x) >= lettersSum;
            Func<string[],Func<string, int, bool>, string> finalName = ()
        }
    }
}