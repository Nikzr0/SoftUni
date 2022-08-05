using System;

namespace Ex09._Miner
{
    public class Program
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ");

            string[,] field = new string[fieldSize, fieldSize];

            for (int row = 0; row < fieldSize; row++)
            {
                string input = Console.ReadLine();
                string fieldInput = "";

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].ToString() != " ")
                    {
                        fieldInput += input[i];
                    }
                }
                int a = fieldInput.Length;
                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = fieldInput[col].ToString();
                }
            }

            int coalNumber = 0;
            int coalFound = 0;
            int[] currPosition = new int[2];
            int[] lastCoalFound = new int[2];
            int[] lastPosition = new int[2];

            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    if (field[row, col] == "s")
                    {
                        currPosition[0] = row;
                        currPosition[1] = col;
                    }

                    if (field[row, col] == "c")
                    {
                        coalNumber++;
                    }
                }
            }

            int currRowPosition = currPosition[0];
            int currColPosition = currPosition[1];

            for (int i = 0; i < commands.Length; i++)
            {
                if (i == commands.Length - 1)
                {
                    lastPosition[0] = currRowPosition;
                    lastPosition[1] = currColPosition;
                }

                if (coalNumber > 0)
                {
                    switch (commands[i])
                    {
                        case "up":
                            if (currRowPosition - 1 >= 0)
                            {
                                currRowPosition -= 1;
                            }

                            if (field[currRowPosition, currColPosition] == "e")
                            {
                                Console.WriteLine($"Game over! ({currRowPosition}, {currColPosition})");
                                System.Environment.Exit(1);
                            }

                            if (field[currRowPosition, currColPosition] == "c")
                            {
                                if (coalNumber == 1)
                                {
                                    Console.WriteLine($"You collected all coals! ({currRowPosition}, {currColPosition})");
                                    System.Environment.Exit(1);
                                }
                                else
                                {
                                    field[currRowPosition, currColPosition] = "*";
                                    coalNumber--;
                                    coalFound++;
                                }
                            }

                            break;

                        case "down":
                            if (currRowPosition + 1 < fieldSize)
                            {
                                currRowPosition += 1;
                            }

                            if (field[currRowPosition, currColPosition] == "e")
                            {
                                Console.WriteLine($"Game over! ({currRowPosition}, {currColPosition})");
                                System.Environment.Exit(1);
                            }

                            if (field[currRowPosition, currColPosition] == "c")
                            {
                                if (coalNumber == 1)
                                {
                                    Console.WriteLine($"You collected all coals! ({currRowPosition}, {currColPosition})");
                                    System.Environment.Exit(1);
                                }
                                else
                                {
                                    field[currRowPosition, currColPosition] = "*";
                                    coalNumber--;
                                    coalFound++;
                                }
                            }

                            break;

                        case "left":
                            if (currColPosition - 1 >= 0)
                            {
                                currColPosition -= 1;
                            }

                            if (field[currRowPosition, currColPosition] == "e")
                            {
                                Console.WriteLine($"Game over! ({currRowPosition}, {currColPosition})");
                                System.Environment.Exit(1);
                            }

                            if (field[currRowPosition, currColPosition] == "c")
                            {
                                if (coalNumber == 1)
                                {
                                    Console.WriteLine($"You collected all coals! ({currRowPosition}, {currColPosition})");
                                    System.Environment.Exit(1);
                                }
                                else
                                {
                                    field[currRowPosition, currColPosition] = "*";
                                    coalNumber--;
                                    coalFound++;
                                }
                            }
                            break;

                        case "right":
                            if (currColPosition + 1 < fieldSize)
                            {
                                currColPosition += 1;
                            }

                            if (field[currRowPosition, currColPosition] == "e")
                            {
                                Console.WriteLine($"Game over! ({currRowPosition}, {currColPosition})");
                                System.Environment.Exit(1);
                            }

                            if (field[currRowPosition, currColPosition] == "c")
                            {
                                if (coalNumber == 1)
                                {
                                    Console.WriteLine($"You collected all coals! ({currRowPosition}, {currColPosition})");
                                    System.Environment.Exit(1);
                                }
                                else
                                {
                                    field[currRowPosition, currColPosition] = "*";
                                    coalNumber--;
                                    coalFound++;
                                }
                            }
                            break;
                    }
                }
            }

            if (coalNumber > 0)
            {
                Console.WriteLine($"{coalNumber} coals left. ({currRowPosition}, {currColPosition})");
            }
        }
    }
}