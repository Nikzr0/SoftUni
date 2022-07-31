using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02.BasicQueueOperations
{
    public class Program
    {
        public static void Main()
        {
            int[] inputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            int numbersToEnqueue = inputNumbers[0];
            int numbersToDequeue = inputNumbers[1];
            int numberToSearch = inputNumbers[2];

            List<int> ints = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            for (int i = 0; i < numbersToEnqueue; i++)
            {
                queue.Enqueue(ints[i]);
            }

            for (int i = 0; i < numbersToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numberToSearch))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (!queue.Contains(numberToSearch))
            {
                foreach (var item in queue.OrderBy(x=>x).Take(1))
                {
                    Console.WriteLine(item);
                }
            }          
        }
    }
}