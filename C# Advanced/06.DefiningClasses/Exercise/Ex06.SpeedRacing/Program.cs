using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06.SpeedRacing
{

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();


            for (int i = 0; i < n; i++)
            {
                string[] carInformation = Console.ReadLine().Split(" ");

                string carName = carInformation[0];
                double carFuelAmount = double.Parse(carInformation[1]);
                double carConsumptionPerKm = double.Parse(carInformation[2]);

                cars.Add(new Car(carName, carFuelAmount, carConsumptionPerKm));
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] command = input.Split(" "); // Drive {carModel} {amountOfKm}

                string targetCar = command[1];
                double kilometersToDrive = double.Parse(command[2]);

                foreach (var item in cars.Where(x=>x.Model == targetCar))
                {
                    if (item.FuelAmount - item.ConsumptionPerKm * kilometersToDrive >= 0)
                    {
                        item.FuelAmount = item.FuelAmount - item.ConsumptionPerKm * kilometersToDrive;
                        item.TravelledDistance += kilometersToDrive;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }

            Console.WriteLine();
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}