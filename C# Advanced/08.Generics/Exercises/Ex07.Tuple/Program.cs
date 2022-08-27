using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07.Tuple
{
    public class Program
    {
        static void Main()
        {
            Tuple<string, string> tuple1 = new Tuple<string, string>();
            Tuple<string, int> tuple2 = new Tuple<string, int>();
            Tuple<int, double> tuple3 = new Tuple<int, double>();

            List<string> nameAndAddres = Console.ReadLine().Split(" ").ToList();

            string address = nameAndAddres[nameAndAddres.Count - 1];
            nameAndAddres.RemoveAt(nameAndAddres.Count - 1);
            string name = string.Join(" ", nameAndAddres);

            string[] nameAndAmountOdBeer = Console.ReadLine().Split(" ");

            string personName = nameAndAmountOdBeer[0];
            int amountOfBear = int.Parse(nameAndAmountOdBeer[1]);

            string[] numbers = Console.ReadLine().Split(" ");
            int intNum = int.Parse(numbers[0]);
            double doubleNum = double.Parse(numbers[0]);

            Console.WriteLine();
            Console.WriteLine($"{tuple1.Item1 = name} -> {tuple1.Item2 = address}");
            Console.WriteLine($"{tuple2.Item1 = personName} -> {tuple2.Item2 = amountOfBear}");
            Console.WriteLine($"{tuple3.Item1 = intNum} -> {tuple3.Item2 = doubleNum}");
        }
    }
}