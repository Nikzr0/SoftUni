using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> numbersDuplicate = numbers;
        while (true)
        {
            string comand = Console.ReadLine();

            if (comand == "end")
            {
                break;
            }

            string[] comandArray = comand.Split();

            switch (comandArray[0])
            {
                case "Contains":
                    int checkContains = int.Parse(comandArray[1]);
                    if (numbers.Contains(checkContains))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;

                case "PrintEven":

                    List<int> evenNumbers = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            evenNumbers.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ", evenNumbers));
                    break;

                case "PrintOdd":

                    List<int> oddNumbers = new List<int>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            oddNumbers.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ", oddNumbers));
                    break;

                case "GetSum":
                    int sum = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum = sum + numbers[i];
                    }
                    Console.WriteLine(sum);
                    break;

                case "Filter":
                    string condition = comandArray[1];
                    int numberForFilter = int.Parse(comandArray[2]);

                    switch (condition)
                    {
                        case ">":
                            List<int> filteredList = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > numberForFilter)
                                {
                                    filteredList.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredList));
                            break;


                        case "<":
                            List<int> filteredList2 = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < numberForFilter)
                                {
                                    filteredList2.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredList2));
                            break;


                        case ">=":
                            List<int> filteredList3 = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= numberForFilter)
                                {
                                    filteredList3.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredList3));
                            break;


                        case "<=":
                            List<int> filteredList4 = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= numberForFilter)
                                {
                                    filteredList4.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredList4));
                            break;
                    }
                    break;

            }

        }
        // I didn't understand this part of the task! 
        //result => 50% (5/10 tests)
        // All the given examples are working proparly!

        //After the end command, print the list only if you have made some
        //changes to the original list. Changes are made only from
        //thecommands from the previous task.

        int a = numbers.Count;
        int b = numbersDuplicate.Count;

        if (a > b)
        {
            Console.WriteLine(String.Join(" ", numbers));
        }
        else if (b > a)
        {
            Console.WriteLine(String.Join(" ", numbers));
        }
        else
        {
            for (int i = 0; i < a; i++)
            {
                if (numbers[i] != numbersDuplicate[i])
                {
                    Console.WriteLine(String.Join(" ", numbers));
                }
            }
        }
    }
}