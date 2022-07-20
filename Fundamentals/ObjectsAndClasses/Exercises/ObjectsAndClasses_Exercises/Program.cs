using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<string> exeptions = new List<string>();


        while (true)
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            string[] commands = input.Split();

            switch (commands[0])
            {
                case "Add":
                    int numberToAdd = int.Parse(commands[1]);
                    nums.Add(numberToAdd);
                    break;

                case "Insert":
                    int number = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);

                    if (int.Parse(commands[2]) > nums.Count)
                    {
                        exeptions.Add("Invalid index");
                    }
                    else
                    {
                        nums.Insert(position, number);
                    }
                    break;

                case"Remove":
                    if (int.Parse(commands[1]) > nums.Count)
                    {
                        exeptions.Add("Invalid index");
                    }
                    else
                    {
                        nums.RemoveAt(int.Parse(commands[1]));
                    }
                    break;

                case "Shift":

                    if (commands[1] == "left")
                    {
                        int timesToLeft = int.Parse(commands[2]); //3

                        for (int i = 0; i < timesToLeft; i++)
                        {
                            int temp = nums[0];
                            nums.RemoveAt(0);
                            nums.Add(temp);
                        }
                    }
                    else
                    {
                        int timesToRight = int.Parse(commands[2]); //3

                        for (int i = 0; i < timesToRight; i++)
                        {
                            int temp = nums[nums.Count - 1];
                            nums.RemoveAt(nums.Count - 1);
                            nums.Insert(0,temp);
                        }
                    }
                    break;
            }
        }
        Console.WriteLine();
        Console.WriteLine(String.Join(" ",exeptions));
        Console.WriteLine(String.Join(" ", nums));
    }
}