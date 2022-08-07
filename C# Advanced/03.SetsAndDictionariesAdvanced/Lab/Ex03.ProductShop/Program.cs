using System;
using System.Collections.Generic;

namespace Ex03.ProductShop
{
    public class Program
    {
        public static void Main( )
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Revision")
                {
                    break;
                }
                string[] command = input.Split(", ");

                string shopName = command[0];
                string productName = command[1];
                double price = double.Parse(command[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                    shops[shopName].Add(productName,price);
                }
                else
                {
                    shops[shopName].Add(productName, price);
                }
            }

            Console.WriteLine();
            foreach (var item in shops)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var products in item.Value)
                {
                    Console.WriteLine($"Product: {products.Key}, Price: {products.Value}");
                }
            }
        }
    }
}