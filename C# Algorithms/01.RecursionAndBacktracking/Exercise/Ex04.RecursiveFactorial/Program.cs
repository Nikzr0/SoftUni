using System;

namespace Ex04.RecursiveFactorial
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Facturial(n));
        }

        public static int Facturial(int n)
        {
            if (n == 2)
            {
                return n;
            }
            return n * Facturial(n - 1);
        }
    }
}