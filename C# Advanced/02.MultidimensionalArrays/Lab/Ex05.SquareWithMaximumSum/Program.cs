using System;
using System.Linq;

namespace Ex05.SquareWithMaximumSum
{
    public class Program
    {
        public static void Main()
        {
            int[] rowsAndColonsInMatrex = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int rowsNumber = rowsAndColonsInMatrex[0];
            int colonsNumber = rowsAndColonsInMatrex[1];

            int[,] matrex = new int[rowsNumber, colonsNumber];

            for (int rows = 0; rows < rowsNumber; rows++)
            {
                int[] inputArray = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int colons = 0; colons < colonsNumber; colons++)
                {
                    matrex[rows,colons] = inputArray[colons];
                }
            }

            int maxSum = 0;
            int rowIndex = 0;
            int colIndex = 0;

            for (int rows = 0; rows < rowsNumber - 1; rows++)
            {
                for (int colons = 0; colons < colonsNumber - 1; colons++)
                {
                    var sum =  matrex[rows,colons] + matrex[rows,colons + 1] + matrex[rows + 1,colons] + matrex[rows + 1, colons + 1];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        rowIndex = rows;
                        colIndex = colons;
                    }
                }
            }

            Console.WriteLine($"{matrex[rowIndex, colIndex]} { matrex[rowIndex, colIndex + 1]}");
            Console.WriteLine($"{matrex[rowIndex + 1, colIndex]} {matrex[rowIndex + 1, colIndex + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}