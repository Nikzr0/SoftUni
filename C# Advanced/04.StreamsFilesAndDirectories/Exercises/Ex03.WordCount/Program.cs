using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace Ex03.WordCount
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> dicOfWords = new Dictionary<string, int>();
            List<string> words = File.ReadAllLines("words.txt").ToList();
            List<string> lines = File.ReadAllLines("text.txt").ToList();

            Regex regex = new Regex(@"([A-Za-z ])");

            foreach (var item in words)
            {
                if (!dicOfWords.ContainsKey(item))
                {
                    dicOfWords.Add(item, 0);
                }
            }

            foreach (var word in words)
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    MatchCollection myMatch = regex.Matches(lines[i]);
                    string text = "";
                    foreach (var item in myMatch)
                    {
                        text += item;
                    }
                    text = text.ToLower();
                    List<string> wordsInTheText = text.Split(" ").ToList();

                    foreach (var item in wordsInTheText)
                    {
                        if (word == item.ToString())
                        {
                            dicOfWords[word]++;
                        }
                    }
                }
            }

            foreach (var item in dicOfWords)
            {
                string result = $"{item.Key} - {item.Value}{Environment.NewLine}";
                File.AppendAllText("actualResult.txt", result);
            }

            foreach (var item in dicOfWords.OrderByDescending(x => x.Value))
            {
                string result = $"{item.Key} - {item.Value}{Environment.NewLine}";
                File.AppendAllText("expectedResult.txt", result);
            }
        }
    }
}