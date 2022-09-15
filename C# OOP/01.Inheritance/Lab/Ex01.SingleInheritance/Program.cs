using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01.SingleInheritance
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
    public class Program
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
        }
    }
}