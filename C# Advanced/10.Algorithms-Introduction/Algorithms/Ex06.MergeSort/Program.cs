using System;
using System.Linq;

namespace Ex06.MergeSort
{
    internal class Program
    {
        public static string MergeSorter(int[] elements)
        {
            if (elements.Length == 1)
            {
                string resultOfOne = elements[0].ToString();
                return resultOfOne;
            }

            if (elements.Length == 2)
            {
                if (elements[0] < elements[1])
                {
                    return $"{elements[0]} {elements[1]}";
                }
                else
                {
                    return $"{elements[1]} {elements[0]}";
                }
            }

            for (int i = 0; i < elements.Length - 1; i++)
            {
                int minElement = elements[i];
                int index = i;

                for (int j = i; j < elements.Length - 1; j++)
                {
                    if (minElement > elements[j + 1])
                    {
                        minElement = elements[j + 1];
                        index = j + 1;
                    }
                }

                int temp = elements[i];
                elements[i] = minElement;
                elements[index] = temp;
            }

            string result = String.Join(" ", elements);

            return result;
        }
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine(MergeSorter(numbers));
        }
    }
}