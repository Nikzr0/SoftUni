using System;

namespace Ex5.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);

            if (result == 0) // There are people with the same name
            {
                result = Age.CompareTo(other.Age);
            }

            if (result == 0) // There artre to people with the same name and the same age
            {
                result = Town.CompareTo(other.Town);
            }

            return result;
        }
    }
}