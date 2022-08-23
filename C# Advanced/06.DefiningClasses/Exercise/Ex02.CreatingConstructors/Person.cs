namespace Ex02.CreatingConstructors
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(string name)
        {
            Name = "No name";
        }

        public Person(int age)
        {
            Age = 1;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}