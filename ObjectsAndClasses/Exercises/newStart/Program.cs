using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string[] arr = new string[num];

        int a = 0;

        while (num > 0)
        {
            string str = Console.ReadLine();

            arr[a] = str;

            num--;
            a++;
        }


        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i].Length;
        }


        Console.WriteLine(sum);
    }
}