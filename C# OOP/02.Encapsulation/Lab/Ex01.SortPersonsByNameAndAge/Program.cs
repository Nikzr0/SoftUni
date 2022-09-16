using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01.SortPersonsByNameAndAge
{

    public class Person
    {
        private string name;
        private string lastName;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }     
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.LastName} is {this.Age} years old.";
        }
    }
    public class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();


            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ");
                var person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]));
                people.Add(person);
            }
            people.OrderBy(x => x.Name).ThenBy(x => x.Age).ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}