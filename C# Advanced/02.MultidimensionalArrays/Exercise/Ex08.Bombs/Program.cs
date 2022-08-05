using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex08.Bombs
{
    public class Program
    {
        public static void Main() // NOT FINISHED AND NOT WORKING --> 0%
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];
            List<int> alreadyBoomed = new List<int>(); // BAD IDEA
            for (int row = 0; row < matrixSize; row++)
            {
                int[] inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = inputArray[col];
                }
            }

            string inputString = Console.ReadLine();
            string bombCordinats = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i].ToString() != " " && inputString[i].ToString() != ",")
                {
                    bombCordinats += inputString[i].ToString();
                }
            }

            int[] bombs = new int[bombCordinats.Length];

            for (int i = 0; i < bombCordinats.Length; i++)
            {
                bombs[i] = int.Parse(bombCordinats[i].ToString());
            }

            int x = 0;
            for (int i = 0; i < bombs.Length / 2; i++)
            {
                int rowOfBomb = bombs[x];
                int colOfBomb = bombs[x + 1];

                int bombStrenth = matrix[rowOfBomb, colOfBomb];


                matrix[rowOfBomb, colOfBomb] = 0;

                if (x + 1 < bombs.Length)
                {
                    if (colOfBomb - 1 >= 0)
                    {
                        for (int y = 0; y < alreadyBoomed.Count; y++)
                        {
                            if (matrix[rowOfBomb, colOfBomb - 1] != matrix[alreadyBoomed[y], alreadyBoomed[y + 1]])
                            {
                                matrix[rowOfBomb, colOfBomb - 1] -= bombStrenth;
                                alreadyBoomed.Add(rowOfBomb);
                                alreadyBoomed.Add(colOfBomb - 1);
                            }
                            y += 2;
                        }
                    }

                    if (colOfBomb + 1 <= matrixSize)
                    {
                        for (int y = 0; y < alreadyBoomed.Count; y++)
                        {
                            if (matrix[rowOfBomb, colOfBomb - 1] != matrix[alreadyBoomed[y], alreadyBoomed[y + 1]])
                            {
                                matrix[rowOfBomb, colOfBomb + 1] -= bombStrenth;
                                alreadyBoomed.Add(rowOfBomb);
                                alreadyBoomed.Add(colOfBomb + 1);
                            }
                            y += 2;
                        }
                    }

                    if (rowOfBomb - 1 >= 0)
                    {
                        for (int y = 0; y < alreadyBoomed.Count; y++)
                        {
                            if (matrix[rowOfBomb, colOfBomb - 1] != matrix[alreadyBoomed[y], alreadyBoomed[y + 1]])
                            {
                                matrix[rowOfBomb - 1, colOfBomb] -= bombStrenth;
                                alreadyBoomed.Add(rowOfBomb - 1);
                                alreadyBoomed.Add(colOfBomb);
                            }
                            y += 2;
                        }
                    }

                    if (rowOfBomb + 1 >= 0)
                    {
                        for (int y = 0; y < alreadyBoomed.Count; y++)
                        {
                            if (matrix[rowOfBomb, colOfBomb - 1] != matrix[alreadyBoomed[y], alreadyBoomed[y + 1]])
                            {
                                matrix[rowOfBomb + 1, colOfBomb] -= bombStrenth;
                                alreadyBoomed.Add(rowOfBomb + 1);
                                alreadyBoomed.Add(colOfBomb);
                            }
                            y += 2;
                        }
                    }

                    if (rowOfBomb + 1 <= matrixSize && colOfBomb + 1 <= matrixSize)
                    {
                        for (int y = 0; y < alreadyBoomed.Count; y++)
                        {
                            if (matrix[rowOfBomb, colOfBomb - 1] != matrix[alreadyBoomed[y], alreadyBoomed[y + 1]])
                            {
                                matrix[rowOfBomb + 1, colOfBomb + 1] -= bombStrenth;
                                alreadyBoomed.Add(rowOfBomb + 1);
                                alreadyBoomed.Add(colOfBomb + 1);
                            }
                            y += 2;
                        }
                    }

                    if (rowOfBomb - 1 >= 0 && colOfBomb - 1 >= 0)
                    {
                        for (int y = 0; y < alreadyBoomed.Count; y++)
                        {
                            if (matrix[rowOfBomb, colOfBomb - 1] != matrix[alreadyBoomed[y], alreadyBoomed[y + 1]])
                            {
                                matrix[rowOfBomb - 1, colOfBomb - 1] -= bombStrenth;
                                alreadyBoomed.Add(rowOfBomb - 1);
                                alreadyBoomed.Add(colOfBomb - 1);
                            }
                            y += 2;
                        }
                    }

                    if (rowOfBomb - 1 >= 0 && colOfBomb + 1 <= matrixSize)
                    {
                        for (int y = 0; y < alreadyBoomed.Count; y++)
                        {
                            if (matrix[rowOfBomb, colOfBomb - 1] != matrix[alreadyBoomed[y], alreadyBoomed[y + 1]])
                            {
                                matrix[rowOfBomb - 1, colOfBomb + 1] -= bombStrenth;
                                alreadyBoomed.Add(rowOfBomb - 1);
                                alreadyBoomed.Add(colOfBomb + 1);
                            }
                            y += 2;
                        }
                    }

                    if (rowOfBomb + 1 <= matrixSize && colOfBomb - 1 >= 0)
                    {
                        for (int y = 0; y < alreadyBoomed.Count; y++)
                        {
                            if (matrix[rowOfBomb, colOfBomb - 1] != matrix[alreadyBoomed[y], alreadyBoomed[y + 1]])
                            {
                                matrix[rowOfBomb + 1, colOfBomb - 1] -= bombStrenth;
                                alreadyBoomed.Add(rowOfBomb + 1);
                                alreadyBoomed.Add(colOfBomb - 1);
                            }
                            y += 2;
                        }
                    }
                    x += 2;

                    Console.WriteLine("----------------------------------------------");
                    for (int row = 0; row < matrixSize; row++)
                    {
                        for (int col = 0; col < matrixSize; col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }
                        Console.WriteLine();
                    }

                }

            }

            Console.WriteLine();
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}