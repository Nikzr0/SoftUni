using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    public class Program
    {
        static void Main() // Some Errors - not 100% (The structure is good!)
        {
            List<int> ingredients = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> freshness = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            for (int i = 0; i < ingredients.Count; i++)
            {
                if (ingredients[i] == 0)
                {
                    ingredients.Remove(ingredients[i]);
                }
            }

            int dippingSouce = 0;
            int greenSalad = 0;
            int chocoladeCake = 0;
            int lobster = 0;


            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                int ingredient = ingredients[0];
                ingredients.RemoveAt(0);

                int freshnessValue = freshness[freshness.Count - 1];
                freshness.RemoveAt(freshness.Count - 1);

                int sum = ingredient * freshnessValue;

                switch (sum)
                {
                    case 150:
                        dippingSouce++;
                        break;

                    case 250:
                        greenSalad++;
                        break;

                    case 300:
                        chocoladeCake++;
                        break;

                    case 400:
                        lobster++;
                        break;

                    default:
                        ingredients.Insert(ingredients.Count - 1, ingredient + 5);
                        break;
                }
            }

            if (dippingSouce != 0 && greenSalad != 0 && chocoladeCake != 0 && lobster != 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($" # Chocolate cake --> {chocoladeCake}");
                Console.WriteLine($" # Dipping sauce --> {dippingSouce}");
                Console.WriteLine($" # Green salad --> {greenSalad}");
                Console.WriteLine($" # Lobster --> {lobster}");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                int excessIngredients = 0;
                foreach (var item in ingredients)
                {
                    excessIngredients += item;
                }
                Console.WriteLine($"Ingredients left: {excessIngredients}");

                if (chocoladeCake != 0)
                {
                    Console.WriteLine($" # Chocolate cake --> {chocoladeCake}");
                }

                if (dippingSouce != 0)
                {
                    Console.WriteLine($" # Dipping sauce --> {dippingSouce}");
                }

                if (greenSalad != 0)
                {
                    Console.WriteLine($" # Green salad --> {greenSalad}");
                }

                if (lobster != 0)
                {
                    Console.WriteLine($" # Lobster --> {lobster}");
                }
            }
        }
    }
}