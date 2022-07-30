using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03._Numbers
{
    public class Program
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

            double sum = 0;
            double avarageSum = 0;


            foreach (var item in numbers)
            {
                sum += item;
            }

            avarageSum = sum / numbers.Count;

            foreach (var item in numbers.OrderByDescending(x => x).Take(1))
            {
                if (item <= avarageSum)
                {
                    Console.WriteLine("No");
                }
            }

            foreach (var item in numbers.OrderByDescending(x => x).Where(x => x > avarageSum).Take(5))
            {
                Console.Write(item + " ");
            }
        }
    }
}