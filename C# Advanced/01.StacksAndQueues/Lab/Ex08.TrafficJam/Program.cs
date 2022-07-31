using System;
using System.Collections.Generic;

namespace Ex08.TrafficJam
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int greenCounter = 0;
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else if (input == "green")
                {
                    greenCounter++;
                }
                else
                {
                    queue.Enqueue(input);
                }

            }

            Console.WriteLine();
            int temp = 0;
            int counter = 0;
            foreach (var item in queue)
            {
                if (temp < n * greenCounter)
                {
                    Console.WriteLine($"{item} passed!");
                    counter++;
                }
                temp++;
            }

            Console.WriteLine(counter + " cars passed the crossroads.");
        }
    }
}