using System;
using System.Collections.Generic;
using System.Linq;

namespace TheLift
{
    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            int peopleOnQueue = int.Parse(Console.ReadLine());

            bool emptyCapacity = false;

            List<int> wagonsCapacity = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < wagonsCapacity.Count; i++)  // 4
            {
                int temp = 4 - wagonsCapacity[i];
                if (wagonsCapacity[i] < 4 && wagonsCapacity[i] >= 0 && peopleOnQueue > 0)
                {
                    for (int j = 0; j < temp; j++)
                    {
                        if (peopleOnQueue > 0)
                        {
                            wagonsCapacity[i]++;
                            peopleOnQueue--;
                        }
                    }
                }
                 temp = 0;
            }

            foreach (var item in wagonsCapacity)
            {
                if (item < 4)
                {
                    emptyCapacity = true;
                }
            }

            if (emptyCapacity)
            {
                list.Add($"The lift has empty spots!");
            }

            if (peopleOnQueue > 0)
            {
                list.Add($"There isn't enough space! {peopleOnQueue} people in a queue!");
            }

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(String.Join(" ", wagonsCapacity));
        }
    }
}