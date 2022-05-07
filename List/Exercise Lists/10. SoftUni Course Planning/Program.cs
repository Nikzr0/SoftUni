using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> schedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

        while (true)
        {
            string comand = Console.ReadLine();

            if (comand == "course start")
            {
                break;
            }

            string[] comandArray = comand.Split(":");

            switch (comandArray[0])
            {
                case "Add":
                    string addTitle = comandArray[1];

                    if (!schedule.Contains(addTitle))
                    {
                        schedule.Add(addTitle);
                    }
                    break;

                case "Remove":
                    string removeTitle = comandArray[1];

                    if (schedule.Contains(removeTitle))
                    {
                        schedule.Remove(removeTitle);
                    }
                    break;

                case "Swap":
                    string firstTitle = comandArray[1];
                    string secondTitle = comandArray[2];

                    if (schedule.Contains(firstTitle) && schedule.Contains(secondTitle))
                    {
                        int indexOne = schedule.IndexOf(firstTitle);
                        int indexTwo = schedule.IndexOf(secondTitle);

                        schedule[indexOne] = secondTitle;
                        schedule[indexTwo] = firstTitle;


                        if (schedule.Contains($"{firstTitle}-Exercise") && schedule.Contains($"{secondTitle}-Exercise"))
                        {
                            string firstTitleE = $"{firstTitle}-Exercise";
                            string secondTitleE = $"{secondTitle}-Exercise";


                            int indexOneE = schedule.IndexOf($"{firstTitle}-Exercise");
                            int indexTwoE = schedule.IndexOf($"{secondTitle}-Exercise");

                            schedule[indexOneE] = secondTitleE;
                            schedule[indexTwoE] = firstTitleE;
                        }
                        else
                        {
                            if (schedule.Contains($"{firstTitle}-Exercise"))
                            {
                                int temp = schedule.IndexOf($"{firstTitle}-Exercise");
                                schedule.Remove(schedule[temp]);
                                schedule.Insert(indexTwo, $"{firstTitle}-Exercise");
                            }

                            if (schedule.Contains($"{secondTitle}-Exercise"))
                            {
                                int temp = schedule.IndexOf($"{secondTitle}-Exercise");
                                schedule.Remove(schedule[temp]);
                                schedule.Insert(indexOne + 1, $"{secondTitle}-Exercise");
                            }
                        }
                    }
                    break;


                case "Insert":
                    string insertTitel = comandArray[1];
                    int index = int.Parse(comandArray[2]);

                    if (!schedule.Contains(insertTitel))
                    {
                        if ($"{schedule[index - 1]}-Exercise" == $"{schedule[index]}")
                        {
                            schedule.Insert(index + 1, insertTitel);
                        }
                        else
                        {
                            schedule.Insert(index, insertTitel);
                        }
                    }
                    break;

                case "Exercise":
                    if (schedule.Contains(comandArray[1]))
                    {
                        int exerciseIndex = schedule.IndexOf(comandArray[1]);

                        schedule.Insert(exerciseIndex + 1, $"{comandArray[1]}-Exercise");
                    }
                    else
                    {
                        schedule.Add(comandArray[1]);
                        schedule.Add($"{comandArray[1]}-Exercise");
                    }
                    break;
            }
        }

        Console.WriteLine();

        int x = 1;
        foreach (var item in schedule)
        {
            Console.WriteLine($"{x}.{item}");
            x++;
        }
    }
}