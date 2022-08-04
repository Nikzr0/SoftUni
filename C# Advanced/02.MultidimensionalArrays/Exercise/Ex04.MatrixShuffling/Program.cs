using System;
using System.Linq;

namespace Ex04.MatrixShuffling
{
    public class Program
    {
        public static void Main()
        {
            int[] rowsAndColumnNumber = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rowsNumber = rowsAndColumnNumber[0];
            int columnsNumber = rowsAndColumnNumber[1];

            string[,] matrix = new string[rowsNumber, columnsNumber];

            for (int rows = 0; rows < rowsNumber; rows++)
            {
                string[] inputArray = Console.ReadLine().Split(" ");
                for (int columns = 0; columns < columnsNumber; columns++)
                {
                    matrix[rows, columns] = inputArray[columns];
                }
            }

            while (true)
            {
                string inputString = Console.ReadLine();

                if (inputString == "END")
                {
                    break;
                }

                string[] command = inputString.Split(" ");

                switch (command[0])
                {
                    case "swap":
                        if (command.Length != 5)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            int row1 = int.Parse(command[1]);
                            int col1 = int.Parse(command[2]);
                            int row2 = int.Parse(command[3]);
                            int col2 = int.Parse(command[4]);


                            if (row1 < 0 || row2 < 0 || row1 >= rowsNumber || row2 >= rowsNumber)
                            {
                                Console.WriteLine("Invalid input!");
                                continue;
                            }
                            else if (col1 < 0 || col2 < 0 || col1 >= columnsNumber || col2 >= columnsNumber)
                            {
                                Console.WriteLine("Invalid input!");
                                continue;
                            }

                            string tempRow1 = matrix[row1, col1];

                            matrix[row1, col1] = matrix[row2, col2];
                            matrix[row2, col2] = tempRow1;

                            for (int rows = 0; rows < rowsNumber; rows++)
                            {
                                for (int column = 0; column < columnsNumber; column++)
                                {
                                    Console.Write($"{matrix[rows, column]} ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }
    }
}