using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TheBattleOfTheFiveArmies
{
    public class Program
    {
        static void Main()
        {
            int armor = int.Parse(Console.ReadLine());

            int[] armyPosition = new int[2];
            int row = armyPosition[0];
            int col = armyPosition[1];

            int[] middle = new int[2];
            int middleRow = middle[0];
            int middleCol = middle[1];


            int[] grave = new int[2];

            int mapRows = int.Parse(Console.ReadLine());
            if (mapRows < 5 || mapRows > 20)
            {
                throw new ArgumentException("Incorect Number Of Rows");
            }
            string[,] map = new string[mapRows, mapRows];
            for (int i = 0; i < mapRows; i++)
            {
                string rows = Console.ReadLine();
                char[] charArr = rows.ToCharArray();
                for (int j = 0; j < mapRows; j++)
                {
                    map[i, j] = charArr[j].ToString();

                    if (charArr[j] == 'A')
                    {
                        row = i;
                        col = j;
                        map[i, j] = "-";
                    }

                    if (charArr[j] == 'M')
                    {
                        middleRow = i;
                        middleCol = j;
                    }
                }
            }

            bool positionCheck = true;
            bool aliveCheck = true;

            while (positionCheck && aliveCheck)
            {
                string[] command = Console.ReadLine().Split(" ");
                armor--;

                switch (command[0])
                {
                    case "up":                        
                        if (row - 1 > -1)
                        {
                            row--;
                        }
                        
                        if (row == middleRow && col == middleCol)
                        {
                            positionCheck = false;
                        }
                        break;

                    case "down":
                        if (row + 1 < mapRows)
                        {
                            row++;
                        }

                        if (row == middleRow && col == middleCol)
                        {
                            positionCheck = false;
                        }

                        break;

                    case "left":
                        if (col - 1 < -1)
                        {
                            col--;
                        }

                        if (row == middleRow && col == middleCol)
                        {
                            positionCheck = false;
                        }

                        break;

                    case "right":
                        if (col + 1 < mapRows)
                        {
                            col++;
                        }

                        if (row == middleRow && col == middleCol)
                        {
                            positionCheck = false;
                        }

                        break;
                }

                if (int.Parse(command[1]) > -1 && int.Parse(command[1]) < mapRows && int.Parse(command[2]) > -1 && int.Parse(command[2]) < mapRows)
                {
                    map[int.Parse(command[1]), int.Parse(command[2])] = "O";
                }

                if (map[row, col] == "O")
                {
                    armor -= 2;

                    if (armor < 1)
                    {
                        map[row, col] = "X";
                        grave[0] = row;
                        grave[1] = col;

                        aliveCheck = false;
                    }
                    else
                    {
                        map[row, col] = "-";
                    }
                }      
            }
            Console.WriteLine();
            if (row == middleRow && col == middleCol)
            {
                if (armor > 0)
                {
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                }

                map[row, col] = "-";
            }

            if (!aliveCheck || armor < 1)
            {
                Console.WriteLine($"The army was defeated at {grave[0]};{grave[1]}.");
            }

            for (int i = 0; i < mapRows; i++)
            {
                for (int j = 0; j < mapRows; j++)
                {
                    Console.Write(map[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}