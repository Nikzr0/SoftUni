using System;
using System.Linq;

namespace Ex03.BubbleSort
{
    public class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            BubbleSort(arr, 0, arr.Length - 1);
        }

        private static void BubbleSort(int[] arr, int index, int endIndex)
        {
            if (index == arr.Length - 1 || index == endIndex)
            {
                endIndex--;
                index = 0;
            }
            if (ArrValidator(arr))
            {
                Console.WriteLine(String.Join(" ", arr));
                return;
            }

            if (arr[index] > arr[index + 1])
            {
                int temp = arr[index];
                arr[index] = arr[index + 1];
                arr[index + 1] = temp;
            }        
            BubbleSort(arr, index + 1, endIndex);
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