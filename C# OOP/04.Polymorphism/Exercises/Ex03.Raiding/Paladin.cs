namespace Ex03.Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin()
        {
            Power = 100;
        }
        public override string CastAbility(string heroType,string name)
        {
            return $"{heroType} - {name} healed for {Power}";
        }
    }
}