using System;

namespace Ex04.WildFarm.Mammals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight) : base(name, weight)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
        public override void Eat(string typeOfFood, double quantity)
        {
            if (typeOfFood == "Meat" || typeOfFood == "Vegetable")
            {
                Weight += quantity * 0.3;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Cat does not eat {typeOfFood}!");
            }
        }
    }
}