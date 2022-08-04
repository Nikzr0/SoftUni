using System;
using System.Linq;

namespace Ex01.DiagonalDifference
{
    public class Program
    {
        public static void Main()
        {
            int sizeOfSquereMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfSquereMatrix, sizeOfSquereMatrix];

            for (int rows = 0; rows < sizeOfSquereMatrix; rows++)
            {
                int[] inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int colons = 0; colons < sizeOfSquereMatrix; colons++)
                {
                    matrix[rows, colons] = inputArray[colons];
                }
            }

            int sumOfRight = 0;
            int sumOfLeft = 0;

            for (int i = 0; i < sizeOfSquereMatrix; i++)
            {
                for (int j = 0; j < sizeOfSquereMatrix; j++)
                {
                    if (i == j)
                    {
                        sumOfRight += matrix[i, j];
                    }

                    if (i + j == sizeOfSquereMatrix - 1)
                    {
                        sumOfLeft += matrix[i, j];
                    }
                }
            }

            if (sumOfRight >= sumOfLeft)
            {
                Console.WriteLine(sumOfRight - sumOfLeft);
            }
            else
            {
                Console.WriteLine(sumOfLeft - sumOfRight);
            }
        }
    }
}