using System;
using System.Text.RegularExpressions;

namespace Ex03.MatchDates
{
    class Program
    {
        static void Main()
        {  
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"(?<day>[0-9]{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}