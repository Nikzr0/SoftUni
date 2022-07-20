using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            string[] command = input.Split(" -> ");

            string cName = command[0];
            string employee = command[1];

            if (!companies.ContainsKey(cName))
            {
                companies.Add(cName, new List<string>());
                companies[cName].Add(employee);
            }
            else
            {
                if (!companies[cName].Contains(employee))
                {
                    companies[cName].Add(employee);
                }
            }
        }

        Console.WriteLine();
        foreach (var item in companies.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}");

            foreach (var y in item.Value)
            {
                Console.WriteLine($"-- {y}");
            }
        }
    }
}