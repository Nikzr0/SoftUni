using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex09.PokemonTrainer
{
    class Trainer
    {
        public string Name { get; set; }
        public int NumbersOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Trainer()
        {
            Pokemons = new List<Pokemon>();
            NumbersOfBadges = 0;
        }

        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            Pokemons = pokemons;
        }

        public Trainer(string name, int badges, List<Pokemon> pokemons)
        {
            Name = name;
            NumbersOfBadges = badges;
            Pokemons = pokemons;
        }
    }

    class Pokemon
    {
        public string Name { get; set; }

        public string Element { get; set; }
        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
    }
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<Pokemon>> trainers = new Dictionary<string, List<Pokemon>>();
            Dictionary<string, int[]> trainerInfo = new Dictionary<string, int[]>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Tournament") // "{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                {
                    break;
                }

                string[] command = input.Split(" ");

                string trainerName = command[0];
                string pokemonName = command[1];
                string pokemonElement = command[2];
                int pokemonHealth = int.Parse(command[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer();

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new List<Pokemon>());
                    trainers[trainerName].Add(pokemon);

                    trainerInfo.Add(trainerName, new int[] { trainer.NumbersOfBadges, 1 });
                }
                else
                {
                    trainers[trainerName].Add(pokemon);

                    trainerInfo[trainerName][1]++;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                bool existingBadge = true;
                foreach (var item in trainers)
                {
                    foreach (var pokemon in item.Value.ToList())
                    {
                        if (pokemon.Element == input)
                        {
                            trainerInfo[item.Key][0]++;
                            existingBadge = false;
                        }
                        else
                        {
                            if (existingBadge)
                            {
                                if (pokemon.Health > 10)
                                {
                                    pokemon.Health -= 10;
                                }
                                else
                                {
                                    trainers[item.Key].Remove(pokemon);
                                }
                            }  
                        }
                    }
                }
            }

            foreach (var item in trainerInfo)
            {
                Console.WriteLine($"{item.Key} {item.Value[0]} {item.Value[1]}");
            }
        }
    }
}