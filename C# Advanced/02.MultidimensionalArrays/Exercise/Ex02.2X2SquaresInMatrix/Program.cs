using System;
using System.Linq;

namespace Ex02._2X2SquaresInMatrix
{
    public class Program
    {
        public static void Main()
        {
            int[] rowsAndColons = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rowsNumber = rowsAndColons[0];
            int colonsNumber = rowsAndColons[1];

            string[,] matrex = new string[rowsNumber, colonsNumber];

            for (int rows = 0; rows < rowsNumber; rows++)
            {
                string[] inputArray = Console.ReadLine().Split(" ");
                for (int colons = 0; colons < colonsNumber; colons++)
                {
                    matrex[rows, colons] = inputArray[colons];
                }
            }

            int sumOfSquereMatrix = 0;

            for (int rows = 0; rows < rowsNumber - 1; rows++)
            {
                for (int colons = 0; colons < colonsNumber - 1; colons++)
                {
                    if (matrex[rows, colons] == matrex[rows, colons + 1] && matrex[rows, colons] == matrex[rows + 1, colons] && matrex[rows + 1, colons] == matrex[rows + 1, colons + 1])
                    {
                        sumOfSquereMatrix++;
                    }
                }
            }

            Console.WriteLine(sumOfSquereMatrix);
        }
    }
}