using System;
using System.Linq;

namespace Ex03.MaximalSum
{
    public class Program
    {
        public static void Main()
        {
            int[] rowsAndColons = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rowsNumber = rowsAndColons[0];
            int columnnsNumber = rowsAndColons[1];

            int[,] matrex = new int[rowsNumber, columnnsNumber];

            for (int rows = 0; rows < rowsNumber; rows++)
            {
                int[] inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int colons = 0; colons < columnnsNumber; colons++)
                {
                    matrex[rows, colons] = inputArray[colons];
                }
            }

            int sumOfSmallerMatrix = 0;
            int finalSum = 0;

            int[] firstIndex = new int[2];

            for (int rows = 0; rows < rowsNumber - 2; rows++)
            {
                for (int column = 0; column < columnnsNumber - 2; column++)
                {

                    for (int i = 0 + rows; i < 3 + rows; i++)
                    {
                        for (int j = 0 + column; j < 3 + column; j++)
                        {
                            sumOfSmallerMatrix += matrex[i, j];
                        }
                    }

                    if (sumOfSmallerMatrix == 0)
                    {
                        if (finalSum <= sumOfSmallerMatrix)
                        {
                            finalSum = sumOfSmallerMatrix;
                            firstIndex = new int[] { rows, column };
                        }
                    }
                    else
                    {
                        if (finalSum < sumOfSmallerMatrix)
                        {
                            finalSum = sumOfSmallerMatrix;
                            firstIndex = new int[] { rows, column };
                        }
                    }

                    sumOfSmallerMatrix = 0;
                }
            }

            Console.WriteLine($"Sum = {finalSum}");

            for (int rows = firstIndex[0]; rows < firstIndex[0] + 3; rows++)
            {
                for (int column = firstIndex[1]; column < firstIndex[1] + 3; column++)
                {
                    Console.Write($"{matrex[rows, column]} ");
                }
                Console.WriteLine();
            }

        }
    }
}