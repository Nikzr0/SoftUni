using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07.TheV_Logger
{
    internal class Program
    {
        static void Main() // Only OrderBy is not ready
        {
            Dictionary<string, List<string>> dicWithFollowers = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> dicWithFollowing = new Dictionary<string, List<string>>();

            Dictionary<string, Dictionary<List<string>, List<string>>> orderedDic = new Dictionary<string, Dictionary<List<string>, List<string>>>();
            int counter = 0;

            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] command = input.Split(" ");

                if (command[1] == "joined")
                {
                    if (!dicWithFollowers.ContainsKey(command[0]) && !dicWithFollowing.ContainsKey(command[0]))
                    {
                        dicWithFollowers.Add(command[0], new List<string>());
                        dicWithFollowing.Add(command[0], new List<string>());
                    }
                }
                else if (command[1] == "followed")
                {
                    if (command[0] != command[2] && dicWithFollowers.ContainsKey(command[2]) && dicWithFollowers.ContainsKey(command[0]))
                    {
                        if (!dicWithFollowers[command[2]].Contains(command[0]) && !dicWithFollowers[command[2]].Contains(command[0]))
                        {
                            dicWithFollowers[command[2]].Add(command[0]);
                            dicWithFollowing[command[0]].Add(command[2]);
                        }
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine();


            foreach (var item in dicWithFollowers) // .OrderByDescending(x => x.Value.Count)
            {
                orderedDic.Add(item.Key, new Dictionary<List<string>, List<string>>());
                List<string> aa = item.Value;


                foreach (var item2 in dicWithFollowing.OrderBy(x => x.Value.Count))
                {
                    if (item.Key == item2.Key)
                    {
                        List<string> bb = item2.Value;
                        orderedDic[item.Key].Add(aa, bb);
                        break;
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {dicWithFollowers.Count} vloggers in its logs.");
            foreach (var item in orderedDic.OrderByDescending(x => x.Value.Keys.FirstOrDefault().Count).ThenBy(x => x.Value.Values.FirstOrDefault().Count)) //.OrderByDescending(x=>x.Value.Keys.Count)
            {
                counter++;
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{counter}. {item.Key} : {item2.Key.Count} followers, {item2.Value.Count} following");
                    if (counter == 1)
                    {
                        foreach (var item3 in item2.Key.OrderBy(x => x))
                        {
                            Console.WriteLine($"*  {item3}");
                        }
                    }
                }
            }
        }
    }
}
