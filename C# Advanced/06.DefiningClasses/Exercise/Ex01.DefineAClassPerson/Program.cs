﻿using System;
using System.Collections.Generic;

namespace Ex01.DefineAClassPerson
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main()
        {
            List<Person> listOfPeople = new List<Person>();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                string[] info = input.Split(" ");
                string personName = info[0];
                int personAge = int.Parse(info[1]);

                listOfPeople.Add(new Person(personName, personAge));
            }

            foreach (var item in listOfPeople)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}