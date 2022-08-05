using System;
using System.Linq;

namespace Ex06.JaggedArrayManipulator
{
    public  class Program
    {
        public static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[numberOfRows][];


            for (int row = 0; row < numberOfRows; row++)
            {
                int[] intArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                matrix[row] = intArray;
            }


            for (int i = 0; i < numberOfRows - 1; i++)
            {
                if (matrix[i].Length == matrix[i+1].Length)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] = matrix[i][j] * 2;
                        matrix[i + 1][j] = matrix[i + 1][j] * 2;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] = matrix[i][j] / 2;
                    }

                    for (int x = 0; x < matrix[i + 1].Length; x++)
                    {
                        matrix[i + 1][x] = matrix[i + 1][x] / 2;
                    }
                }
            }

            while (true)
            {
                string inputString = Console.ReadLine();

                if (inputString == "End")
                {
                    break;
                }

                string[] command = inputString.Split(" ");

                switch (command[0])
                {
                    case "Add":
                  
                        int rowIndex = int.Parse(command[1]);
                        int colIndex = int.Parse(command[2]);
                        int value = int.Parse(command[3]);

                        if (rowIndex >= 0 && rowIndex < numberOfRows && colIndex>= 0 && colIndex < matrix[rowIndex].Length)
                        {
                            matrix[rowIndex][colIndex] += value;
                        }

                        break;

                    case "Subtract":
                        int rowIndexToRemove = int.Parse(command[1]);
                        int colIndexToRemove = int.Parse(command[2]);
                        int valueToRemove = int.Parse(command[3]);

                        if (rowIndexToRemove >= 0 && rowIndexToRemove < numberOfRows && colIndexToRemove >= 0 && colIndexToRemove < matrix[rowIndexToRemove].Length)
                        {
                            matrix[rowIndexToRemove][colIndexToRemove] -= valueToRemove;
                        }
                        break;
                }
            }

            Console.WriteLine();
            for (int r = 0; r < numberOfRows; r++)
            {
                for (int c = 0; c < matrix[r].Length; c++)
                {
                    Console.Write($"{matrix[r][c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}