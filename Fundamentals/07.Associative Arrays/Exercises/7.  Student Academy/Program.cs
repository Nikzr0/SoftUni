using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        int n = int.Parse(Console.ReadLine()) * 2;
        string temp = "";


        while (n > 0)
        {
            string command = Console.ReadLine();

            if (n % 2 == 0)
            {
                if (!students.ContainsKey(command))
                {
                    students.Add(command, new List<double>());
                    temp = command;
                }
            }
            else
            {
                students[temp].Add(double.Parse(command));
            }
            n--;
        }

        Console.WriteLine();
        foreach (var item in students.OrderByDescending(x => x.Value.Sum() / x.Value.Count))
        {
            double avarage = item.Value.Sum() / item.Value.Count;
            if (avarage >= 4.50)
            {
                Console.WriteLine($"{item.Key} -> {avarage:f2}");
            }
        }
    }
}