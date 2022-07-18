using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            string[] command = input.Split(" : ");
            string courseName = command[0];
            string studentName = command[1];

            if (!courses.ContainsKey(courseName))
            {
                courses.Add(courseName, new List<string>());
                courses[courseName].Add(studentName);
            }
            else
            {
                courses[courseName].Add(studentName);
            }
        }

        Console.WriteLine();
        foreach (var item in courses.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"{item.Key}: {item.Value.Count}");

            foreach (var student in item.Value.OrderBy(x =>x))
            {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}