using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> forcebook = new Dictionary<string, List<string>>();
        List<string> notes = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Lumpawaroo")
            {
                break;
            }

            if (input.Contains(" | "))
            {
                string[] command = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                string side = command[0];
                string user = command[1];

                if (!forcebook.ContainsKey(side)) // {forceSide} | {forceUser}  ==>> Light | George
                {
                    forcebook.Add(side, new List<string>());
                    forcebook[side].Add(user);
                }
                else
                {
                    if (!forcebook[side].Contains(user))
                    {
                        forcebook[side].Add(user);
                    }
                }
            }
            else if (input.Contains(" -> "))
            {
                string[] command = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string side = command[1];
                string user = command[0];

                if (forcebook.Any(x => x.Value.Contains(user))) // This finds a Dictionary where user is in its value, which actualy is a List<string>
                {
                    var sideName = forcebook.FirstOrDefault(x => x.Value.Contains(user)).Key;
                    forcebook[sideName].Remove(user);
                    forcebook[side].Add(user);
                    notes.Add($"{user} joins the {side} side!");
                }
                else
                {
                    forcebook[side].Add(user);
                    notes.Add($"{user} joins the {side} side!");
                }
            }
        }

        Console.WriteLine();
        foreach (var item in notes)
        {
            Console.WriteLine(item);
        }
        foreach (var item in forcebook.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            if (item.Value.Count > 0)
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}