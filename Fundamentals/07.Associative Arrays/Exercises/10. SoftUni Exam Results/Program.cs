using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> results = new Dictionary<string, int>(); // name, points
        Dictionary<string, int> languages = new Dictionary<string, int>();// language, count

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "exam finished")
            {
                break;
            }

            string[] command = input.Split("-");
            string name = command[0]; // VALUE.KEY
            string language = command[1]; // KEY


            if (language != "banned")
            {
                int points = int.Parse(command[2]); //VALUE.VALUE

                if (!results.ContainsKey(name))
                {
                    results.Add(name, points);
                    if (!languages.ContainsKey(language))
                    {
                        languages.Add(language, 0);
                    }
                }
                else
                {
                    if (results[name] < points)
                    {
                        results[name] = points;
                    }
                }

                if (languages.ContainsKey(language))
                {
                    languages[language]++;
                }
            }
            else
            {
                results.Remove(name);
            }
        }

        Console.WriteLine("Results:");

        foreach (var item in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} | {item.Value}");
        }

         Console.WriteLine("Submissions:");

        foreach (var item in languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}