using System;
using System.Collections.Generic;
using System.Linq;


namespace Ex05.PrintEvenNumbers
{
    public class Program
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Queue<int> queue = new Queue<int>();

            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    queue.Enqueue(item);
                }
            }

            Console.WriteLine(String.Join(", ", queue));
        }
    }
}