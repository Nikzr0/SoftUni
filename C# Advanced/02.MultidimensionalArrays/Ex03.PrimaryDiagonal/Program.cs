using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.PrimaryDiagonal
{
    public class Program
    {
        static void Main()
        {
            int sizeOfSquereMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfSquereMatrix, sizeOfSquereMatrix];

            int sumOfDiagonal = 0;

            for (int rows = 0; rows < sizeOfSquereMatrix; rows++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
                for (int col = 0; col < sizeOfSquereMatrix; col++)
                {
                    matrix[rows, col] = input[col];

                    if (rows == col)
                    {
                        sumOfDiagonal += matrix[rows, col];
                    }
                }
            }

            Console.WriteLine(sumOfDiagonal);
        }
    }
}