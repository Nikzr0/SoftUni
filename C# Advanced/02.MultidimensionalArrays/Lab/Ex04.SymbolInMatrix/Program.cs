using System;

namespace Ex04.SymbolInMatrix
{
    public class Program
    {
        public static void Main()
        {
            int inputsNumber = int.Parse(Console.ReadLine());

            string[,] matrix = new string[inputsNumber, inputsNumber];


            for (int rows = 0; rows < inputsNumber; rows++)
            {
                char[] charArray = Console.ReadLine().ToCharArray();
                for (int colons = 0; colons < inputsNumber; colons++)
                {
                    matrix[rows, colons] = charArray[colons].ToString();
                }
            }

            string charToSearch = Console.ReadLine();

            bool isNotThereSuchSymbole = true;
            for (int rows = 0; rows < inputsNumber; rows++)
            {
                for (int colons = 0; colons < inputsNumber; colons++)
                {
                    if (matrix[rows, colons] == charToSearch)
                    {
                        Console.WriteLine($"({rows}, {colons})");
                        System.Environment.Exit(1);
                    }
                }
            }

            if (isNotThereSuchSymbole)
            {
                Console.WriteLine($"{charToSearch} does not occur in the matrix");
            }
        }
    }
}