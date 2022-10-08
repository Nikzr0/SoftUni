using System;

namespace Ex04.WildFarm.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight) : base(name, weight)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
        public override void Eat(string typeOfFood, double quantity)
        {
            if (typeOfFood == "Meat")
            {
                Weight += quantity * 0.4;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Dog does not eat {typeOfFood}!");
            }
        }
    }
}