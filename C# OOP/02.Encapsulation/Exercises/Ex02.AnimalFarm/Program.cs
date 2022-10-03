using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02.AnimalFarm
{
    public class Chicken
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length == 0 || value.Length == null)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else if (value == " ")
                {
                    throw new ArgumentException("Invalid name");
                }

                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (age < 0 || age > 15)
                {
                    throw new ArgumentException($"Age should be between 0 and 15");
                }
                age = value;
            }
        }
        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Chicken chicken = new Chicken(name,age);

            Console.WriteLine($"Chicken {chicken.Name} (age {chicken.Age}) can produce 1 eggs per day;");

        }
    }
}