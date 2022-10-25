using System;
using System.Collections.Generic;

namespace L02.PermutationsWithRepetitions
{
    public class Program
    {
        private static string[] elements;
        private static string[] outputArr;
        private static bool[] used;
        public static HashSet<string> permutations;
        static void Main()
        {
            elements = Console.ReadLine().Split(" ");
            outputArr = new string[elements.Length];
            used = new bool[elements.Length];
            permutations = new HashSet<string>();

            Permut(0);

            foreach (var item in permutations)
            {
                Console.WriteLine(item);
            }
        }

        private static void Permut(int index)
        {
            if (index >= elements.Length)
            {
                permutations.Add(string.Join(" ", outputArr));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    outputArr[index] = elements[i];
                    Permut(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
