using System;

namespace Ex02.MultipleImplementation
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public interface IIdentifiable
    {
        public string Id { get; set; }
    }

    public interface IBirthable
    {
        public string Birthdate { get; set; }
    }

    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
    }
    public class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);
        }
    }
}