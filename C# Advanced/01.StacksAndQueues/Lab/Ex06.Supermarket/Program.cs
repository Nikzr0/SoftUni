using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06.Supermarket
{
    public  class Program
    {
        public static void Main()
        {
            Queue<string> queue = new Queue<string>();
            List<string> list = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (input != "Paid")
                {
                    queue.Enqueue(input);
                }             
                else if (input == "Paid")
                {
                    foreach (var item in queue)
                    {
                        list.Add(item);
                    }
                    queue.Clear();
                }


            }
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine($"{queue.Count} pepople reamaining.");
        }
    }
}