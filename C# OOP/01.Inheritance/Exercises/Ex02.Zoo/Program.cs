using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02.Zoo
{
    public class Anumal
    {
        public string Name { get; set; }

        public Anumal(string name)
        {
            Name = name;
        }
    }
    public class Reptile : Anumal
    {
        public Reptile(string name) : base(name)
        {
        }
    }
    public class Lizard : Reptile
    {
        public Lizard(string name) : base(name)
        {
        }
    }
    public class Snake : Reptile
    {
        public Snake(string name) : base(name)
        {
        }
    }
    public class Mammal : Anumal
    {
        public Mammal(string name) : base(name)
        {
        }
    }
    public class Gorilla : Mammal
    {
        public Gorilla(string name) : base(name)
        {
        }
    }
    public class Bear : Anumal
    {
        public Bear(string name) : base(name)
        {
        }
    }

    public class StartUp
    {
        static void Main()
        {

        }
    }
}