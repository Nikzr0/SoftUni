namespace Ex04.WildFarm
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double FoodEaten { get; set; }

        public abstract void ProduceSound();
        public virtual void Eat(string typeOfFood, double quantity)
        {
            Weight += quantity;
            FoodEaten += quantity;
        }

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}