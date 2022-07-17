using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList(); ;
        Dictionary<double, int> studentsDictionary = new Dictionary<double, int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (!studentsDictionary.ContainsKey(numbers[i]))
            {
                studentsDictionary.Add(numbers[i], 0);
            }

            studentsDictionary[numbers[i]]++;

        }

        foreach (var item in studentsDictionary.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }

    }

}