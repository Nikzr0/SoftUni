using System;

namespace Ex07.RecursiveFibonacci
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n + 1));
        }

        private static int GetFibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }

            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}
