using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.SimpleCalculator
{
    public class Program
    {
        public static void Main()  // 100%, but was made with a list (did'n find a solution with Stack and it wasn't in the presentation)!
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();

            int sum = int.Parse(list[0]);

            for (int i = 0; i < list.Count - 2; i++)
            {
                if (list[i + 1] == "+")
                {
                    sum += int.Parse(list[i + 2]);
                }
                else if (list[i + 1] == "-")
                {
                    sum -= int.Parse(list[i + 2]);
                }
            }

            Console.WriteLine(sum);
        }
    }
}