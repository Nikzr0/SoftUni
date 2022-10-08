using System;

namespace Ex04.WildFarm.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
        public override void Eat(string typeOfFood, double quantity)
        {
            Weight += quantity * 0.35;
            FoodEaten += quantity;
        }
    }
}