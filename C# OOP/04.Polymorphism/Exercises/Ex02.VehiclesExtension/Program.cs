using System;

namespace Ex02.VehiclesExtension
{
    public class Program
    {
        static void Main()
        {
            string[] carInfo = Console.ReadLine().Split(" ");
            string[] truckInfo = Console.ReadLine().Split(" ");
            string[] busInfo = Console.ReadLine().Split(" ");

            Vehicle vehicleCar = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle vehicleTruck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(carInfo[3]));
            Bus vehicleBus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));


            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] command = Console.ReadLine().Split(" ");
                string firstTwo = command[0] + " " + command[1];
                switch (firstTwo)
                {
                    case "Drive Car":
                        double distanceForCar = double.Parse(command[2]);
                        Console.WriteLine(vehicleCar.Drive(distanceForCar));
                        break;

                    case "Drive Truck":
                        double distanceForTruck = double.Parse(command[2]);
                        Console.WriteLine(vehicleTruck.Drive(distanceForTruck));
                        break;

                    case "Drive Bus":
                        double distanceForBus = double.Parse(command[2]);
                        Console.WriteLine(vehicleBus.Drive(distanceForBus));
                        break;

                    case "DriveEmpty Bus":
                        double empty = double.Parse(command[2]);
                        Console.WriteLine(vehicleBus.DriveEmpty(empty));
                        break;

                    case "Refuel Car":
                        double litersForCar = double.Parse(command[2]);
                        vehicleCar.Refueling(litersForCar);
                        break;

                    case "Refuel Truck":
                        double litersForTruch = double.Parse(command[2]);
                        vehicleTruck.Refueling(litersForTruch);
                        break;

                    case "Refuel Bus":
                        double litersForBus = double.Parse(command[2]);
                        vehicleTruck.Refueling(litersForBus);
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Car: {Math.Round(vehicleCar.FueLQuantity, 2, MidpointRounding.ToPositiveInfinity):f2}");
            Console.WriteLine($"Truck: {Math.Round(vehicleTruck.FueLQuantity, 2, MidpointRounding.ToPositiveInfinity):f2}");
            Console.WriteLine($"Bus: {Math.Round(vehicleBus.FueLQuantity, 2, MidpointRounding.ToPositiveInfinity):f2}");
        }
    }
}
