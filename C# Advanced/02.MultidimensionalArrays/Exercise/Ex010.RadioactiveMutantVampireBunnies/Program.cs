using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex010.RadioactiveMutantVampireBunnies
{
    public class Program
    {
        public static void Main() // ARRAY FIELD DOES NOT WORK PROPERLY
        {
            int[] rowsAndColumns = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rowNumber = rowsAndColumns[0];
            int colNumber = rowsAndColumns[1];

            int numberOfBunnies = 0;

            int[] currPosition = new int[2];

            List<int> bunnyPosition = new List<int>();
            string[,] field = new string[rowNumber, colNumber];

            Regex regex = new Regex(@"([\.PB])");


            for (int row = 0; row < rowNumber; row++)
            {
                string input = Console.ReadLine();
                MatchCollection myMatch = regex.Matches(input);

                string validData = "";

                foreach (Match item in myMatch)
                {
                    validData += item.Groups[1];
                }

                if (validData.Length == colNumber)
                {
                    for (int col = 0; col < colNumber; col++)
                    {
                        field[row, col] = validData[col].ToString();

                        if (field[row, col] == "B")
                        {
                            numberOfBunnies++;
                            bunnyPosition.Add(row);
                            bunnyPosition.Add(col);
                        }

                        if (field[row, col] == "P")
                        {
                            currPosition[0] = row;
                            currPosition[1] = col;
                        }
                    }
                }
            }

            string commands = Console.ReadLine();
            int x = 2;
            int xx = 1;

            for (int col = 0; col < commands.Length; col++)
            {
                for (int i = 0; i < bunnyPosition.Count; i += 2)
                {

                    int bunnyRow = bunnyPosition[i];
                    int bunnyCol = bunnyPosition[i + 1];

                    for (int bunnyR = 0; bunnyR < 1 + x; bunnyR++)
                    {

                        for (int bunnyC = 0; bunnyC < 1 + x; bunnyC++)
                        {
                            if (bunnyRow - xx + bunnyR > -1 && bunnyRow + xx < rowNumber && bunnyCol - xx >= 0 && bunnyCol - xx + bunnyC < colNumber)
                            {
                                field[bunnyRow - xx + bunnyR, bunnyCol - xx + bunnyC] = "B";
                            }
                        }
                    }
                }

                switch (commands[col])
                {
                    case 'U':
                        if (currPosition[0] - 1 < 0)
                        {
                            for (int row = 0; row < rowNumber; row++)
                            {
                                for (int column = 0; column < colNumber; column++)
                                {
                                    Console.Write($"{field[row, col]} ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"won: {currPosition[0]} {currPosition[1]}");
                            System.Environment.Exit(1);
                        }
                        currPosition[0]--;
                        if (field[currPosition[0], currPosition[1]] == "B")
                        {
                            Console.WriteLine($"dead: {currPosition[0]} {currPosition[1]}");
                            System.Environment.Exit(1);
                        }
                        break;

                    case 'D':
                        if (currPosition[0] + 1 == rowNumber)
                        {
                            for (int row = 0; row < rowNumber; row++)
                            {
                                for (int column = 0; column < colNumber; column++)
                                {
                                    Console.Write($"{field[row, col]} ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"won: {currPosition[0]} {currPosition[1]}");
                            System.Environment.Exit(1);
                        }
                        currPosition[0]++;
                        if (field[currPosition[0], currPosition[1]] == "B")
                        {
                            Console.WriteLine($"dead: {currPosition[0]} {currPosition[1]}");
                            System.Environment.Exit(1);
                        }
                        break;

                    case 'L':
                        if (currPosition[1] - 1 < 0)
                        {
                            Console.WriteLine(xx);
                            for (int row = 0; row < rowNumber; row++)
                            {
                                for (int column = 0; column < colNumber; column++)
                                {
                                    Console.Write($"{field[row, col]} ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"won: {currPosition[0]} {currPosition[1]}");
                            System.Environment.Exit(1);
                        }
                        currPosition[1]--;
                        if (field[currPosition[0], currPosition[1]] == "B")
                        {
                            Console.WriteLine($"dead: {currPosition[0]} {currPosition[1]}");
                            System.Environment.Exit(1);
                        }
                        break;

                    case 'R':
                        if (currPosition[1] + 1 == colNumber)
                        {
                            for (int row = 0; row < rowNumber; row++)
                            {
                                for (int column = 0; column < colNumber; column++)
                                {
                                    Console.Write($"{field[row, col]} ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine($"won: {currPosition[0]} {currPosition[1]}");
                            System.Environment.Exit(1);
                        }
                        currPosition[1]++;
                        if (field[currPosition[0], currPosition[1]] == "B")
                        {
                            Console.WriteLine($"dead: {currPosition[0]} {currPosition[1]}");
                            System.Environment.Exit(1);
                        }
                        break;
                }
                x += 2;
                xx++;
            }
        }
    }
}