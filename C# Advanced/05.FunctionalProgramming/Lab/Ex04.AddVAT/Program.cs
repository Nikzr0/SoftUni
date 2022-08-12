using System;
using System.Linq;

namespace Ex04.AddVAT
{
    public class Program
    {
        public static void Main()
        {
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();

            for (int i = 0; i < prices.Length; i++)
            {
                double VAT = prices[i] / 5;
                Console.WriteLine($"{prices[i] += VAT:f2}"); 
            }

        }
    }
}