using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] arrays = Console.ReadLine().Split();
        Random random = new Random();

        for (int i = 0; i < arrays.Length; i++)// 1 2 3 4
        {
            int newposition = random.Next(arrays.Length);
            string temp = arrays[i];// 1
            arrays[i] = arrays[newposition];// 3
            arrays[newposition] = temp;
        }

        Console.WriteLine(string.Join("\n",arrays));
    }
}