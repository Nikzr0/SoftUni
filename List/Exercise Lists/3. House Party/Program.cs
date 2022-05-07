using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> list = new List<string>();
        List<string> notes = new List<string>();

        while (n > 0)
        {
            string comand = Console.ReadLine();
            string[] comandArray = comand.Split();

            if (comandArray.Length == 3)// He is going.
            {
                if (list.Contains(comandArray[0]))
                {
                    notes.Add($"{comandArray[0]} is already in the list!");
                }
                else
                {
                    list.Add(comandArray[0]);
                }
            }
            else
            {
                if (list.Contains(comandArray[0]))
                {
                    list.Remove(comandArray[0]);
                }
                else
                {
                    notes.Add($"{comandArray[0]} is not in the list!");
                }
            }

            n--;
        }

        Console.WriteLine();

        foreach (var item in notes)
        {
            Console.WriteLine(item);
        }
        foreach (var item in list)
        {
            Console.WriteLine(item);
        } 
    }
}