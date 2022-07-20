using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<string> exeptionList = new List<string>();

        while (true)
        {
            string comand = Console.ReadLine();

            if (comand == "End")
            {
                break;
            }

            string[] comandArray = comand.Split();

            switch (comandArray[0])
            {
                case "Add":
                    int addNumber = int.Parse(comandArray[1]);
                    numbers.Add(addNumber);
                    break;

                case "Remove":
                    int removeNumber = int.Parse(comandArray[1]);
                    if (numbers.Contains(int.Parse(comandArray[1])))
                    {
                        numbers.Remove(numbers[removeNumber]);
                    }
                    else
                    {
                        exeptionList.Add("Invalid index");
                    }

                    break;

                case "Shift":
                    int shiftNumber = int.Parse(comandArray[2]);

                    if (comandArray[1] == "left")
                    {
                        for (int i = 0; i < shiftNumber; i++)//3
                        {
                            int temp = numbers[0];//1

                            for (int j = 0; j < numbers.Count - 1; j++)// 8
                            {
                                numbers[j] = numbers[j + 1];
                            }

                            numbers[numbers.Count - 1] = temp;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < shiftNumber; i++)//3
                        {
                            int temp = numbers[numbers.Count - 1];//1

                            for (int j = 0; j < numbers.Count - 1; j++)// 8
                            {
                                numbers[numbers.Count - (1 + j)] = numbers[numbers.Count - (1 + j + 1)];
                            }

                            numbers[0] = temp;
                        }
                    }
                    break;

                case "Insert":
                    int numberToInsert = int.Parse(comandArray[1]);
                    int positionInsert = int.Parse(comandArray[2]);
                    if (positionInsert >= numbers.Count)
                    {
                        exeptionList.Add("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(positionInsert, numberToInsert);
                    }
                    break;

            }
        }
        foreach (var item in exeptionList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(String.Join(" ", numbers));
    }
}