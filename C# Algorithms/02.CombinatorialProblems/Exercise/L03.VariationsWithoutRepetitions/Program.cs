using System;

namespace L03.VariationsWithoutRepetitions
{
    public class Program
    {
        private static string[] elements;
        private static string[] outputArr;
        private static bool[] used;
        private static int k;
        static void Main()
        {
            elements = Console.ReadLine().Split(" ");
             k = int.Parse(Console.ReadLine());
            outputArr = new string[elements.Length];
            used = new bool[elements.Length];

            Permut(0);
        }

        private static void Permut(int index)
        {
            if (index >= k)
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
