using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05.FilterByAge
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] person = Console.ReadLine().Split(", ");

                if (!people.ContainsKey(person[0]))
                {
                    people.Add(person[0], int.Parse(person[1]));
                }
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            if (format == "name age")
            {
                if (condition == "older")
                {
                    foreach (var item in people.Where(y=>y.Value >= age))
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
                else if (condition == "younger")
                {
                    foreach (var item in people.Where(y => y.Value < age))
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }
            else if (format == "name")
            {
                if (condition == "older")
                {
                    foreach (var item in people.Where(y => y.Value >= age))
                    {
                        Console.WriteLine($"{item.Key}");
                    }
                }
                else if (condition == "younger")
                {
                    foreach (var item in people.Where(y => y.Value < age))
                    {
                        Console.WriteLine($"{item.Key}");
                    }
                }
            }
            else if (format == "age")
            {
                if (condition == "older")
                {
                    foreach (var item in people.Where(y => y.Value >= age))
                    {
                        Console.WriteLine($"{item.Value}");
                    }
                }
                else if (condition == "younger")
                {
                    foreach (var item in people.Where(y => y.Value < age))
                    {
                        Console.WriteLine($"{item.Value}");
                    }
                }
            }
        }
    }
}