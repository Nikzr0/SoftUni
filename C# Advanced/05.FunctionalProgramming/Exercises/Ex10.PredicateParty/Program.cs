using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex10.PredicateParty
{
    internal class Program
    {
        static void Main()
        {
            List<string> people = Console.ReadLine().Split(" ").ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Party!")
                {
                    break;
                }

                string[] command = input.Split(" ");

                switch (command[0])
                {
                    case "Remove":
                        string stringToSearch = command[2];
                        if (command[1] == "StartsWith")
                        {
                            for (int i = 0; i < people.Count; i++)
                            {
                                if (people[i].StartsWith(stringToSearch))
                                {
                                    people.Remove(people[i]);
                                }
                            }
                        }
                        else if (command[1] == "EndsWith")
                        {
                            foreach (var item in people)
                            {
                                if (item.EndsWith(stringToSearch))
                                {
                                    people.Remove(item);
                                }
                            }
                        }
                        break;

                    case "Double":
                        bool isItNumber = int.TryParse(command[2], out int nameLength);
                        if (isItNumber)
                        {
                            //int nameLength = int.Parse(command[2]);

                            for (int i = 0; i < people.Count; i++)
                            {
                                if (people[i].Length == nameLength)
                                {
                                    people.Insert(i + 1, people[i]);
                                    i++;
                                }
                            }
                        }
                        else
                        {
                            string lettersToSearch = command[2];


                            if (command[1] == "StartsWith")
                            {
                                for (int i = 0; i < people.Count; i++)
                                {
                                    if (people[i].StartsWith(lettersToSearch))
                                    {
                                        people.Insert(i + 1, people[i]);
                                        i++;
                                    }
                                }
                            }
                            else if (command[1] == "EndsWith")
                            {
                                for (int i = 0; i < people.Count; i++)
                                {
                                    if (people[i].EndsWith(lettersToSearch))
                                    {
                                        people.Insert(i + 1, people[i]);
                                        i++;
                                    }
                                }
                            }
                        }

                        break;
                }
            }

            if (people.Count > 0)
            {
                string peopleNames = "";
                foreach (var item in people)
                {
                    peopleNames = string.Join(", ", people);
                }

                Console.WriteLine($"{peopleNames} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}