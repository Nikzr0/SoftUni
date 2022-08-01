using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.FastFood
{
    public class Program
    {
        public static void Main()
        {
            int availableFood = int.Parse(Console.ReadLine());
            List<int> orders = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Queue<int> queue = new Queue<int>();
            Queue<int> ortdersLeft = new Queue<int>();

            int ordersLength = orders.Count;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < ordersLength; j++)
                {
                    if (availableFood > 0)
                    {
                        if (availableFood - orders[0] >= 0)
                        {
                            availableFood -= orders[0];
                            queue.Enqueue(orders[0]);
                            orders.RemoveAt(0);
                        }
                        else if (availableFood - orders[0] < 0)
                        {
                            ortdersLeft.Enqueue(orders[0]);
                            orders.RemoveAt(0);

                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }
            string allRemainOrders = "";
            foreach (var item in queue.OrderByDescending(x=>x).Take(1))
            {
                Console.WriteLine(item);
            }

            if (ortdersLeft.Count > 0)
            {
                allRemainOrders = string.Join(" ", ortdersLeft);
                Console.WriteLine($"Orders left: {allRemainOrders}");
            }
            else if (ortdersLeft.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }




        }
    }
}