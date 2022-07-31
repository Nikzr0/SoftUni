using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
        int wagonCapacity = int.Parse(Console.ReadLine());

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
                case "Add":
                    int newWagons = int.Parse(comandArray[1]);
                    wagons.Add(newWagons);
                    break;

                default:
                    int newPassengers = int.Parse(comandArray[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassengers <= wagonCapacity)
                        {
                            wagons[i] = wagons[i] + newPassengers;
                            break;
                        }
                    }
                    break;
            }
        }
        Console.WriteLine(string.Join(" ",wagons));
    }
}