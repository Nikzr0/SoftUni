using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.MaximumAndMinimumElement
{
    public class Program
    {
        public static void Main()
        {
            Queue<int> minAndMaxElements = new Queue<int>();
            Stack<int> stack = new Stack<int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                int[] numbers = input.Split(" ").Select(int.Parse).ToArray();



                switch (numbers[0])
                {
                    case 1:
                        stack.Push(numbers[1]);
                        break;

                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;

                    case 3:
                        foreach (var item in stack.OrderByDescending(x => x).Take(1))
                        {
                            minAndMaxElements.Enqueue(item);
                        }
                        break;

                    case 4:
                        foreach (var item in stack.OrderBy(x => x).Take(1))
                        {
                            minAndMaxElements.Enqueue(item);
                        }
                        break;


                }
            }

            foreach (var item in minAndMaxElements)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(String.Join(", ", stack));
        }
    }
}