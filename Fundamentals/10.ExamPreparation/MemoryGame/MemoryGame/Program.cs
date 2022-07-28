using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    public class Program
    {
        public static void Main()
        {
            List<string> elements = Console.ReadLine().Split(" ").ToList();
            List<string> output = new List<string>();

            int numberOfMoves = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] position = input.Split(" ");

                if (elements.Count > 1)
                {
                    if (position[0].Contains("-") || position[1].Contains("-"))
                    {
                        output.Add($"Invalid input! Adding additional elements to the board");

                        int listLength = elements.Count / 2;

                        elements.Insert(listLength, "-2a");
                        elements.Insert(listLength + 1, "-2a");

                        numberOfMoves++;
                    }
                    else
                    {
                        int firstPosition = int.Parse(position[0]);// 1
                        int secondPosition = int.Parse(position[1]);// 0

                        if (firstPosition > elements.Count - 1 || secondPosition > elements.Count - 1 || firstPosition == secondPosition)  // POTENTIAL ERROR
                        {
                            output.Add($"Invalid input! Adding additional elements to the board");

                            int listLength = elements.Count / 2;

                            elements.Insert(listLength, "-2a");
                            elements.Insert(listLength + 1, "-2a");

                            numberOfMoves++;
                        }

                        if (elements[firstPosition] == elements[secondPosition])
                        {
                            output.Add($"Congrats! You have found matching elements - {elements[firstPosition]}!");
                            if (firstPosition > secondPosition) // 1 0
                            {
                                elements.RemoveAt(firstPosition);
                                elements.RemoveAt(secondPosition);
                            }
                            else // 0 1
                            {
                                elements.RemoveAt(secondPosition);
                                elements.RemoveAt(firstPosition);
                            }
                            numberOfMoves++;
                        }
                        else
                        {
                            output.Add("Try again!");
                            numberOfMoves++;
                        }
                        
                    }
                }
                else
                {
                    output.Add($"You have won in {numberOfMoves} turns!");
                }
            }

            if (elements.Count > 0)
            {
                output.Add("Sorry you lose :(");
                output.Add(String.Join(" ", elements));
            }

            Console.WriteLine();
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

        }
    }
}