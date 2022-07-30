using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Ex05.NetherRealms
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<double, double>> dic = new Dictionary<string, Dictionary<double, double>>();
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Regex healthRegex = new Regex(@"(\p{L})");
            Regex damage = new Regex(@"([-+]?[0-9]+\.?[0-9]*)");

            string healthPoints = "";
            int healthPointsSum = 0;
            double damageSum = 0;

            int numberOfStars = 0;
            int starsHelp = 2;

            int numberOfSlashes = 0;
            int slashesHelp = 2;


            for (int i = 0; i < input.Length; i++)
            {
                string name = input[i];
                for (int z = 0; z < input.Length; z++)
                {

                    if (name.Length > 0 && !name.Contains(',') && !name.Contains(' '))
                    {
                        MatchCollection myMatch = healthRegex.Matches(input[i]);
                        MatchCollection damageMatch = damage.Matches(input[i]);

                        foreach (Match item in myMatch)
                        {
                            healthPoints += item.ToString();
                        }

                        foreach (var item in healthPoints)
                        {
                            healthPointsSum += (int)item;
                        }

                        string starsCounter = input[i];


                        for (int y = 0; y < starsCounter.Length; y++)
                        {
                            if (starsCounter[y].ToString() == "*")
                            {
                                numberOfStars++;
                            }

                            if (starsCounter[y].ToString() == "/")
                            {
                                numberOfSlashes++;
                            }
                        }

                        for (int x = 0; x < numberOfStars - 1; x++)
                        {
                            starsHelp = starsHelp * 2;
                        }

                        for (int x = 0; x < numberOfSlashes - 1; x++)
                        {
                            starsHelp = starsHelp * 2;
                        }

                        foreach (Match item in damageMatch)
                        {
                            string temp = item.ToString();


                            if (temp[i].ToString() == "-")
                            {
                                temp = temp.Remove(0, 1);
                                damageSum = damageSum - double.Parse(temp);
                            }
                            else if (temp[i].ToString() == "+")
                            {
                                temp = temp.Remove(0, 1);
                                damageSum += double.Parse(temp);
                            }
                            else
                            {
                                damageSum += double.Parse(temp);
                            }
                        }

                        if (numberOfStars > 0)
                        {
                            damageSum = damageSum * starsHelp;
                        }

                        if (numberOfSlashes > 0)
                        {
                            damageSum = damageSum / slashesHelp;
                        }

                        if (!dic.ContainsKey(input[i]))
                        {
                            dic.Add(input[i], new Dictionary<double, double>());
                            dic[input[i]].Add(healthPointsSum, damageSum);

                        }

                        healthPoints = "";
                        healthPointsSum = 0;
                        damageSum = 0;

                        numberOfStars = 0;
                        starsHelp = 2;

                        numberOfSlashes = 0;
                        slashesHelp = 2;

                    }
                }
            }

            foreach (var item in dic.OrderBy(x => x.Key))
            {
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item.Key} - {item2.Key} health, {item2.Value:f2} damage");
                }
            }
        }
    }
}
