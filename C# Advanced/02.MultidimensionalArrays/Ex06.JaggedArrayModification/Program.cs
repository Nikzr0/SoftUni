using System;
using System.Linq;

namespace Ex06.JaggedArrayModification
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] inputsArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                matrix[i] = new int[n];
                matrix[i] = inputsArray;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] command = input.Split(" ");

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                switch (command[0])
                {
                    case "Add":
                        if (row >= 0 && row < n && col >= 0 && col < n)
                        {
                            matrix[row][col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }

                        break;

                    case "Subtract":
                        if (row >= 0 && row < n && col >= 0 && col < n)
                        {
                            matrix[row][col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }

                        break;
                }
            }

            for (int rows = 0; rows < n; rows++)
            {
                for (int colons = 0; colons < n; colons++)
                {
                    Console.Write($"{matrix[rows][colons]} ");
                }
                Console.WriteLine();
            }
        }
    }
}