using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ex03.MoveDownOrRight
{
    public class Program
    {
        private static int path;

        static void Main()
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[,] matrix = new int[r, c];
            int[,] result = new int[r, c];

            List<string> path = new List<string>();

            //Dictionary<int, int> path = new Dictionary<int, int>();

            for (int row = 0; row < r; row++)
            {
                int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            CalculateRessult(matrix, result);
            GetPath(result, path);

            Console.WriteLine(string.Join(" ", path));
        }

        private static void GetPath(int[,] result, List<string>path)
        {
            path.Add($"[{0}, {0}]");
            int r = 0;
            int c = 0;

            for (int i = 0; i < result.GetLength(0) + result.GetLength(1) - 1; i++)
            {
                if (r + 1 < result.GetLength(0) && c + 1 < result.GetLength(1))
                {
                    if (result[r + 1, c] > result[r, c + 1])
                    {
                        path.Add($"[{r + 1}, {c}]");
                        r++;
                    }
                    else
                    {
                        path.Add($"[{r}, {c + 1}]");
                        c++;
                    }
                }
                else if(r + 1 < result.GetLength(0))
                {
                    path.Add($"[{r + 1}, {c}]");
                    r++;
                }
                else if (c + 1 < result.GetLength(1))
                {
                    path.Add($"[{r}, {c + 1}]");
                    c++;
                }              
            }
        }

        public static void CalculateRessult(int[,] matrix, int[,] result)
        {
            result[0, 0] = matrix[0, 0];

            for (int c = 1; c < result.GetLength(0) - 1; c++)
            {
                result[0, c] = matrix[0, c] + result[0, c - 1];
            }

            for (int c = 1; c < result.GetLength(1); c++)
            {
                result[c, 0] = matrix[c, 0] + result[c - 1, 0];
            }

            for (int r = 1; r < result.GetLength(0); r++)
            {
                for (int c = 1; c < result.GetLength(1); c++)
                {
                    if (result[r - 1, c] > result[r, c - 1])
                    {
                        result[r, c] = matrix[r, c] + result[r - 1, c];
                    }
                    else
                    {
                        result[r, c] = matrix[r, c] + result[r, c - 1];
                    }
                }
            }
        }
    }
}