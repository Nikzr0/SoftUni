using System;
using System.Collections;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string output = "";

        for (int i = 0; i < input.Length; i++)
        {
            int temp = input[i] + 3;
            output += (char)temp;
        }

        Console.WriteLine(output);
    }
}