using System;
using System.Text.RegularExpressions;

namespace Ex02.MatchPhoneNumber
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\+359([ -])2\1[0-9]{3}\1[0-9]{4}");

            MatchCollection myMatch = regex.Matches(input);
            Console.WriteLine();


            Console.WriteLine(string.Join(", ", myMatch));
        }
    }
}