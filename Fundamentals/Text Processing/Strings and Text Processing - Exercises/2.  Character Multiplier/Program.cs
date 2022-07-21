using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        List<string> words = Console.ReadLine().Split(", ").ToList();
        List<string> output = new List<string>();

        string[] digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", "_" };
        //char[] arrOfchars = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
        char[] arrOfchars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        Regex myRegex;

        foreach (var item in words)
        {
            if (item.Length > 3 && item.Length <= 16 && Regex.IsMatch(item, @"^[a-zA-Z0-9_.-]+$"))
            {
                output.Add(item);
            }
        }

        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }
}