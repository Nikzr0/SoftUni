using System;
using System.Text;

namespace Ex01.Person
{
    public class Person
    {
        protected string name;
        protected int age;
        public string Name { get; set; }
        public virtual int Age
        {
            get 
            {
                if (age < 0)
                {
                    return 0;
                }
                else
                {
                    return age;
                }
            }
            set
            {             
                age = value;
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format($"Name: {Name}, Age {Age}"));
            return sb.ToString();
        }
    }

    public class Child : Person
    {
        public override int Age
        {
            get {
                if (age <= 15)
                {
                    return age;
                }
                else
                {
                    return 15;
                }
            }
            set
            {
                age = value;
            }
        }
        public Child(string name, int age) : base(name, age)
        {

        }
    }

    public class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Child child = new Child(name, age);
            Console.WriteLine(child);
        }
    }
}