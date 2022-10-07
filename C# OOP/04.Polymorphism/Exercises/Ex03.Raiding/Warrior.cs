namespace Ex03.Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior()
        {
            Power = 100;
        }
        public override string CastAbility(string heroType, string name)
        {
            return $"{heroType} - {name} hit for {Power} damage";
        }
    }
}