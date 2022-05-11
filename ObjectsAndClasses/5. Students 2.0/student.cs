using System;
using System.Collections.Generic;

class Student
{
    public void Person()
    {
        List<string> students = new List<string>();
        List<string> studentsNames = new List<string>();
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

        int outputLenght = output.Count;

        for (int i = 0; i < output.Count - 1; i++)
        {
            string[] studentsOutputArray = output[output.Count - (1 + i)].Split(' ');

            for (int j = 0; j < output.Count - 1; j++)
            {
                string[] x = output[j].Split(' ');

                if (x[0] == studentsOutputArray[0] && x[1] == studentsOutputArray[1])
                {
                    output[j] = output[outputLenght - (1 + i)];
                    output.Remove(output[outputLenght - (1 + i)]);
                }
            }
        }

        Console.WriteLine();
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }
}