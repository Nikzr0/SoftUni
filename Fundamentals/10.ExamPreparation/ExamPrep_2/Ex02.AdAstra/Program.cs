using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Ex02.AdAstra
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"([#|\/])([A-Za-z ]+)\1([0-9]{2})([#|\/])([0-9]{2})\4([0-9]{2})([#|\/])([0-9]{1,5})\7");
            MatchCollection myMatch = regex.Matches(input);

            int totalKcals = 0;
            //string productName = "";

            foreach (Match item in myMatch)
            {
                string totalEnergy = item.Groups[8].ToString();
                totalKcals += int.Parse(totalEnergy);
            }

            Console.WriteLine($"You have food to last you for: {totalKcals / 2000} days!");

            foreach (Match item in myMatch)
            {
                Console.WriteLine($"Item: {item.Groups[2].ToString()}, Best before: {item.Groups[3]}/{item.Groups[5]}/{item.Groups[6]}, Nutrition: {item.Groups[8]}");
            }
        }
    }
}