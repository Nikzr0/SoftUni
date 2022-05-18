using System;
using System.Collections.Generic;
using System.Linq;

class Box
{
    public Box()
    {
        Item = new Item();
    }

    public string SerialNumber { get; set; } // 19861519 
    public Item Item { get; set; } // Dove 
    public int Quantity { get; set; } // 15 
    public double PriceBox { get; set; } // 2.50  / /-- itemQuantity * itemPrice

    public void Receipt() // serialNumber, name, Price
    {
        List<string> items = new List<string>();
        List<string> orderdItems = new List<string>();

        while (true)
        {
            string input = Console.ReadLine(); // 19861519 Dove 15 2.50

            if (input == "end")
            {
                break;
            }


            string[] itemsArray = input.Split();

            SerialNumber = itemsArray[0];
            Item.Name = itemsArray[1];
            Quantity = int.Parse(itemsArray[2]);
            Item.Price = double.Parse(itemsArray[3]);
            PriceBox = Item.Price * Quantity;

            items.Add($"{SerialNumber} \n-- {Item.Name} - ${Item.Price:f2} : {Quantity}\n-- ${PriceBox:f2}");
        }

        items = items.OrderByDescending(x => double.Parse(x.Split("$", StringSplitOptions.RemoveEmptyEntries)[2])).ToList();

        Console.WriteLine();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}