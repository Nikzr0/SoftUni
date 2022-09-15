using System;
using System.Collections.Generic;

namespace Ex02.MultipleInheritance
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

    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("weaping...");
        }
    }
    public class Program
    {
        static void Main()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}