using System;

class Program
{
    static void Matrix(int num)
    {
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Matrix(num);
    }
}