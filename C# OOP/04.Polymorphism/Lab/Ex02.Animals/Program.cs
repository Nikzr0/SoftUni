using System;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string FavoriteFood { get; set; }

        public virtual string ExplainSelf()
        {
            return "Hi!!";
        }
        public Animal(string name, string favoriteFood)
        {
            Name = name;
            FavoriteFood = favoriteFood;
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }
        public override string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavoriteFood}" +
                $"{Environment.NewLine}MEEOW{Environment.NewLine}";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }
        public override string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavoriteFood}" +
                $"{Environment.NewLine}DJAAF{Environment.NewLine}";
        }
    }
    public class StartUp
    {
        static void Main()
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("George", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}