using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07.HotPotato
{
    public class Program
    {
        public static void Main()
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            bool one = true;
            int kidToRemove = 0;

            while (list.Count > 1)
            {
                int temp = n + kidToRemove;

                while (temp > list.Count)
                {
                    temp = temp - list.Count;
                }

                kidToRemove = temp - 1;

                queue.Enqueue(list[kidToRemove]);
                list.Remove(list[kidToRemove]);
            }

            Console.WriteLine();
            foreach (var item in queue)
            {
                Console.WriteLine($"Removed {item}");
            }

            foreach (var item in list)
            {
                Console.WriteLine($"Last is {item}");
            }
        }
    }
}