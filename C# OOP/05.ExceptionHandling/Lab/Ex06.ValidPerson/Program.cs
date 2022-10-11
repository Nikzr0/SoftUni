using System;

namespace Ex06.ValidPerson
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentNullException("The name can't be empty");
                }

                if (value.Length < 12)
                {
                    throw new ArgumentException("The name must be less than 10 symbols");
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("The name can't be empty");
                }

                if (value.Length < 10)
                {
                    throw new ArgumentException("The name must be less than 10 symbols");
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 && value <= 120)
                {
                    throw new ArgumentOutOfRangeException("The number must be positive");
                }
                age = value;
            }
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public string GetInfo()
        {
            return $"{firstName} {lastName} is {age} year old";
        }
    }
    public class Program
    {
        static void Main()
        {
            Person person = new Person(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));

            try
            {
                Console.WriteLine($"{person.GetInfo()}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Exception thrown: {e.Message}");
                Console.WriteLine("The age must be in the rage [0 - 120]");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Exception thrown: {e.Message}");
                Console.WriteLine("Invalid name. The name must be at least 3 symbols long, bust shorter than 12");
            }       
        }
    }
}