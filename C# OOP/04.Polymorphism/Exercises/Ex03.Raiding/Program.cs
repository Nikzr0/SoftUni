using System;
using System.Collections.Generic;

namespace Ex03.Raiding
{
    public class Program
    {
        static void Main()
        {
            List<string> result = new List<string>();
            Druid druid = new Druid();
            Paladin paladin = new Paladin();
            Rogue rogue = new Rogue();
            Warrior warrior = new Warrior();

            int combinedStrength = 0;

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                switch (heroType)
                {
                    case"Druid":
                        result.Add(druid.CastAbility(heroType, heroName));
                        combinedStrength += druid.Power;
                        break;

                    case "Paladin":
                        result.Add(paladin.CastAbility(heroType, heroName));
                        combinedStrength += paladin.Power;
                        break;

                    case "Rogue":
                        result.Add(rogue.CastAbility(heroType, heroName));
                        combinedStrength += rogue.Power;
                        break;

                    case "Warrior":
                        result.Add(warrior.CastAbility(heroType, heroName));
                        combinedStrength += warrior.Power;
                        break;
                }
            }
            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in result)
            {
                Console.WriteLine(hero);
            }
            if (combinedStrength > bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}