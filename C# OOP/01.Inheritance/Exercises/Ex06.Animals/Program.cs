using System;
using System.Linq;

namespace Ex06.Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public virtual string ProduceSound()
        {
            return "-|-";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return "Ribbit";
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return "Meow!";
        }
    }
    public class Kitten : Cat // Not sure fore their output!
    {
        public Kitten(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return "Meow!";
        }
    }
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return "MEOW!";
        }
    }

    public class Program
    {
        static void Main()
        {
            while (true)
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }

                string[] command = Console.ReadLine().Split(" ");

                switch (animalType)
                {
                    case "Cat":
                        Cat cat = new Cat(command[0], int.Parse(command[1]), command[2]);

                        if (cat.Gender == "Male")
                        {
                            Console.WriteLine(cat.ProduceSound().ToUpper());
                        }
                        else
                        {
                            Console.WriteLine(cat.ProduceSound().ToLower());
                        }
                        break;

                    case "Dog":
                        Dog dog = new Dog(command[0], int.Parse(command[1]), command[2]);

                        if (dog.Gender == "Male")
                        {
                            Console.WriteLine(dog.ProduceSound().ToUpper());
                        }
                        else
                        {
                            Console.WriteLine(dog.ProduceSound().ToLower());
                        }
                        break;

                    case "Frog":
                        Frog frog = new Frog(command[0], int.Parse(command[1]), command[2]);

                        if (frog.Gender == "Male")
                        {
                            Console.WriteLine(frog.ProduceSound().ToUpper());
                        }
                        else
                        {
                            Console.WriteLine(frog.ProduceSound().ToLower());
                        }
                        break;
                }
            }

        }
    }
}