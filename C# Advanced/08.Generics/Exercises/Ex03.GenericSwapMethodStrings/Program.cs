﻿using System;
using System.Linq;

namespace Ex03.GenericSwapMethodStrings
{
    public partial class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Swaper<string> swapper = new Swaper<string>();

            for (int i = 0; i < n; i++)
            {
                swapper.Add(Console.ReadLine());
            }

            int[] indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            swapper.Swap(indexes[0], indexes[1]);

            Console.WriteLine(swapper.ToString());
        }
    }
}