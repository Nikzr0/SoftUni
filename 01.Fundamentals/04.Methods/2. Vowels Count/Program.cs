using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static int VowelsCount(string input)
    {
        string word = input.ToUpper();
        int count = 0;

       
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'A' || word[i] == 'O' || word[i] == 'E' || word[i] == 'I' || word[i] == 'U')
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        string word = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(VowelsCount(word));
    }
}