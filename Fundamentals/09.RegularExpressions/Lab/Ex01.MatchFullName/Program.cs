using System;
using System.Text.RegularExpressions;

namespace Ex01.MatchFullName
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b");

            MatchCollection myMatch = regex.Matches(input);

            foreach (Match item in myMatch)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}