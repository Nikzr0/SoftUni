using System;
using System.Collections.Generic;

namespace Ex05.GenericCountMethodStrings
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> strings = new List<string>();
            for (int i = 0; i < n; i++)
            {
                strings.Add(Console.ReadLine());
            }
            string element = Console.ReadLine();

            Console.WriteLine(GetCount.GetCountGreaterThan(strings, element));
        }
    }
}