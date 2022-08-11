using System;
using System.Collections.Generic;
using System.IO;

namespace Ex01.EvenLines
{
    internal class Program
    {
        static void Main()
        {
            using StreamReader textReader = new StreamReader(@"text.txt");
            using StreamWriter writer = new StreamWriter("output.txt");

            List<char> charList = new List<char> { '-', ',', '.', '!', '?' };

            List<string> lines = new List<string>();

            while (!textReader.EndOfStream)
            {
                lines.Add(textReader.ReadLine());
            }

            for (int i = 0; i < lines.Count; i++)
            {
                string[] words = lines[i].Split(" ");
                Array.Reverse(words);

                for (int y = 0; y < words.Length; y++)
                {
                    char[] lettersInWord = words[y].ToCharArray();

                    for (int t = 0; t < lettersInWord.Length; t++)
                    {
                        if (charList.Contains(lettersInWord[t]))
                        {
                            lettersInWord[t] = '@';
                        }
                    }

                    string newWord = string.Join("", lettersInWord);

                    words[y] = newWord; 
                }

                string newLine = string.Join(" ", words);
                lines[i] = newLine;
            }

            for (int i = 0; i < lines.Count; i++)
            {
                if (i % 2 == 0)
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }
    }
}