using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.OldestFamilyMember
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

    class Family
    {
        private List<Person> familyMembers;
        public Family()
        {
            familyMembers = new List<Person>();
        }
        public void AddMember(Person member)
        {
            familyMembers.Add(member);
        }

        public Person GetOldestMember()
        { 
            return familyMembers.OrderByDescending(x => x.Age).First();
        }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] peopleInfo = Console.ReadLine().Split(" ");
                string personName = peopleInfo[0];
                int personAge = int.Parse(peopleInfo[1]);

                family.AddMember(new Person(personName, personAge));
            }
            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine();
            Console.WriteLine($"{oldestPerson.Name} - {oldestPerson.Age}");
        }
    }
}