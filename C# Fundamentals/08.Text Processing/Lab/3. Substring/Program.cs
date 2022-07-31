using System;


class Program
{
    static void Main()
    {
        string word = Console.ReadLine(); // ice
        string text = Console.ReadLine(); // kicegiciceeb

        int index = text.IndexOf(word); // It finds the index of word (3)

        while (index >= 0)
        {
            text = text.Remove(index, word.Length);
            index = text.IndexOf(word);
        }

        Console.WriteLine(text);
    }
}