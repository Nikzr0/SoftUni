namespace Ex04.WildFarm.Mammals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight) : base(name, weight)
        {
        }

        public string LivigRegion { get; set; }
    }
}