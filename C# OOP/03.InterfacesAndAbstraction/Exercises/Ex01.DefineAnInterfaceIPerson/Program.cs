using System;

namespace Ex01.DefineAnInterfaceIPerson
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Citizen : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

        }
    }
}