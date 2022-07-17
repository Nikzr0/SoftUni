using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> listOfSynonyms = new Dictionary<string, List<string>>();
        Dictionary<string, int> checker = new Dictionary<string, int>();

        int n = int.Parse(Console.ReadLine());

        string word = Console.ReadLine();

        if (!listOfSynonyms.ContainsKey(word))
        {
            listOfSynonyms.Add(word, new List<string>());
        }

        while (n > 0)
        {
            string synonymes = Console.ReadLine();

            if (!listOfSynonyms.ContainsKey(synonymes))
            {
                //if (!checker.ContainsKey(synonymes))
                //{
                    checker.Add(synonymes, 1);
                //}
                //else
                //{
                //    checker[synonymes]++;
                //    n++;
                //}
            }
            else
            {
                n++;
            }
            n--;
        }


        foreach (var item in checker)
        {
            if (!listOfSynonyms.ContainsKey(item.Key))
            {
                listOfSynonyms[word].Add(item.Key);
            }
        }

        Console.WriteLine();
        foreach (var item in listOfSynonyms)
        {
            Console.WriteLine($"{item.Key} - {String.Join(", ",item.Value)}");
        }


    }
}