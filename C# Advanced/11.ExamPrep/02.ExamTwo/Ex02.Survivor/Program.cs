using System;

namespace Ex02.Survivor
{
    public class Program // 85% => (#Test 1 -> Incorect Answer)
    {
        static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            string[][] beach = new string[numberOfRows][];

            int myTokens = 0;
            int enemyTokens = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                string[] row = Console.ReadLine().Split(" ");
                beach[i] = row;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Gong")
                {
                    break;
                }

                string[] command = input.Split(" ");

                switch (command[0])
                {
                    case "Find":
                        int row = int.Parse(command[1]);
                        int col = int.Parse(command[2]);

                        if (row < numberOfRows && row >= 0 && col < beach[row].Length && col >= 0 && beach[row][col] == "T")
                        {
                            beach[row][col] = "-";
                            myTokens++;
                        }
                        break;

                    case "Opponent":
                        int enemyRow = int.Parse(command[1]);
                        int enemyCol = int.Parse(command[2]);
                        string enemyDirection = command[3];

                        switch (enemyDirection)
                        {
                            case "up":
                                for (int i = 0; i < 4; i++)
                                {
                                    if (enemyRow < numberOfRows && enemyRow >= 0 && enemyCol < beach[enemyRow].Length && enemyCol >= 0 && beach[enemyRow][enemyCol] == "T")
                                    {
                                        beach[enemyRow][enemyCol] = "-";
                                        enemyTokens++;
                                    }

                                    if (enemyRow - 1 >= 0)
                                    {
                                        enemyRow--;
                                    }                                    
                                }
                                break;

                            case "down":
                                for (int i = 0; i < 4; i++)
                                {
                                    if (enemyRow < numberOfRows && enemyRow >= 0 && enemyCol < beach[enemyRow].Length && enemyCol >= 0 && beach[enemyRow][enemyCol] == "T")
                                    {
                                        beach[enemyRow][enemyCol] = "-";
                                        enemyTokens++;

                                        if (enemyRow + 1 < numberOfRows)
                                        {
                                            enemyRow++;
                                        }                                        
                                    }
                                }
                                break;

                            case "left":
                                for (int i = 0; i < 4; i++)
                                {
                                    if (enemyRow < numberOfRows && enemyRow >= 0 && enemyCol < beach[enemyRow].Length && enemyCol >= 0 && beach[enemyRow][enemyCol] == "T")
                                    {
                                        beach[enemyRow][enemyCol] = "-";
                                        enemyTokens++;

                                        if (enemyCol - 1 >= 0)
                                        {
                                            enemyCol--;
                                        }                                        
                                    }
                                }
                                break;

                            case "right":
                                for (int i = 0; i < 4; i++)
                                {
                                    if (enemyRow < numberOfRows && enemyRow >= 0 && enemyCol < beach[enemyRow].Length && enemyCol >= 0 && beach[enemyRow][enemyCol] == "T")
                                    {
                                        beach[enemyRow][enemyCol] = "-";
                                        enemyTokens++;

                                        if (enemyCol + 1 < beach[enemyRow].Length)
                                        {
                                            enemyCol++;
                                        }
                                    }
                                }
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine();
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.WriteLine(string.Join(" ", beach[i]));
            }

            Console.WriteLine($"Collected tokens: {myTokens}");
            Console.WriteLine($"Opponent's tokens: {enemyTokens}");
        }
    }
}