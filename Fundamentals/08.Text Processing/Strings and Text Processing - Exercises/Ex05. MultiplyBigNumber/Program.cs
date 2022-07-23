using System;
using System.Numerics;

namespace Ex05._MultiplyBigNumber
{
    class Program
    {
        static void Main()
        {
            BigInteger n = new BigInteger();
            BigInteger bigNum = BigInteger.Parse(Console.ReadLine());
            int smallNum = int.Parse(Console.ReadLine());

            BigInteger finalNum = bigNum * smallNum;

            Console.WriteLine(finalNum);
        }
    }
}
