using System;

namespace Ex04.WildFarm.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight) : base(name, weight)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
        public override void Eat(string typeOfFood, double quantity)
        {
            if (typeOfFood == "Vegetable" || typeOfFood == "Fruit")
            {
                Weight += quantity * 0.1;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Mouse does not eat {typeOfFood}!");
            }
        }
    }
}