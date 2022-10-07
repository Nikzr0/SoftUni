namespace Ex03.Raiding
{
    public abstract class BaseHero
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public BaseHero()
        {

        }
        public abstract string CastAbility(string heroType, string name);
    }
}