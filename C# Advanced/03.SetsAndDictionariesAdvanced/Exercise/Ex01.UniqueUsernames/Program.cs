using System;
using System.Collections.Generic;

namespace Ex01.UniqueUsernames
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}