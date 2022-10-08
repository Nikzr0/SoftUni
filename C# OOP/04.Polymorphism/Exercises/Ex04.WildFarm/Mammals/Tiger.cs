using System;

namespace Ex04.WildFarm.Mammals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight) : base(name, weight)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
        public override void Eat(string typeOfFood, double quantity)
        {
            if (typeOfFood == "Meat")
            {
                Weight += quantity * 1;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Tiger does not eat {typeOfFood}!");
            }
        }
    }
}