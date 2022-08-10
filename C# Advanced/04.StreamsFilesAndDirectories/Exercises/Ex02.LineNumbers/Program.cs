using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ex02.LineNumbers
{
    internal class Program
    {
        static void Main()
        {
            using StreamWriter output = new StreamWriter("output.txt");

            string[] lines = File.ReadAllLines("text.txt");
            char[] lettersArrays = new char[] { '-', ',', '.', '!', '?', '\''};

            int countOfSymbols = 0;
            int countOfLetters = 0;
            int counter = 0;

            foreach (var item in lines)
            {
                counter++;
                foreach (var letter in item)
                {
                    if (char.IsLetter(letter))
                    {
                        countOfLetters++;
                    }
                    if (char.IsPunctuation(letter))
                    {
                        countOfSymbols++;
                    }
                }
                output.WriteLine($"Line {counter}: {item} ({countOfLetters})({countOfSymbols})");
                countOfLetters = 0;
                countOfSymbols = 0;
            }
        }
    }
}