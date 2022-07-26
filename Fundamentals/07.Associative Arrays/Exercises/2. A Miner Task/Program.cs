using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> resourses = new Dictionary<string, int>();

        while (true)
        {
            string resourse = Console.ReadLine();

            if (resourse == "stop")
            {
                break;
            }

            int quantity = int.Parse(Console.ReadLine());

            if (!resourses.ContainsKey(resourse))
            {
                resourses.Add(resourse, quantity);
            }
            else
            {
                resourses[resourse] += quantity;
            }
        }

        foreach (var item in resourses)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}