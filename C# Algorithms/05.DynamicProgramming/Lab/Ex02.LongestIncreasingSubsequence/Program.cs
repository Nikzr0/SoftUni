using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Ex02.LongestIncreasingSubsequence
{
    public class Program
    {
        private static List<int> result;
        static void Main()
        {
            result = new List<int>();
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            GetNumbers(input, 0);
        }

        private static void GetNumbers(List<int> input, int index)
        {
            if (index == 0)
            {
                result.Add(input[0]);
            }
            else
            {
                if (input[index] >= 0)
                {
                    if (input[index] > result[result.Count - 1])
                    {
                        result.Add(input[index]);
                    }
                    else if (input[index] == result[result.Count - 1])
                    {

                    }
                    else
                    {
                        //int temp = input[index];
                        while (input[index] < result[result.Count - 1])
                        {
                            result.RemoveAt(result.Count - 1);

                            if (result.Count == 0)
                            {
                                break;
                            }
                        }

                        result.Add(input[index]);
                    }
                }
            }

            if (index == input.Count - 1)
            {
                Console.WriteLine(string.Join(" ", result));
                return;
            }

            GetNumbers(input, index + 1);
        }
    }
}