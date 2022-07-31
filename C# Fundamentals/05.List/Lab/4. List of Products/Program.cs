using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string temp = Console.ReadLine();
            list.Add(temp);
        }

        list.Sort();

        Console.WriteLine();

        int x = 1;

        foreach (var item in list)
        {
            Console.WriteLine($"{x}.{item}");
            x++;
        }
    }
}