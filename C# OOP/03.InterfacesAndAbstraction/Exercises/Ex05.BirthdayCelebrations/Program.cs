using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05.BirthdayCelebrations
{
    public abstract class Info
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Info(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }

    public interface BD
    {
        public string Birthdate { get; set; }
    }
    public class Citizen : Info, BD
    {
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public Citizen(string name, int age, string id) : base(name, id)
        {
            Age = age;
        }
    }
    public class Robot : Info
    {
        public Robot(string name, string id) : base(name, id)
        {
        }
    }
    public class Pet: BD
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
    public class Program
    {
        static void Main()
        {
            List<string> birthdays = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] command = input.Split();

                if (command[0] == "Citizen")
                {
                    birthdays.Add(command[4]);
                }
                else if (command[0] == "Pet")
                {
                    birthdays.Add(command[2]);
                }
            }

            string year = Console.ReadLine();

            foreach (var birthday in birthdays.Where(x=> x.Substring(x.Length - 4) == year))
            {
                Console.WriteLine(birthday);
            }
        }
    }
}