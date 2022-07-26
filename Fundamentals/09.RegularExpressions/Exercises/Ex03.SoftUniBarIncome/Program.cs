using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex03.SoftUniBarIncome
{
    public class Program
    {
        public static void Main()
        {
            decimal totalSum = 0;
            Dictionary<string, Dictionary<string, decimal>> dic = new Dictionary<string, Dictionary<string, decimal>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }

                Regex regex = new Regex(@".+?([A-Z][a-z]+).+?([A-Z][a-z]+).+?([0-9]+).+?([0-9]+.?[0-9]+).+?"); // .+?([A-Z][a-z]+).+? ERROR

                MatchCollection myMatch = regex.Matches(input);

                foreach (Match item in myMatch)
                {
                    if (!dic.ContainsKey(item.Groups[1].Value))
                    {
                        dic.Add(item.Groups[1].Value, new Dictionary<string, decimal>());
                    }

                    decimal sum = decimal.Parse(item.Groups[3].Value) * decimal.Parse(item.Groups[4].Value);

                    dic[item.Groups[1].Value].Add(item.Groups[2].Value, sum);
                    totalSum += sum;
                    sum = 0;
                }
            }
            Console.WriteLine();
            foreach (var item in dic)
            {
                foreach (var money in item.Value)
                {
                    Console.WriteLine($"{item.Key}: {money.Key} - {money.Value:f2}");

                }
            }

            if (totalSum > 0)
            {
                Console.WriteLine($"Total income: {totalSum:f2}");

            }

        }
    }
}