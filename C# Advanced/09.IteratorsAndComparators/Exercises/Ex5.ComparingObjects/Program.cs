using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5.ComparingObjects
{
    public class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] tokens = input.Split(" ");

                people.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            var equal = 0;
            var notEqual = 0;

            foreach (Person item in people)
            {
                if (people[index].CompareTo(item) == 0)
                {
                    equal++;
                }
                else
                {
                   notEqual++;
                }
            }

            if (equal <= 1)
            {
                Console.WriteLine("No Matches");
            }
            else
            {
                Console.WriteLine($"{equal} {notEqual} {people.Count}");
            }
        }
    }
}