using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex11.PartyReservationFilterModule
{
    internal class Program
    {
        static void Main()
        {
            List<string> finalPeople = Console.ReadLine().Split().ToList();
            List<string> listOfFilters = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Print")
                {
                    break;
                }

                string[] command = input.Split(";");
                string finalCommand = command[1] + ";" + command[2];

                if (command[0] == "Add filter")
                {
                    listOfFilters.Add(finalCommand);
                }
                else if (command[0] == "Remove filter")
                {
                    if (listOfFilters.Contains(finalCommand))
                    {
                        listOfFilters.Remove(finalCommand);
                    }
                }
            }

            while (listOfFilters.Count > 0)
            {
                string[] filter = listOfFilters[0].Split(";");

                switch (filter[0])
                {
                    case "Starts with":
                        string firstLetter = filter[1];
                        for (int i = 0; i < finalPeople.Count; i++)
                        {
                            if (finalPeople[i].Substring(0, 1) == firstLetter)
                            {
                                finalPeople.Remove(finalPeople[i]);
                                break;
                            }
                        }

                        break;

                    case "Ends with":
                        string lastLetter = filter[1];
                        for (int i = 0; i < finalPeople.Count; i++)
                        {
                            if (finalPeople[i].Substring(finalPeople[i].Length - 1, 1) == lastLetter)
                            {
                                finalPeople.Remove(finalPeople[i]);
                                break;
                            }
                        }

                        break;

                    case "Length":
                        int count = int.Parse(filter[1]);
                        for (int i = 0; i < finalPeople.Count; i++)
                        {
                            if (finalPeople[i].Length == count)
                            {
                                finalPeople.Remove(finalPeople[i]);
                                break;
                            }
                        }

                        break;

                    case "Contains":
                        string letterToContain = filter[1];
                        for (int i = 0; i < finalPeople.Count; i++)
                        {
                            if (finalPeople[i].Contains(letterToContain))
                            {
                                finalPeople.Remove(finalPeople[i]);
                                break;
                            }
                        }

                        break;
                }
                listOfFilters.Remove(listOfFilters[0]);
            }

            Console.WriteLine(string.Join(" ", finalPeople));
        }
    }
}