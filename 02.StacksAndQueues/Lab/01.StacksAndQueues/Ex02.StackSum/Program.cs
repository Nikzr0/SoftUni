using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02.StackSum
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>();

            int sum = 0;

            foreach (var item in numbers)
            {
                stack.Push(item);
                sum += item;
            }
            

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    break;
                }

                string[] command = input.Split(" ");

                switch (command[0].ToLower())
                {
                    case "add":
                        int firstToAdd = int.Parse(command[1]);
                        int secondToAdd = int.Parse(command[2]);

                        stack.Push(firstToAdd);
                        stack.Push(secondToAdd);

                        sum += firstToAdd + secondToAdd;
                        break;

                    case "remove":
                        int numbersToRemove = int.Parse(command[1]);

                        if (stack.Count >= numbersToRemove)
                        {
                            for (int i = 0; i < numbersToRemove; i++)
                            {
                                int temp = stack.Peek();
                                sum -= temp;
                                stack.Pop();
                            }
                        }

                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}