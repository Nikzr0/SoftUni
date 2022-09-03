using System;
using System.Linq;

namespace Ex3.Stack
{
    public class Program
    {
        static void Main()
        {
            var stack = new Stack<string>();
            while (true)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "END")
                {
                    break;
                }
                else if (tokens[0] == "Push")
                {
                    stack.Push(tokens.Skip(1).Select(el => el.Split(",").First()).ToArray());
                }
                else if (tokens[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine("No Elements");
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}