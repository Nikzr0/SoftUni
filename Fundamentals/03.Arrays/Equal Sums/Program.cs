using System;
using System.Collections.Generic;
using System.Linq;


class Program // Не знам !!!!!!!
{
    static void Main()
    {

        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            //leftSum
            leftSum = 0;
            for (int b = i; b > 0 ; b--)
            {
                int nextElementPosition = b - 1;

                if (b > 0)
                {
                    b += array[nextElementPosition];
                }
            }
            //rightSum
            rightSum = 0;
            for(int c = i; c < array.Length; c++)
            {
                int nextElementPosition = (c + 1);

                if (c < array.Length - 1)
                {
                    rightSum += array[nextElementPosition];
                }
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine(i);
                return;
            }
            Console.WriteLine("no");
        }

    }
}