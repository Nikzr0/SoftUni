using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05.FashionBoutique
{
    public class Program
    {
        public static void Main()
        {
            List<int> cloths = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>();

            foreach (var item in cloths)
            {
                stack.Push(item);
            }

            int rackCapacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int rackNumber = 1;

            foreach (var item in stack)
            {
                if (sum + item <= rackCapacity)
                {
                    sum += item;
                }
                else
                {
                    rackNumber++;
                    sum = 0;
                    sum += item;
                }
            }

            Console.WriteLine(rackNumber);
        }
    }
}