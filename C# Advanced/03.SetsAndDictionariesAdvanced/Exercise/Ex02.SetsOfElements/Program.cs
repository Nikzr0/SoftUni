using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02.SetsOfElements
{
    public class Program
    {
        public static void Main()
        {
            HashSet<int> fisrtHesh = new HashSet<int>();
            HashSet<int> secHesh = new HashSet<int>();           

            int[] nums =Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int firstNum = nums[0];
            int secNum = nums[1];

            for (int i = 0; i < firstNum; i++)
            {
                int num = int.Parse(Console.ReadLine());
                fisrtHesh.Add(num);
            }

            for (int i = 0; i < secNum; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secHesh.Add(num);
            }

            List<int> dupNumbers = fisrtHesh.Intersect(secHesh).ToList();

            Console.WriteLine(String.Join(" ", dupNumbers));
        }
    }
}