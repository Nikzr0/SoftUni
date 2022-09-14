using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.SumOfCoins
{
    public class Program 
    {
        static Dictionary<int, int> Sum(int[] coins, int desireNumber)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < coins.Length; i++)
            {
                while (desireNumber / coins[i] > 0)
                {
                    if (!result.ContainsKey(coins[i]))
                    {
                        result.Add(coins[i], 1);
                    }
                    else
                    {
                        result[coins[i]]++;
                    }

                    desireNumber -= coins[i];
                }
            }

            return result;
        }
        static void Main() // Solved not in the right way:)
        {
            int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).OrderByDescending(x=>x).ToArray();
            int desireNumber = int.Parse(Console.ReadLine());
            Dictionary<int, int> coinInfo = Sum(coins, desireNumber);

            int numberOfCoins = 0;
            foreach (var item in coinInfo)
            {
                numberOfCoins += item.Value;
            }
            Console.WriteLine($"Number of coins to take: {numberOfCoins}");
            foreach (var item in coinInfo)
            {
                Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
            }
        }
    }
}