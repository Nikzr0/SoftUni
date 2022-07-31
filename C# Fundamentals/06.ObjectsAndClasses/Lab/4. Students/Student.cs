using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public void Person()
    {
        List<string> students = new List<string>();
        List<string> output = new List<string>();

        while (true)
        {
            string student = Console.ReadLine();
            if (student == "end")
            {
                break;
            }

            students.Add(student);
        }

        string cityName = Console.ReadLine();

        for (int i = 0; i < students.Count; i++)
        {
            string[] studentsArray = students[i].Split(' ');

            if (studentsArray[3] == cityName)
            {
                output.Add($"{studentsArray[0]} {studentsArray[1]} is {studentsArray[2]} years old.");
            }
        }
        Console.WriteLine();
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }
}