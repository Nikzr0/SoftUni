using System;
using System.Collections.Generic; 

namespace Ex04.CitiesByContinentAndCountry
{
    public class Program
    {
        public static void Main()
        {
          Dictionary<string, Dictionary<string, string>> worldMap = new Dictionary<string, Dictionary<string, string>>();
            int inputLength = int.Parse(Console.ReadLine());

            while (inputLength > 0)
            {
                string[] command = Console.ReadLine().Split(" ");
                string continent = command[0];
                string country = command[1];
                string city = command[2];

                if (!worldMap.ContainsKey(continent))
                {
                    worldMap.Add(continent, new Dictionary<string, string>());
                    worldMap[continent].Add(country, city);
                }
                else
                {
                    if (!worldMap[continent].ContainsKey(country))
                    {
                        worldMap[continent].Add(country, city);
                    }
                    else
                    {
                        worldMap[continent][country] = worldMap[continent][country] + ", " + city;
                    }
                }

                inputLength--;
            }
            Console.WriteLine();
            foreach (var item in worldMap)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var countryInfo in item.Value)
                {
                    string cities = string.Join(", ", countryInfo.Value);
                    Console.WriteLine($"{countryInfo.Key} -> {cities}");
                }
            }
        }
    }
}