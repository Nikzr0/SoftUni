using System;
using System.Linq;  

namespace Ex04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main()
        {
            int[] rangeOfNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();            
            int[] numbers = Enumerable.Range(rangeOfNumbers[0], rangeOfNumbers[1] - rangeOfNumbers[0] + 1).ToArray();

            string typeOfNumber = Console.ReadLine();

            Predicate<int> typeOfNumbersToSearch = x => x % 2 == 0;

            switch (typeOfNumber)
            {
                case "odd":
                    Console.WriteLine(string.Join(" ", numbers.Where(x => !typeOfNumbersToSearch(x))));
                    break;

                case "even":
                    Console.WriteLine(string.Join(" ", numbers.Where(x => typeOfNumbersToSearch(x))));
                    break;
            }
        }
    }
}