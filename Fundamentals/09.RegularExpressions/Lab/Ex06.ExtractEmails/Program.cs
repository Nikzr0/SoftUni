using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex06.ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            //char[] chars = new char[] { '.', '-', '_', };
            List<string> list = new List<string>();

            Regex regex = new Regex(@"([A-Za-z0-9+_.-]+)@([a-zA-Z0-9.-]+)");
            Regex finalRegex = new Regex(@"([A-Za-z0-9+_.-]+@[a-zA-Z0-9.-]+)");

            MatchCollection myMatch = regex.Matches(text);
            MatchCollection finalMatch = regex.Matches(text);

            foreach (Match item in myMatch)
            {
                string a = item.Groups[1].ToString();
                string b = item.Groups[2].ToString();

                if (a[0] != '.' && a[0] != '-' && a[0] != '_')
                {
                    if (a[a.Length - 1] != '.' && a[a.Length - 1] != '-' && a[a.Length - 1] != '_')
                    {
                        if (b[0] != '.' && b[0] != '-' && b[0] != '_')
                        {
                            if (b.Contains('.') || b.Contains('-') || b.Contains('_'))
                            {
                                if (b[b.Length - 1] != '.' && b[b.Length - 1] != '-' && b[b.Length - 1] != '_')
                                {
                                    list.Add($"{item.Groups[1]}@{item.Groups[2]}");
                                }
                            }

                        }
                    }
                }

            }

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
