using System;

namespace ValidationAttributes
{
    public partial class StartUp
    {
        /*The Attributes are working individually,
         * but not combined */
        public class Person
        {
            [MyRequired]
            public string FullName { get; set; }

            [Range(1,99)]
            public int Age { get; set; }
            public Person(string fullName, int age)
            {
                FullName = fullName;
                Age = age;
            }
        }
    }
}
