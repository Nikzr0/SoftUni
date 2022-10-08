using System;

namespace Ex04.WildFarm.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
        public override void Eat(string typeOfFood, double quantity)
        {
            if (typeOfFood == "Meat")
            {
                Weight += quantity * 0.25;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Owl does not eat {typeOfFood}!");
            }
        }
    }
}