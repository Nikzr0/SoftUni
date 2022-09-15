using System;
using System.Collections.Generic;

namespace Ex03.HierarchicalInheritance
{

    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("meowing...");
        }
    }
    public class Program
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.WriteLine();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}