using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05.RecordUniqueNames
{
    public class Program
    {
        public static void Main()
        {
            HashSet<string> uniquenames = new HashSet<string>();

            int inputsLength = int.Parse(Console.ReadLine());

            while (inputsLength > 0)
            {
                string name = Console.ReadLine();
                uniquenames.Add(name);

                inputsLength--;
            }

            Console.WriteLine();
            foreach (var item in uniquenames)
            {
                Console.WriteLine(item);
            }
        }
    }
}