using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> chars = new List<string>();
        List<string> chars2 = new List<string>();


        string[] digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        //char[] arrOfchars = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
        char[] arrOfchars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        string digitsOutput = "";
        string lettersOutput = "";
        string others = "";

        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            chars.Add(input[i].ToString());
            chars2.Add(input[i].ToString());
        }

        foreach (var item in chars)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (item == digits[i])
                {
                    digitsOutput += item;
                    chars2.Remove(item);
                }
            }
        }

        foreach (var item in chars)
        {
            for (int i = 0; i < arrOfchars.Length; i++)
            {
                if (item == arrOfchars[i].ToString())
                {
                    lettersOutput += item;
                    chars2.Remove(item);
                }
            }
        }

        foreach (var item in chars2)
        {
            others += item;
        }

        Console.WriteLine(digitsOutput);
        Console.WriteLine(lettersOutput);
        Console.WriteLine(others);
    }
}