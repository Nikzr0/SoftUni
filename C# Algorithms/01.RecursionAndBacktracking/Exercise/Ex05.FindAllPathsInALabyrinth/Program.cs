using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05.FindAllPathsInALabyrinth
{
    public class Program
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            var matrix = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                char[] arr = Console.ReadLine().ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            var directions = new List<char>();
            FindAllPaths(matrix, 0, 0, directions, '\0');
        }

        private static void FindAllPaths(char[,] matrix, int row, int col, List<char> directions, char direction)
        {
            if (IsOutside(matrix, row, col) || IsAWall(matrix, row, col) || IsVisited(matrix, row, col))
            {
                return;
            }
            directions.Add(direction);
            if (IsSolution(matrix, row, col))
            {
                Console.WriteLine(String.Join("", directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }
            
            matrix[row, col] = 'x';

            FindAllPaths(matrix, row - 1, col, directions, 'U');
            FindAllPaths(matrix, row + 1, col, directions, 'D');
            FindAllPaths(matrix, row, col - 1, directions, 'L');
            FindAllPaths(matrix, row, col + 1, directions, 'R');

            directions.RemoveAt(directions.Count - 1);
            matrix[row, col] = '-';
        }
        private static bool IsSolution(char[,] matrix, int row, int col)
        {
            if (matrix[row, col] == 'e')
            {
                return true;
            }

            return false;
        }
        private static bool IsVisited(char[,] matrix, int row, int col)
        {
            if (matrix[row, col] == 'x')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool IsOutside(char[,] matrix, int row, int col)
        {
            if (row < 0 || row > matrix.GetLength(0) - 1 || col < 0 || col > matrix.GetLength(1) - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool IsAWall(char[,] matrix, int row, int col)
        {
            return matrix[row, col] == '*';
        }
    }
}