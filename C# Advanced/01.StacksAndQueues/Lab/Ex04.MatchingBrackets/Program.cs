using System;
using System.Collections.Generic;

namespace Ex04.MatchingBrackets
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    var stackItemToPop = stack.Pop();
                    var closeIndex = i;
                    Console.WriteLine(input.Substring(stackItemToPop,closeIndex - stackItemToPop + 1));
                }

            }


        }
    }
}