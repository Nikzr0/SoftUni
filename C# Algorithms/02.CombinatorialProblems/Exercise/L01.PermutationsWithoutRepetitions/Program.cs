using System;

namespace L01.PermutationsWithoutRepetitions
{
    public class Program
    {
        private static string[] elements;
        private static string[] outputArr;
        private static bool[] used;
        static void Main()
        {
            elements = Console.ReadLine().Split(" ");
             outputArr = new string[elements.Length];
             used = new bool[elements.Length];

            Permut(0);
        }

        private static void Permut(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", outputArr));
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
