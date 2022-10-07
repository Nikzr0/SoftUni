namespace Ex03.Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue()
        {
            Power = 80;
        }
        public override string CastAbility(string heroType, string name)
        {
            return $"{heroType} - {name} hit for {Power} damage";
        }
    }
}