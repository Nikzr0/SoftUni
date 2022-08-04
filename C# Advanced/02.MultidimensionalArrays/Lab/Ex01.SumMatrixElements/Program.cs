using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01.SumMatrixElements
{
    public class Program
    {
        public static void Main()
        {
            int[] rowsAndColoms = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndColoms[0];
            int coloms = rowsAndColoms[1];

            int[,] matrix = new int[rows, coloms];
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] tempArray = new int[coloms];
                tempArray =  Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tempArray[j];
                    sum += tempArray[j];
                }
            }

            int sum2 = 0;
            foreach (var item in matrix)
            {
                sum2 += item;
            }
            Console.WriteLine(rows);
            Console.WriteLine(coloms);
            Console.WriteLine($"Teh resoult is {sum2}");
        }
    }
}