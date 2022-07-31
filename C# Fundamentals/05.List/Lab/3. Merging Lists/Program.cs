using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> theBigOne = new List<int>();

        if (firstList.Count > secondList.Count)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Count - 1 >= i)
                {
                    theBigOne.Add(firstList[i]);
                    theBigOne.Add(secondList[i]);
                }
                else
                {
                    theBigOne.Add(firstList[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < secondList.Count; i++)
            {
                if (firstList.Count - 1 >= i)
                {
                    theBigOne.Add(firstList[i]);
                    theBigOne.Add(secondList[i]);
                }
                else
                {
                    theBigOne.Add(secondList[i]);
                }
            }
        }

        Console.WriteLine(String.Join(" ", theBigOne));

    }
}