using System;
using System.Collections.Generic;

namespace Ex01.BinomialCoefficients
{
    public class Program
    {
        private static Dictionary<string, long> div;

        static void Main()
        {
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            div = new Dictionary<string, long>();

            Console.WriteLine(GetBinom(r, c));
        }

        private static long GetBinom(int row, int col)
        {
            var id = $"{row} {col}";

            if (div.ContainsKey(id))
            {
                return div[id];
            }

            if (col == 0 || col == row)
            {
                return 1;
            }

            var result = GetBinom(row - 1, col) + GetBinom(row - 1, col - 1);
            div[id] = result;
            return result;
        }
    }
}