using System;
using System.Collections.Generic;

namespace Ex04.BorderControl
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
    public class Person : Info
    {
        public int Age { get; set; }
        public Person(string name, int age, string id) : base(name, id)
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
    public class Program
    {
        static void Main()
        {
            List<string> falseIds = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] command = input.Split(" ");

                if (command.Length == 3)
                {
                    Person person = new Person(command[0], int.Parse(command[1]), command[2]);
                    falseIds.Add(person.Id);
                }
                else if (command.Length == 2)
                {
                    Robot robot = new Robot(command[0], command[1]);
                    falseIds.Add(robot.Id);
                }
            }

            string falseIdsEnd = Console.ReadLine();

            for (int i = 0; i < falseIds.Count; i++)
            {
                string endDigitsOfId = falseIds[i].Substring(falseIds[i].Length - 3);
                if (endDigitsOfId != falseIdsEnd)
                {
                    falseIds.Remove(falseIds[i]);
                    i--;
                }
            }
            Console.WriteLine();
            foreach (var id in falseIds)
            {
                Console.WriteLine(id);
            }
        }
    }
}