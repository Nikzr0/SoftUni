using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class Person
    {
        private string name;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string name, string lastName, int age, decimal salary)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols");
                }

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
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
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
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer");
                }
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 650)
                {
                    salary = value;
                }
                else
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva");
                }
            }
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
    }

    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public IReadOnlyCollection<Person> FirstTeam
        {
            get
            {
                return firstTeam;
            }
            private set { }
        }
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get
            {
                return reserveTeam;
            }
            private set { }
        }
        public Team(string name)
        {
            Name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
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

            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"First team has {team.ReserveTeam.Count} players.");
        }
    }
}