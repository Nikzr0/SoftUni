using System;
using System.Collections.Generic;

namespace Ex09.ExplicitInterfaces
{
    public interface IResident
    {
        public string Name { get; set; }
        public string Country { get; set; }
        string GetName();
    }
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        string GetName();
    }
    public class Citizent : IResident, IPerson
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public Citizent(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        public string GetName()
        {
            return Name;
        }
        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }
       
    }
    public class Program
    {
        static void Main()
        {
            List<string> output = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] citizent = input.Split(" ");
                Citizent c = new Citizent(citizent[0], citizent[1], int.Parse(citizent[2]));
                IResident resident = c;
                IPerson person = c;

                output.Add(person.GetName());
                output.Add(resident.GetName());
            }

            Console.WriteLine();
            foreach (var line in output)
            {
                Console.WriteLine(line);
            }
        }
    }
}
