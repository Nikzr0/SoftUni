using System;
using System.Linq;

class Program
{
    static void Main()// 6 5 2 3
    {

        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();// 3 2 5 6
        int[] result = new int[array.Length];

        for (int i = 0; i < array.Length ; i++)
        {
            result[i] = array[array.Length - (1 + i)];   
        }

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

    }
}