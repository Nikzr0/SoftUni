using System;
using System.Collections.Generic;

namespace Ex01.ReverseStrings
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>();

            foreach (var item in input)
            {
                stack.Push(item.ToString());
            }

            foreach (var item in stack)
            {
                Console.Write(item);
            }
        }
    }
}