using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            string temp = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                temp += input[i];
            }

            words.Add($"{input} = {temp}");
        }

        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }
}