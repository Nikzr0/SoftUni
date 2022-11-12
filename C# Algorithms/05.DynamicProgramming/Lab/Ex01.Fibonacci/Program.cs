using System;
using System.Collections.Generic;

namespace Ex01.Fibonacci
{
    public class Program
    {
        private static Dictionary<int, long> dic = new Dictionary<int, long>();
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            dic.Add(n, GetFibunachi(n));
            Console.WriteLine(GetFibunachi(n));
        }

        private static long GetFibunachi(int n)
        {
            if (dic.ContainsKey(n))
            {
                return dic[n];
            }
            if (n <= 2)
            {
                return 1;
            }

            return GetFibunachi(n - 1) + GetFibunachi(n - 2);
        }
    }
}