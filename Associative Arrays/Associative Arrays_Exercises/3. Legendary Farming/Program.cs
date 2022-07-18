using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        Dictionary<string, int> valuableMaterials = new Dictionary<string, int>();
        Dictionary<string, int> junk = new Dictionary<string, int>();

        bool breaker = false;
        string first = "";

        while (!breaker)
        {
            string[] mats = Console.ReadLine().ToLower().Split(" ");

            for (int i = 1; i < mats.Length; i += 2)
            {
                if (first == "")
                {
                    if (mats[i] == "fragments" || mats[i] == "motes" || mats[i] == "shards")
                    {
                        if (!valuableMaterials.ContainsKey(mats[i]))
                        {
                            valuableMaterials.Add(mats[i], int.Parse(mats[i - 1]));
                        }
                        else
                        {
                            valuableMaterials[mats[i]] += int.Parse(mats[i - 1]);
                        }

                        var myKey = valuableMaterials.FirstOrDefault(x => x.Value >= 250).Key;
                        if (myKey != null)
                        {
                            valuableMaterials[myKey] -= 250;

                            if (myKey == "fragments")
                            {
                                myKey = "Valanyr";
                            }
                            else if (myKey == "motes")
                            {
                                myKey = "Dragonwrath";
                            }
                            else if (myKey == "shards")
                            {
                                myKey = "Shadowmourne";
                            }

                            first = $"{myKey} obtained!";
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(mats[i]))
                        {
                            junk.Add(mats[i], int.Parse(mats[i - 1]));
                        }
                        else
                        {
                            junk[mats[i]] += int.Parse(mats[i - 1]);
                        }
                    }

                }
            }

            if (first != "")
            {
                breaker = true;
            }
        }

        Console.WriteLine();
        Console.WriteLine(first);

        for (int i = 0; i < 3; i++)
        {
            if (!valuableMaterials.ContainsKey("fragments"))
            {
                valuableMaterials.Add("fragments", 0);
            }
            else if (!valuableMaterials.ContainsKey("motes"))
            {
                valuableMaterials.Add("motes", 0);
            }
            else if (!valuableMaterials.ContainsKey("shards"))
            {
                valuableMaterials.Add("shards", 0);
            }
        }


        foreach (var item in valuableMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        foreach (var item in junk.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}