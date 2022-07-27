using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Ex04.StarEnigma
{
    class Program
    {
        static void Main()
        {
            List<string> attackingPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int n = int.Parse(Console.ReadLine());
            char[] charArr = new char[] {'s', 't', 'a', 'r'};

            int countToDecrise = 0;


            int attackedPlanetsCount = 0;
            int destroyedPlanetsCount = 0;

            Regex regex = new Regex(@".*?@(\p{L}+).?:([0-9]+).+?(A|D).+?([0-9]+)");

            while (n > 0)
            {
                string convertedInput = "";

                string input = Console.ReadLine(); // STCDoghudd4=63333$D$0A53333
                string lowerInput = input.ToLower();


                for (int i = 0; i < input.Length; i++)
                {

                    if (charArr.Contains(lowerInput[i]))
                    {
                        countToDecrise++;
                    }
                }

                for (int j = 0; j < input.Length; j++) // PQ@Alderaa1:30000!A!->20000
                {
                    int x = input[j];
                    convertedInput += Convert.ToChar(x - countToDecrise).ToString();
                }


                MatchCollection myMatch = regex.Matches(convertedInput);

                foreach (Match item in myMatch)
                {
                    if (item.Groups[3].ToString() == "A")
                    {
                        attackingPlanets.Add(item.Groups[1].ToString());
                        attackedPlanetsCount++;
                    }
                    else if (item.Groups[3].ToString() == "D")
                    {
                        destroyedPlanets.Add(item.Groups[1].ToString());
                        destroyedPlanetsCount++;
                    }
                }

                countToDecrise = 0;
                n--;
            }

   

            Console.WriteLine();
            Console.WriteLine($"Attacked planets: {attackedPlanetsCount}");
            foreach (var item in attackingPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanetsCount}");
            foreach (var item in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}