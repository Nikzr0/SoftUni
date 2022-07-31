using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01.BasicStackOperations
{
    public class Program
    {
        public static void Main()
        {
            int[] inpputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            int numbersToPush = inpputNumbers[0];
            int numbersToPop = inpputNumbers[1];
            int numbersToSearch = inpputNumbers[2];

            int[] newNum = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(newNum[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count > 0)
            {
                if (stack.Contains(numbersToSearch))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    foreach (var item in stack.OrderBy(x => x).Take(1))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}