using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Ex02.Race
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> finalParticipants = new Dictionary<string, int>();
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            int[] arr = new int[3];

            string name = "";
            int distance = 0;

            while (true)
            {
                string alphaChars = Console.ReadLine();

                if (alphaChars == "end of race")
                {
                    break;
                }

                Regex regex = new Regex(@"([A-Z])|([a-z])"); // RegexOptions.Singleline
                Regex regex2 = new Regex(@"([0-9])");

                var matches = regex.Matches(alphaChars);
                var matches2 = regex2.Matches(alphaChars);


                foreach (var letters in matches)
                {
                    name += letters.ToString();
                }

                foreach (var digits in matches2)
                {
                    distance += int.Parse(digits.ToString());
                }


                if (participants.Contains(name))
                {
                    if (!finalParticipants.ContainsKey(name))
                    {
                        finalParticipants.Add(name, distance);
                    }
                    else
                    {
                        finalParticipants[name] += distance;
                    }
                }

                name = "";
                distance = 0;
            }

            Console.WriteLine();
            int counter = 1;
            foreach (var item in finalParticipants.OrderByDescending(x => x.Value).Take(3))
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }

                if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }

                if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }

                counter++;
            }
        }
    }
}