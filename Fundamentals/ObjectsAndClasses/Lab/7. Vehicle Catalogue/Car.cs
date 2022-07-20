using System;
using System.Collections.Generic;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string HorsePower { get; set; }

    Truck truck = new Truck();

    public void VehiclePrint()
    {
        List<string> cars = new List<string>();
        List<string> trucks = new List<string>();

        while (true)
        {
            string input = Console.ReadLine(); // Car/Audi/A3/110

            if (input == "end")
            {
                break;
            }

            string[] itemsArray = input.Split('/');

            if (itemsArray[0] == "Car")
            {
                Brand = itemsArray[1];
                Model = itemsArray[2];
                HorsePower = itemsArray[3];

                cars.Add($"{Brand}: {Model} - {HorsePower}hp");
            }

            if (itemsArray[0] == "Truck")
            {
                Brand = itemsArray[1];
                Model = itemsArray[2];
                truck.Weight = itemsArray[3];
                trucks.Add($"{Brand}: {Model} - {truck.Weight}kg");
            }
        }

        Console.WriteLine();
        if (cars.Count != 0)
        {
            Console.WriteLine("Cars:");
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }

        if (trucks.Count != 0)
        {
            Console.WriteLine("Trucks:");
            foreach (var item in trucks)
            {
                Console.WriteLine(item);
            }
        }
    }
}