using System;
using System.Buffers;
using System.Linq;

namespace Ex07.SumOfCoins
{
    public class Program
    {
        // Maybe the initial array must be sorted
        static void Main()
        {
            int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int money = int.Parse(Console.ReadLine());

            int[] numberOfCoins = new int[coins.Length];

            FindCombination(coins, money, numberOfCoins, 0);
        }

        private static void FindCombination(int[] coins, int money, int[] numberOfCoins, int index)
        {
            if (index == coins.Length)
            {
                if (money == 0)
                {
                    ArrayWriter(coins, numberOfCoins);
                }
                else
                {
                    Console.WriteLine("Error");
                }
                return;
            }

            while (money - coins[coins.Length - 1 - index] >= 0)
            {
                money -= coins[coins.Length - 1 - index];
                numberOfCoins[coins.Length - 1 - index]++;
            }

            FindCombination(coins, money, numberOfCoins, index + 1);
        }

        private static void ArrayWriter(int[] coins, int[] numberOfCoins)
        {
            int sum = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                sum += numberOfCoins[i];
            }

            Console.WriteLine($"Numbers of coins; {sum}");
            for (int i = coins.Length - 1; i >= 0; i--)
            {
                if (numberOfCoins[i] > 0)
                {
                    Console.WriteLine($"{numberOfCoins[i]} coin(s) with value {coins[i]}");
                }
            }
        }
    }
}
