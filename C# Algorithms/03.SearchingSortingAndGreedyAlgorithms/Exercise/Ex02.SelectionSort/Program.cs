using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Ex02.SelectionSort
{
    public class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            ArraySorter(arr, 0);
        }

        private static void ArraySorter(int[] arr, int index)
        {
            if (ArrValidator(arr))
            {
                Console.WriteLine(String.Join(" ", arr));
                return;
            }

            int temp = arr[index];
            int n = MinValueIndex(arr, index);
            arr[index] = arr[n];
            arr[n] = temp;


            ArraySorter(arr, index + 1);
        }

        private static int MinValueIndex(int[] arr, int index)
        {
            int result = 0;
            int minValue = int.MaxValue;

            for (int i = index; i < arr.Length; i++)
            {
                if (arr[i] <  minValue)
                {
                    minValue = arr[i];
                    result = i;
                }
            }

            return result;
        }
        private static bool ArrValidator(int[] arr)
        {
            bool result = false;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] < arr[i + 1])
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}