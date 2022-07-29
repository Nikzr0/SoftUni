using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01.ArrayModifier
{
    public class Program
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
           
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] command = input.Split(" ");

                switch (command[0])
                {
                    case "swap":
                        int firstElementPosition = int.Parse(command[1]);
                        int secondElementPosition = int.Parse(command[2]);

                        int temp = list[secondElementPosition];
                        int secondTemp = list[firstElementPosition];

                        list.RemoveAt(firstElementPosition);
                        list.Insert(firstElementPosition, temp);

                        list.RemoveAt(secondElementPosition);
                        list.Insert(secondElementPosition, secondTemp);
                        break;

                    case "multiply":
                        int index1 = int.Parse(command[1]);
                        int index2 = int.Parse(command[2]);

                        int valueAtIndexOne = list[index1];
                        int valueAtIndexTwo = list[index2];

                        int multyNum = valueAtIndexOne * valueAtIndexTwo;

                        list.RemoveAt(index1);
                        list.Insert(index1, multyNum);
                        break;

                    case "decrease":

                        for (int i = 0; i < list.Count; i++)
                        {
                            int tempNum = list[i] - 1;

                            list.RemoveAt(i);
                            list.Insert(i, tempNum);
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", list));
        }
    }
}