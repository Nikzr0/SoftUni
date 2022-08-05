using System;

namespace Ex07.KnightGame
{
    public class Program
    {
        public static void Main()
        {
            int boardSize = int.Parse(Console.ReadLine());
            string[,] board = new string[boardSize, boardSize];
            //string[,] secondBoard = new string[boardSize, boardSize];

            int howManyToRemove = 0;

            //int howManyAreSelected = 0;
            //int counter = 0;

            for (int r = 0; r < boardSize; r++)
            {
                string emptyOrKnights = Console.ReadLine();
                for (int c = 0; c < boardSize; c++)
                {
                    board[r, c] = emptyOrKnights[c].ToString();
                    //secondBoard[r, c] = emptyOrKnights[c].ToString();
                }
            }

            for (int r = 0; r < boardSize; r++)
            {
                for (int c = 0; c < boardSize; c++)
                {
                    if (board[r, c] == "K") // && secondBoard[r, c] == "K" ( for second if)
                    {
                        if (true)
                        {
                            if (r + 1 < boardSize && c + 2 < boardSize && board[r + 1, c + 2] == "K")
                            {
                                board[r + 1, c + 2] = "0";
                                howManyToRemove++;
                            }

                            if (r + 1 < boardSize && c - 2 >= 0 && board[r + 1, c - 2] == "K")
                            {
                                board[r + 1, c - 2] = "0";
                                howManyToRemove++;
                            }

                            if (r - 1 >= 0 && c - 2 >= 0 && board[r - 1, c - 2] == "K")
                            {
                                board[r - 1, c - 2] = "0";
                                howManyToRemove++;
                            }

                            if (r - 1 >= 0 && c + 2 < boardSize && board[r - 1, c + 2] == "K")
                            {
                                board[r - 1, c + 2] = "0";
                                howManyToRemove++;
                            }




                            if (r - 2 >= 0 && c - 1 >= 0 && board[r - 2, c - 1] == "K")
                            {
                                board[r - 2, c - 1] = "0";
                                howManyToRemove++;
                            }

                            if (r - 2 >= 0 && c + 1 < boardSize && board[r - 2, c + 1] == "K")
                            {
                                board[r - 2, c + 1] = "0";
                                howManyToRemove++;
                            }

                            if (r + 2 < boardSize && c - 1 >= 0 && board[r + 2, c - 1] == "K")
                            {
                                board[r + 2, c - 1] = "0";
                                howManyToRemove++;
                            }

                            if (r + 2 < boardSize && c + 1 < boardSize && board[r + 2, c + 1] == "K")
                            {
                                board[r + 2, c + 1] = "0";
                                howManyToRemove++;
                            }

                        } // Not 100%

                        if (true)
                        {
                            //if (true)
                            //{

                            //    if (r + 1 < boardSize && c + 2 < boardSize && secondBoard[r + 1, c + 2] == "K")
                            //    {
                            //        howManyAreSelected++;
                            //    }

                            //    if (r + 1 < boardSize && c - 2 >= 0 && secondBoard[r + 1, c - 2] == "K")
                            //    {
                            //        howManyAreSelected++;
                            //    }

                            //    if (r - 1 >= 0 && c - 2 >= 0 && secondBoard[r - 1, c - 2] == "K")
                            //    {
                            //        howManyAreSelected++;
                            //    }

                            //    if (r - 1 >= 0 && c + 2 < boardSize && secondBoard[r - 1, c + 2] == "K")
                            //    {
                            //        howManyAreSelected++;
                            //    }

                            //    if (r - 2 >= 0 && c - 1 >= 0 && secondBoard[r - 2, c - 1] == "K")
                            //    {
                            //        howManyAreSelected++;
                            //    }

                            //    if (r - 2 >= 0 && c + 1 < boardSize && secondBoard[r - 2, c + 1] == "K")
                            //    {
                            //        howManyAreSelected++;
                            //    }

                            //    if (r + 2 < boardSize && c - 1 >= 0 && secondBoard[r + 2, c - 1] == "K")
                            //    {
                            //        howManyAreSelected++;
                            //    }

                            //    if (r + 2 < boardSize && c + 1 < boardSize && secondBoard[r + 2, c + 1] == "K")
                            //    {
                            //        howManyAreSelected++;
                            //    }


                            //    if (howManyAreSelected == 1)
                            //    {
                            //        if (r + 1 < boardSize && c + 2 < boardSize && board[r + 1, c + 2] == "K")
                            //        {
                            //            board[r + 1, c + 2] = "0";
                            //            howManyToRemove++;
                            //        }

                            //        if (r + 1 < boardSize && c - 2 >= 0 && board[r + 1, c - 2] == "K")
                            //        {
                            //            board[r + 1, c - 2] = "0";
                            //            howManyToRemove++;
                            //        }

                            //        if (r - 1 >= 0 && c - 2 >= 0 && board[r - 1, c - 2] == "K")
                            //        {
                            //            board[r - 1, c - 2] = "0";
                            //            howManyToRemove++;
                            //        }

                            //        if (r - 1 >= 0 && c + 2 < boardSize && board[r - 1, c + 2] == "K")
                            //        {
                            //            board[r - 1, c + 2] = "0";
                            //            howManyToRemove++;
                            //        }

                            //        if (r - 2 >= 0 && c - 1 >= 0 && board[r - 2, c - 1] == "K")
                            //        {
                            //            board[r - 2, c - 1] = "0";
                            //            howManyToRemove++;
                            //        }

                            //        if (r - 2 >= 0 && c + 1 < boardSize && board[r - 2, c + 1] == "K")
                            //        {
                            //            board[r - 2, c + 1] = "0";
                            //            howManyToRemove++;
                            //        }

                            //        if (r + 2 < boardSize && c - 1 >= 0 && board[r + 2, c - 1] == "K")
                            //        {
                            //            board[r + 2, c - 1] = "0";
                            //            howManyToRemove++;
                            //        }

                            //        if (r + 2 < boardSize && c + 1 < boardSize && board[r + 2, c + 1] == "K")
                            //        {
                            //            board[r + 2, c + 1] = "0";
                            //            howManyToRemove++;
                            //        }


                            //        howManyAreSelected = 0;
                            //    }
                            //    else if (howManyAreSelected > 1)
                            //    {
                            //        secondBoard[r, c] = "0";
                            //        counter++;
                            //        howManyAreSelected = 0;
                            //    }
                            //}

                        } // It doesn't work !?
                    }
                }
            }
            Console.WriteLine(howManyToRemove);
        }
    }
}