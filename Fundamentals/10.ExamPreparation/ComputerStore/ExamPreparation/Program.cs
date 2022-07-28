using System;
using System.Collections.Generic;

namespace ExamPreparation
{
    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>();

            decimal priceWithoutTaxes = 0;
            decimal taxes = 0;
            decimal endPrice = 0;

            string typeOfCustomer = "";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "special" || input == "regular")
                {
                    typeOfCustomer = input;
                    break;
                }

                if (decimal.Parse(input) > 0)
                {
                    priceWithoutTaxes += decimal.Parse(input);
                }
                else
                {
                    list.Add("Invalid price!");
                }
            }

            if (typeOfCustomer == "special")
            {
                taxes = priceWithoutTaxes / 5;
                endPrice = priceWithoutTaxes + taxes;
                endPrice = endPrice - endPrice / 10; 
            }
            else if (typeOfCustomer == "regular")
            {
                taxes = priceWithoutTaxes / 5;
                endPrice = priceWithoutTaxes + taxes;
            }

            if (endPrice <= 0)
            {
                list.Add("Invalid order!");

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            else if (endPrice > 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {endPrice:f2}$");
            }
        }
    }
}