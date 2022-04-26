using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();// 3 3 6 1

        for (int i = 0; i < list.Count; i++)
        {
            int sum = 0;
            if (i >= 1)
            {
                if (list[i - 1] == list[i])
                {
                    sum = list[i - 1] + list[i];
                    list[i - 1] = sum;
                    list.RemoveAt(i);
                    i--;
                    i = i - 1;
                }
            }
        }

        Console.WriteLine(String.Join(" ", list));
    }
}