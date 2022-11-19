using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.DividingPresents
{
    public class Program
    {
        static void Main()
        {
            List<int> Alan = new List<int>();
            List<int> Bob = new List<int>();

            int[] presents = Console.ReadLine().Split(" ").Select(int.Parse).OrderBy(x => x).ToArray();
            int targetSum = presents.Sum() / 2;
            Devide(presents, targetSum, Alan, Bob);
        }
        private static void Devide(int[] presents, int targetSum, List<int> alon, List<int> bob)
        {
            if (presents.Sum() == targetSum * 2)
            {

            }
        }
    }
}