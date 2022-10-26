using System;
using System.Threading;

namespace Ex05.ConnectedAreasInMatrix
{
    public class Program
    {
        /*
         Not 100%
         It doesn't work when it starts with a star
        */
        private static int ro;
        private static int startIndex;
        public static int areaNum;

        private static int sum;
        private static int[] starsPositions;
        private static int[] yCordinates;
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rows, cols];
            starsPositions = new int[rows];
            yCordinates = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                starsPositions[i] = 0;
                yCordinates[i] = 0;
            }
            areaNum = 0;

            for (int r = 0; r < rows; r++)
            {
                string line = Console.ReadLine();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = line[c];
                }
            }
            Console.WriteLine($"Total areas found: {GetAreas(matrix)}");
            for (int i = 0; i < GetAreas(matrix); i++)
            {
                ro = 0;

                GetAreaSize(matrix, starsPositions[i]);
                Console.WriteLine(ReturnArea(areaNum, yCordinates[i]));
                for (int v = 0; v < yCordinates.Length; v++)
                {
                    yCordinates[v] = starsPositions[v];
                }

                sum = 0;
            }
        }
        private static void GetAreaSize(char[,] matrix, int startIndex)
        {
            if (startIndex == matrix.GetLength(1))
            {
                ro++;

                if (ro == matrix.GetLength(0))
                {
                    areaNum++;
                    ReturnArea(areaNum, startIndex);
                    return;
                }

                startIndex = starsPositions[ro];
            }

            if (matrix[ro, startIndex] == '*')
            {
                starsPositions[ro] = startIndex + 1;

                ro++;
                if (ro < starsPositions.Length)
                {
                    startIndex = starsPositions[ro];
                }

                if (ro == matrix.GetLength(0))
                {
                    areaNum++;
                    ReturnArea(areaNum, startIndex);
                    return;
                }

                startIndex--;
                sum--;
            }

            startIndex++;
            sum++;
            GetAreaSize(matrix, startIndex);
        }

        private static string ReturnArea(int areaNum, int startIndex)
        {
            return $"Area #{areaNum} at (0, {startIndex}), size: {sum}";
        }

        private static int GetAreas(char[,] matrix)
        {
            int areas = 1;
            string firstLine = "";

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                firstLine = firstLine + matrix[0, i];
            }

            for (int i = 0; i < firstLine.Length; i++)
            {
                if (firstLine[i] == '*')
                {
                    areas++;
                }
            }

            return areas;
        }
    }
}