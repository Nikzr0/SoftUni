using System;
using System.Linq;

class Program
{

    static void SmallestNum(int a, int b, int c)
    {
        if (a < b)
        {
            if (a < c)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        else
        {
            if (b < c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }



    static void Main()
    {
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numTree = int.Parse(Console.ReadLine());

        SmallestNum(numOne, numTwo, numTree);
    }
}