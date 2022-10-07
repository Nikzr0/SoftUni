namespace Ex03.Raiding
{
    public class Druid : BaseHero
    {
        public Druid()
        {
            Power = 80;
        }
        public override string CastAbility(string heroType, string name)
        {
            return $"{heroType} - {name} healed for {Power}";
        }
    }
}