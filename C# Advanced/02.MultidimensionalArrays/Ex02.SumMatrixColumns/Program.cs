using System;
using System.Linq;

namespace Ex02.SumMatrixColumns
{
    public class Program
    {
        public static void Main()
        {
            int[] rowsAndColoms = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int row = rowsAndColoms[0];
            int colom = rowsAndColoms[1];

            int[,] matrix = new int[row, colom];
            int[] colsCount = new int[colom];

            for (int i = 0; i < colsCount.Length; i++)
            {
                colsCount[i] = 0;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[i, col] = input[col];
                    colsCount[col] += input[col];
                }
            }

            foreach (var item in colsCount)
            {
                Console.WriteLine(item);
            }
        }
    }
}