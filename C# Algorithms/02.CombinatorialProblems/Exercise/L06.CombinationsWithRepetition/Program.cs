using System;

namespace L06.CombinationsWithRepetition
{
    public class Program
    {
        private static string[] elements;
        private static string[] outputArr;
        private static int k;
        static void Main()
        {
            elements = Console.ReadLine().Split(" ");
            k = int.Parse(Console.ReadLine());
            outputArr = new string[elements.Length];

            Permut(0, 0);
        }

        private static void Permut(int index, int elStartIndex)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", outputArr));
                return;
            }

            for (int i = elStartIndex; i < elements.Length; i++)
            {
                outputArr[index] = elements[i];
                Permut(index + 1, i);
            }
        }
    }

}
