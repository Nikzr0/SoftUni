using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.SetCover
{
    public class Program
    {
        static List<int[]> Nums(List<int> lineOfNumbers, List<int[]> numbers)
        {
            
            List<int[]> output = new List<int[]>();

            while (lineOfNumbers.Count == 0 && numbers.Count == 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int counter = 0;
                    List<int> counts = new List<int>();

                    foreach (var item in numbers)
                    {
                        foreach (var el in item)
                        {
                            if (lineOfNumbers.Contains(el))
                            {
                                counts[counter]++;
                            }
                        }
                        counter++;
                    }

                    int biggestNum = 0;
                    int index = 0;

                    for (int j = 0; j < counts.Count - 1; j++)
                    {
                        if (counts[j] > biggestNum)
                        {
                            biggestNum = counts[j];
                            index = j;
                        }
                    }

                    output.Add(numbers[index]);

                    for (int t = 0; t < lineOfNumbers.Count; t++)
                    {
                        // Must remove from lineOfNumbers 
                    }

                    counts.Clear();// Unnecessary
                }
            }

            return output;

        }
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            List<int[]> linesOfNumbers = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                int[] newLineOfNumbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                linesOfNumbers.Add(newLineOfNumbers);
            }

            List<int[]> output = new List<int[]>();
            output = Nums(numbers, linesOfNumbers);

            Console.WriteLine($"Sets to take({output.Count})");
            foreach (var item in output)
            {
                string numersInALine = string.Join(", ", item);
                Console.WriteLine("{ "+ numersInALine + " }");
            }
        }
    }
}