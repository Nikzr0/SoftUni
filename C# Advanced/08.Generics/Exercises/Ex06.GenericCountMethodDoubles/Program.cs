using System;
using System.Collections.Generic;

namespace Ex06.GenericCountMethodDoubles
{
    public class Program
    {   
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<double> doubles = new List<double>();
            for (int i = 0; i < n; i++)
            {
                doubles.Add(double.Parse(Console.ReadLine()));
            }
            double element = double.Parse(Console.ReadLine());

            Console.WriteLine(GetCountClass.GetCountGreaterThan(doubles, element));
        }
    }
}