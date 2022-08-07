using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02.AverageStudentGrades
{
    public class Program
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            while (numberOfStudents > 0)
            {
                string[] command = Console.ReadLine().Split(" ");
                string studentName = command[0];
                decimal studentGrade = decimal.Parse(command[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students[studentName].Add(studentGrade);
                }
                numberOfStudents--;
            }

            Console.WriteLine();
            foreach (var item in students) // .OrderByDescending(x => x.Value.Average()
            {
                Console.WriteLine($"{item.Key} -> {String.Join(" ",item.Value)} (avg: {item.Value.Average():f2})");
            }
        }
    }
}