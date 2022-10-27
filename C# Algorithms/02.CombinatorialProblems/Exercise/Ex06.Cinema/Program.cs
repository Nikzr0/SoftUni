using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace Ex06.Cinema
{
    public class Program
    {
        private static string[] people;
        private static string[] arrayOfPeople;
        private static string[] tempArray;
        private static bool[] used;
        private static List<string> peopleToAdd;
        static void Main()
        {
            people = Console.ReadLine().Split(", ");
            arrayOfPeople = new string[people.Length];
            for (int i = 0; i < people.Length; i++)
            {
                arrayOfPeople[i] = "-";
            }
            peopleToAdd = people.ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "generate")
                {
                    break;
                }

                string[] command = input.Split(" - ");

                arrayOfPeople[int.Parse(command[1]) - 1] = command[0];
                for (int i = 0; i < peopleToAdd.Count; i++)
                {
                    if (peopleToAdd[i] == command[0])
                    {
                        peopleToAdd[i] = "*";
                        break;
                    }
                }
            }

            for (int i = 0; i < peopleToAdd.Count; i++)
            {
                if (peopleToAdd[i] == "*")
                {
                    peopleToAdd.RemoveAt(i);
                    i--;
                }
            }

            tempArray = new string[peopleToAdd.Count];
            used = new bool[peopleToAdd.Count];

            GetCombinations(0);
        }

        private static void GetCombinations(int index)
        {
            if (index >= peopleToAdd.Count)
            {
                Print(tempArray);
                return;
            }

            for (int i = 0; i < peopleToAdd.Count; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    tempArray[index] = peopleToAdd[i];
                    GetCombinations(index + 1);
                    used[i] = false;
                }
            }
        }

        private static void Print(string[] tempArray)
        {
            string[] tempArrayOfPeople = new string[arrayOfPeople.Length];
            for (int i = 0; i < tempArrayOfPeople.Length; i++)
            {
                tempArrayOfPeople[i] = arrayOfPeople[i];
            }


            int x = 0;
            for (int i = 0; i < tempArrayOfPeople.Length; i++)
            {
                if (tempArrayOfPeople[i] == "-")
                {
                    tempArrayOfPeople[i] = tempArray[x];
                    x++;
                }
            }

            Console.WriteLine(String.Join(" ", tempArrayOfPeople));
        }
    }
}