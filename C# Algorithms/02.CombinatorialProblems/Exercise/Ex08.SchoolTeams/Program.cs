using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace Ex08.SchoolTeams
{
    public class Program
    {
        private static string[] girls;
        private static string[] boys;

        private static string girlsCombinations;
        private static string boysCombinations;

        private static string[] gArr = new string[3];
        private static string[] bArr = new string[3];
        static void Main()
        {
            girls = Console.ReadLine().Split(", ");
            boys = Console.ReadLine().Split(", ");

            GetGirlsCombination(0, 0);
            GetBoysCombination(0, 0);

            GetAllCombinations();
        }

        private static void GetAllCombinations()
        {
            List<string> girlsTogether = girlsCombinations.Split("---", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> boysTogether = boysCombinations.Split("---", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int g = 0; g < girlsTogether.Count; g++)
            {
                for (int b = 0; b < boysTogether.Count; b++)
                {
                    // -2 because of a ',' left somethere
                    Console.WriteLine($"{girlsTogether[g]}, {boysTogether[b].Substring(0, boysTogether[b].Length-2)}"); 
                }
            }
        }

        private static void GetGirlsCombination(int startIndex, int elStartIndex)
        {
            if (startIndex >= 3)
            {
                girlsCombinations += string.Join(", ", gArr) + "---";
                return;
            }

            for (int i = elStartIndex; i < girls.Length; i++)
            {
                gArr[startIndex] = girls[i];
                GetGirlsCombination(startIndex + 1, i + 1);
            }
        }

        private static void GetBoysCombination(int startIndex, int elStartIndex)
        {
            if (startIndex >= 2)
            {            
                boysCombinations += string.Join(", ", bArr) + "---";
                return;
            }

            for (int i = elStartIndex; i < boys.Length; i++)
            {
                bArr[startIndex] = boys[i];
                GetBoysCombination(startIndex + 1, i + 1);
            }
        }
    }
}