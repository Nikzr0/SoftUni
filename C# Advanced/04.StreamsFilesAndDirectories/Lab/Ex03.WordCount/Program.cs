using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using StreamReader text = new StreamReader("text.txt");
            using StreamReader input = new StreamReader("input.txt");
            using StreamWriter output = new StreamWriter("output.txt");

            Dictionary<string,int> dic = new Dictionary<string, int>();

            List<string> words = new List<string>();

            while (!text.EndOfStream)
            {
                string[] line = text.ReadLine().Split(" ");

                for (int i = 0; i < line.Length; i++)
                {
                    if (!dic.ContainsKey(line[i]))
                    {
                        dic.Add(line[i], 1);
                    }
                    else
                    {
                        dic[line[i]]++;
                    }
                }

            }

            while (!input.EndOfStream)
            {
                string[]  outputWords = input.ReadLine().ToLower().Split(" ");

                foreach (var item in outputWords)
                {
                    words.Add(item);
                }
            }

            foreach (var item in dic)
            {
                string key = item.Key;
                foreach (var listItem in words) 
                {
                    if (item.Key == listItem)
                    {
                        dic[key]++;
                    }
                }
            }

            foreach (var item in dic.OrderByDescending(x=>x.Value))
            {
                output.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
