using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.OpinionPoll
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name)
        {
            Name = name;
            Age = 1;
        }

        public Person(int age)
        {
            Age = age;
            Name = "No name";
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();


            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ");

                string name = info[0];
                int age = int.Parse(info[1]);

                people.Add(new Person(name, age));
            }

            Console.WriteLine();
            foreach (var item in people.OrderBy(x=>x.Name).Where(x=>x.Age > 30))
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}