using System;
using System.Collections.Generic;
using System.Linq;

class Students
{
    private string firtsName_;
    private string secondName_;
    private double grade_;

    public string FirstName
    {
        get
        {
            return firtsName_;
        }

        set
        {
            firtsName_ = value;
        }
    }

    public string SecondName
    {
        get
        {
            return secondName_;
        }

        set
        {
            secondName_ = value;
        }
    }

    public double Grade
    {
        get
        {
            return grade_;
        }

        set
        {
            grade_ = value;
        }
    }


    public Students(string fName, string sName, double grade)
    {
        FirstName = fName;
        SecondName = sName;
        Grade = grade;
    }


    public override string ToString()
    {
        return $"{FirstName} {SecondName}: {Grade:f2}"; 
    }
}

class Program
{
    static void Main()
    {
        List<Students> listOfStudents = new List<Students>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] studentsInfo = Console.ReadLine().Split(' ');
            Students students = new Students(studentsInfo[0], studentsInfo[1], double.Parse(studentsInfo[2])); ;
            listOfStudents.Add(students);
        }

        //listOfStudents.Sort((student1, student2) => student1.Grade.CompareTo(student2.Grade));
        listOfStudents = listOfStudents.OrderByDescending(x => x.Grade).ToList();


        Console.WriteLine();
        foreach (var item in listOfStudents)
        {
            Console.WriteLine(item);
        }
    }
}