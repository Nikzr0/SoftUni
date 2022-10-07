using System;
using System.Data;

namespace Operations
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
    }

    public class StartUp
    {
        static void Main()
        {
            MathOperations math = new MathOperations();
            Console.WriteLine(math.Add(2, 3));
            Console.WriteLine(math.Add(2.2, 3.3, 5.5));
            Console.WriteLine(math.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
