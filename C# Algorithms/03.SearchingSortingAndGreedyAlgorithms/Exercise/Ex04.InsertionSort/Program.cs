using System;
using System.Linq;

namespace Ex04.InsertionSort
{
    public class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            InsertionSort(arr, 1);
        }

        private static void InsertionSort(int[] arr, int index)
        {
            if (ArrValidator(arr))
            {
                Console.WriteLine(String.Join(" ", arr));
                return;
            }
            Sorter(arr, index);
            InsertionSort(arr, index + 1);
        }
        private static void Sorter(int[] arr, int index)
        {
            if (arr[index] < arr[index - 1])
            {
                for (int i = 0; i < index; i++)
                {
                    int temp = arr[index - (i + 1)];
                    arr[index - (i + 1)] = arr[index - i];
                    arr[index - i] = temp;

                    int[] secArr = new int[index];
                    for (int p = 0; p < index; p++)
                    {
                        secArr[p] = arr[p];
                    }

                    if (ArrValidator(secArr))
                    {
                        break;
                    }
                }
            }
        } 
        private static bool ArrValidator(int[] arr)
        {
            bool result = false;

            if (arr.Length ==  2)
            {
                if (arr[0] < arr[1])
                {
                    result = true;
                }
            }
            else if (arr.Length >2)
            {
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
            }  
            return result;
        }
    }
}