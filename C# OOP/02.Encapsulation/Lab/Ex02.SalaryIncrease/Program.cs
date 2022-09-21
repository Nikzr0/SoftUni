using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class Person
    {
        private string name;
        private string lastName;
        private int age;
        private decimal salary;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Person(string name, string lastName, int age, decimal salary)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
        public void IncreaseSalary(decimal percentage)
        {
            decimal x = 100 / percentage;

            if (Age < 30)
            {
                x = x / 2;
                Salary = Salary + Salary / x;
            }
            else
            {
                Salary = Salary + Salary / x;
            }
        }
        public override string ToString()
        {
            return $"{this.Name} {this.LastName} receives {this.Salary:f2} levas.";
        }
    }

    public class StartUp
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            var parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}