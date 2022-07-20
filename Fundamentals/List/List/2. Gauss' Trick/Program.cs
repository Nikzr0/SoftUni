using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondList = new List<int>();

        int length = list.Count;// 5
        int sum = 0;

        if (list.Count % 2 != 0)
        {
            for (int i = 0; i < list.Count / 2 + 1; i++)
            {
                if (i == list.Count / 2)
                {
                    secondList.Add(list[i]);
                }
                else
                {
                    sum = list[i] + list[length - (i + 1)];
                    secondList.Add(sum);
                }
            }
        }
        else
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                sum = list[i] + list[length - (i + 1)];
                secondList.Add(sum);
            }
        }

        Console.WriteLine(String.Join(" ", secondList));
    }
}