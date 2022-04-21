using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();   // 3 2 5 6 => 6 5 3 2

        for (int i = 0; i < array.Length; i++)
        {
            

            for (int b = 0; b < array.Length - 1 ; b++)
            {
                int temp = array[2];
                array[array.Length - 2] = array[array.Length - 1];
                array[array.Length - 1] = temp;
            }
        }

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
