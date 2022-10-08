namespace Ex04.WildFarm.Mammals
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight) : base(name, weight)
        {
        }

        public string Breed { get; set; }
    }
}