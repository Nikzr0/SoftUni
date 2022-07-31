using System;
using System.Collections.Generic;
using System.Linq;


namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split().ToList();
            Dictionary<string, int> oddWords = new Dictionary<string, int>();


            for (int i = 0; i < words.Count; i++)
            {
                if (!oddWords.ContainsKey(words[i]))
                {
                    oddWords.Add(words[i].ToLower(), 1);
                }
                else
                {
                    oddWords[words[i]]++;
                }
            }

            foreach (var item in oddWords)
            {
                if (item.Value % 2 == 0)
                {
                    oddWords.Remove(item.Key);
                }
            }

            Console.WriteLine(String.Join(" ", oddWords.Keys));


        }
    }
}
