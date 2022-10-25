using System;

namespace L07.NChooseKCount
{
    public class Program
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            Console.WriteLine(GetCount(row, col));
        }

        private static int GetCount(int row, int col)
        {
            if (row <= 1|| col == 0 || col == row)
            {
                return 1;
            }

            return GetCount(row - 1, col - 1) + GetCount(row - 1, col);
        }
    }
}