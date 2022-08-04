using System;

namespace Ex07.PascalTriangle
{
    public class Program
    {
        public static void Main()
        {
            int linesNumber = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[linesNumber][];

            for (int lines = 0; lines < linesNumber; lines++)
            {
                pascalTriangle[lines] = new long[lines + 1];

                if (lines == 0)
                {
                    pascalTriangle[lines] = new long[] { 1 };
                }
                else if (lines == 1)
                {
                    pascalTriangle[lines] = new long[] { 1, 1 };
                }
                else if (lines > 1)
                {
                    for (int i = 0; i < lines + 1; i++)
                    {
                        if (i == 0)
                        {
                            pascalTriangle[lines][i] = 1;
                        }
                        else if (i == lines)
                        {
                            pascalTriangle[lines][i] = 1;
                        }
                        else
                        {
                            pascalTriangle[lines][i] = pascalTriangle[lines - 1][i - 1] + pascalTriangle[lines - 1][i];
                        }

                    }
                }
            }

            for (int rows = 0; rows < linesNumber; rows++)
            {
                for (int colons = 0; colons < pascalTriangle[rows].Length; colons++)
                {
                    Console.Write($"{pascalTriangle[rows][colons]} ");
                }
                Console.WriteLine();
            }
        }
    }
}