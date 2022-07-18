using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "buy")
            {
                break;
            }

            string[] command = input.Split(' ');


            if (!products.ContainsKey(command[0]))
            {
                products.Add(command[0], new Dictionary<double, int>());
                products[command[0]].Add(double.Parse(command[1]), int.Parse(command[2]));
            }
            else
            {
                double oldPrice = products[command[0]].FirstOrDefault().Key;
                int oldQuantity = products[command[0]].FirstOrDefault().Value;

                products[command[0]].Remove(oldPrice); // Remove the whole dictionary (Price + Quantity)
                products[command[0]].Add(double.Parse(command[1]), int.Parse(command[2]) + oldQuantity);
            }


        }

        foreach (var item in products)
        {
            foreach (var money in item.Value)
            {
                Console.WriteLine($"{item.Key} -> {money.Key * money.Value:f2}");
            }
        }

    }
}