using System;
using System.Linq;

namespace Ex05.SnakeMoves
{
    public class Program
    {
        public static void Main() // NOT 100%
        {
            int[] rowsAndColumns = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = rowsAndColumns[0];
            int column = rowsAndColumns[1];
            string[,] snakeMatrix = new string[rows, column];

            string snake = Console.ReadLine();
            string reversedSnake = "";

            for (int i = snake.Length - 1; i >= 0; i--)
            {
                reversedSnake += snake[i].ToString();
            }

            int excess = snake.Length - column;

            for (int row = 0; row < rows; row++)
            {
                string tempSnake = reversedSnake;
                int excessCount = excess + row - 1;
                int counter = 0;
                for (int col = 0; col < column; col++)
                {
                    if (row == 0)
                    {
                        snakeMatrix[row, col] = snake[col].ToString();
                    }
                    else if (excessCount > 0)
                    {
                        snakeMatrix[row, col] = tempSnake[excessCount - 1].ToString();
                        counter++;
                        excessCount--;
                    }
                    else
                    {
                        snakeMatrix[row, col] = snake[col - counter].ToString();
                    }
                }

            }

            Console.WriteLine();
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < column; col++)
                    {
                        Console.Write($"{snakeMatrix[row, col]}");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int i = 0; i < column; i++)
                    {
                        Console.Write($"{snakeMatrix[row, column - (i + 1)]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}