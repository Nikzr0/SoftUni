using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

       

        if (nums.Count < 3)
        {
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            };


        }
        else
        {
            foreach (var item in nums.OrderByDescending(x => x).Take(3))
            {
                Console.Write(item + " ");
            }
        }

    }
}