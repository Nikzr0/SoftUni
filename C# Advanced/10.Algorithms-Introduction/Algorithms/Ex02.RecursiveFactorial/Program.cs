using System;

namespace Ex02.RecursiveFactorial
{
    public class Program
    {
        static int Fact(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            int sum = number * Fact(number - 1);

            return sum;
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = Fact(number);
            Console.WriteLine(sum);
        }
    }
}