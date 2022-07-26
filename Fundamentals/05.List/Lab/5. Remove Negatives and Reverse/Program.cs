using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> newList = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] >= 0)
            {
                newList.Add(list[i]);
            }
        }
        if (newList.Count == 0)
        {
            Console.WriteLine("empty");
        }
        newList.Reverse();
        Console.WriteLine(String.Join(" ",newList));
    }
}
