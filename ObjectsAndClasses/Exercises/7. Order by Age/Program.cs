using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Persone
{
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }

    public Persone(string name, string id, int age)
    {
        Name = name;
        ID = id;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} with ID: {ID} is {Age} years old.";
    }
}


class Program
{
    static void Main()
    {
        List<Persone> people = new List<Persone>();


        while (true)
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            string[] personeInfo = input.Split(" ");

            Persone p = new Persone(personeInfo[0], personeInfo[1], int.Parse(personeInfo[2]));
            p.Name = personeInfo[0];
            p.ID = personeInfo[1];
            p.Age = int.Parse(personeInfo[2]);
            people.Add(p);
        }

        Console.WriteLine();
        Console.WriteLine();
        foreach (var item in people.OrderBy(x => x.Age))
        {
            Console.WriteLine(item);
        }
    }
}