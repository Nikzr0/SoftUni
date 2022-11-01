using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex08.SetCover
{
    public class Program
    {
        private static int topIndex = 0;
        private static int outputIndex = 0;
        static void Main()
        {
            List<int> univers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            Dictionary<int, List<int>> input = new Dictionary<int, List<int>>();
            Dictionary<int, List<int>> output = new Dictionary<int, List<int>>();
            int inputIndex = 0;

            List<int> containsList = new List<int>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "")
                {
                    break;
                }
                List<int> numbers = inputLine.Split(", ").Select(int.Parse).ToList();

                inputIndex++;
                input.Add(inputIndex, numbers);
            }

            for (int i = 0; i < input.Count; i++)
            {
                containsList.Add(0);
            }

            SetCover(univers, input, output, containsList, outputIndex);
        }
        private static void SetCover(List<int> univers, Dictionary<int, List<int>> input, Dictionary<int,
            List<int>> output, List<int> containsList, int outputIndex)
        {
            while (univers.Count != 0)
            {
                ContainsList(univers, input, containsList);
                FindTheBestLine(containsList);
                Swap(univers, input, output, containsList);
            }

            Writer(output);
        }
        private static void Writer(Dictionary<int, List<int>> output)
        {
            Console.WriteLine($"Sets to take ({output.Count}):");
            foreach (var item in output)
            {
                Console.WriteLine(String.Join(", ", item.Value));
            }
        }
        private static void Swap(List<int> univers, Dictionary<int, List<int>> input,
            Dictionary<int, List<int>> output, List<int> containsList)
        {
            List<int> topLine = input[topIndex + 1];
            input[topIndex + 1] = new List<int> { 0 };

            for (int i = 0; i < topLine.Count; i++)
            {
                if (univers.Contains(topLine[i]))
                {
                    univers.Remove(topLine[i]);
                }
            }
            containsList[topIndex] = 0;
            outputIndex++;
            output.Add(outputIndex, topLine);
        }
        private static void FindTheBestLine(List<int> containsList)
        {
            int top = 0;
            topIndex = 0;
            for (int i = 0; i < containsList.Count; i++)
            {
                if (containsList[i] > top)
                {
                    topIndex = i;
                    top = containsList[i];
                }
            }
        }
        private static void ContainsList(List<int> univers, Dictionary<int,
            List<int>> input, List<int> containsList)
        {
            for (int i = 0; i < containsList.Count; i++)
            {
                containsList[i] = 0;
            }
            for (int i = 0; i < input.Values.Count; i++)
            {
                List<int> line = input[i + 1];

                for (int h = 0; h < line.Count; h++)
                {
                    if (univers.Contains(line[h]))
                    {
                        containsList[i]++;
                    }
                }
            }
        }
    }
}