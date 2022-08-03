using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex12.CupsandBottles
{
    public class Program
    {
        public static void Main()
        {
            Queue<int> cups = new Queue<int>();
            Stack<int> bottles = new Stack<int>();

            int[] cupsCapacity = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] filledBottle = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int wastedWater = 0;

            foreach (var item in cupsCapacity)
            {
                cups.Enqueue(item);
            }

            foreach (var item in filledBottle)
            {
                bottles.Push(item);
            }

            int bottlesCount = bottles.Count;

            int currentBottleValue = bottles.Peek();
            int currentCupValue = cups.Peek();

            for (int i = 0; i < bottlesCount; i++)
            {
                if (cups.Count > 0)
                {
                    if (currentBottleValue >= currentCupValue)
                    {
                        wastedWater += currentBottleValue - currentCupValue;
                        bottles.Pop();
                        cups.Dequeue();

                        if (i < bottlesCount - 1)
                        {
                            currentBottleValue = bottles.Peek();
                            if (cups.Count > 0)
                            {
                                currentCupValue = cups.Peek();
                            }   
                        }
                    }
                    else
                    {
                        currentCupValue -= currentBottleValue;
                        bottles.Pop();

                        currentBottleValue = bottles.Peek();
                    }
                }
            }

            if (bottles.Count >= 0 && cups.Count <= 0)
            {
                string remaningBottles = string.Join(" ", bottles);
                Console.WriteLine($"Bottles: {remaningBottles}");
            }
            else if(cups.Count > 0)
            {
                string remaningCups = string.Join(" ", cups);
                Console.WriteLine($"Cups: {remaningCups}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}