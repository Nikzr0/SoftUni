using System;

namespace Sea_Chess
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first player name ...");
            string firstPlaerName = Console.ReadLine();
            Console.WriteLine("Enter second player name ...");
            string secondPlaerName = Console.ReadLine();
            if (firstPlaerName != secondPlaerName)
            {
                Console.WriteLine();
                Console.WriteLine($"{firstPlaerName} is the first player and use \"X\" ");
                Console.WriteLine($"{secondPlaerName} is the second player and use \"O\" ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Player cannot have the same name. Use digits after the name instead!");
                System.Environment.Exit(1);
            }

            //  CAN BE IMPROVED TO GENERATE ANY SIZE OF CHESS BOARD

            //Console.WriteLine("Enter the size of the chess board:");
            //Console.WriteLine("The normal sea chess board is 3x3");
            int boardSize = 3; //int.Parse(Console.ReadLine());

            string[,] chessBoard = new string[boardSize + 1, boardSize + 1];


            for (int i = 0; i < boardSize + 1; i++)
            {
                for (int j = 0; j < boardSize + 1; j++)
                {
                    chessBoard[i, j] = "~";
                }
            }

            chessBoard[0, 0] = ".";
            chessBoard[0, 1] = "A";
            chessBoard[0, 2] = "B";
            chessBoard[0, 3] = "C";

            chessBoard[1, 0] = "1";
            chessBoard[2, 0] = "2";
            chessBoard[3, 0] = "3";

            for (int i = 0; i < boardSize + 1; i++)
            {
                for (int j = 0; j < boardSize + 1; j++)
                {
                    Console.Write(chessBoard[i, j] + " ");
                }
                Console.WriteLine();
            }

            bool error = true;
            bool oneTimeDescription = true;
            int counter = 0;
            bool skip = true;
            while (counter < boardSize * boardSize)
            {
                Console.WriteLine();

                if (oneTimeDescription)
                {
                    Console.WriteLine("Digits show the row and Letters show the Column.");
                    Console.WriteLine("Don't use space between them and always start with letter");
                    oneTimeDescription = false;
                }
                Console.WriteLine("Enter Position:");

                counter++;
                string stringInput = Console.ReadLine();

                if (stringInput.Length > 2)
                {
                    Console.WriteLine("Invalid Cordinats! Try Again");
                    System.Environment.Exit(1);
                }

                string[] cordinats = new string[2];
                for (int i = 0; i < stringInput.Length; i++)
                {
                    cordinats[i] = stringInput[i].ToString();
                }

                string rowPositionString = cordinats[0];
                int col = 0;

                if (rowPositionString == "A" || rowPositionString == "a")
                {
                    col = 1;
                }
                else if (rowPositionString == "B" || rowPositionString == "b")
                {
                    col = 2;
                }
                else if (rowPositionString == "C" || rowPositionString == "c")
                {
                    col = 3;
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid Number, Please Try Again!");
                    System.Environment.Exit(1);
                }

                if (col == 0)
                {
                    System.Environment.Exit(1);
                }

                int row = 0;

                if (cordinats[1] == "1" || cordinats[1] == "2" || cordinats[1] == "3")
                {
                    row = int.Parse(cordinats[1]);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The second cordinat is incorect!");
                    Console.WriteLine("Try Again!");
                    error = false;
                    counter--;
                }

                if (counter % 2 == 1)
                {
                    if (error)
                    {
                        if (chessBoard[row, col] == "~")
                        {
                            chessBoard[row, col] = "X";
                        }
                        else if (chessBoard[row, col] == "X" || chessBoard[row, col] == "O")
                        {
                            Console.WriteLine("Invalid Line. It is already used. Choose again");
                            counter--;
                            skip = false;
                        }
                    }
                }
                else if (counter % 2 == 0)
                {
                    if (chessBoard[row, col] == "~")
                    {
                        chessBoard[row, col] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Invalid Line. It is already used. Choose again");
                        counter--;
                        skip = false;
                    }
                }

                if (skip)
                {
                    for (int i = 0; i < boardSize + 1; i++)
                    {
                        for (int j = 0; j < boardSize + 1; j++)
                        {
                            Console.Write(chessBoard[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }

                // Тerrible, but works :3
                if (chessBoard[1, 1] == chessBoard[1, 1 + 1] && chessBoard[1, 1 + 1] == chessBoard[1, 1 + 2] && chessBoard[1, 1] != "~")
                {
                    if (chessBoard[1, 1] == "X")
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {firstPlaerName} - X");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {secondPlaerName} - O");
                        System.Environment.Exit(1);
                    }
                }
                else if (chessBoard[2, 1] == chessBoard[2, 1 + 1] && chessBoard[2, 1 + 1] == chessBoard[2, 1 + 2] && chessBoard[2, 1] != "~")
                {
                    if (chessBoard[2, 1] == "X")
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {firstPlaerName} - X");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {secondPlaerName} - O");
                        System.Environment.Exit(1);
                    }
                }
                else if (chessBoard[3, 1] == chessBoard[3, 1 + 1] && chessBoard[3, 1 + 1] == chessBoard[3, 1 + 2] && chessBoard[3, 1] != "~")
                {
                    if (chessBoard[3, 1] == "X")
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {firstPlaerName} - X");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {secondPlaerName} - O");
                        System.Environment.Exit(1);
                    }
                }
                else if (chessBoard[1, 1] == chessBoard[1 + 1, 1] && chessBoard[1 + 1, 1] == chessBoard[1 + 2, 1] && chessBoard[1, 1] != "~")
                {
                    if (chessBoard[1, 1] == "X")
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {firstPlaerName} - X");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {secondPlaerName} - O");
                        System.Environment.Exit(1);
                    }
                }
                else if (chessBoard[1, 2] == chessBoard[1 + 1, 2] && chessBoard[1 + 1, 2] == chessBoard[1 + 2, 2] && chessBoard[1, 2] != "~")
                {
                    if (chessBoard[1, 2] == "X")
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {firstPlaerName} - X");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {secondPlaerName} - O");
                        System.Environment.Exit(1);
                    }
                }
                else if (chessBoard[1, 3] == chessBoard[1 + 1, 3] && chessBoard[1 + 1, 3] == chessBoard[1 + 2, 3] && chessBoard[1, 3] != "~")
                {
                    if (chessBoard[1, 3] == "X")
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {firstPlaerName} - X");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {secondPlaerName} - O");
                        System.Environment.Exit(1);
                    }
                }
                else if (chessBoard[1, 1] == chessBoard[2, 2] && chessBoard[2, 2] == chessBoard[3, 3] && chessBoard[1, 1] != "~")
                {
                    if (chessBoard[1, 1] == "X")
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {firstPlaerName} - X");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {secondPlaerName} - O");
                        System.Environment.Exit(1);
                    }
                }
                else if (chessBoard[1, 3] == chessBoard[2, 2] && chessBoard[2, 2] == chessBoard[3, 1] && chessBoard[1, 3] != "~")
                {
                    if (chessBoard[1, 3] == "X")
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {firstPlaerName} - X");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("The game is over!");
                        Console.WriteLine($"The winner is player {secondPlaerName} - O");
                        System.Environment.Exit(1);
                    }
                }

                skip = true;
                error = true;
            }

            Console.WriteLine("The game is over!");
            Console.WriteLine("It's a drow!");
        }
    }
}