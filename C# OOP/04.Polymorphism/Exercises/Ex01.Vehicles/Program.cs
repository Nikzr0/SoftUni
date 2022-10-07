using System;

namespace Ex01.Vehicles
{
    public abstract class Vehicle
    {
        public double FueLQuantity { get; set; }
        public double FuelConsumptionPerKm { get; set; }

        public Vehicle(double fueLQuantity, double fuelConsumptionPerKm)
        {
            FueLQuantity = fueLQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public abstract string Drive(double kms);

        public virtual void Refueling(double littersToAdd)
        {
            FueLQuantity += littersToAdd;
        }
    }
    public class Car : Vehicle
    {
        public Car(double fueLQuantity, double fuelConsumptionPerKm) : base(fueLQuantity, fuelConsumptionPerKm)
        {
            FuelConsumptionPerKm = fuelConsumptionPerKm + 0.9;
        }

        public override string Drive(double kms)
        {
            if (kms * FuelConsumptionPerKm <= FueLQuantity)
            {
                FueLQuantity = FueLQuantity - kms * FuelConsumptionPerKm;
                return $"Car travelled {kms} km";
            }
            else
            {
                return "Car needs refueling";
            }
        }
    }
    public class Truck : Vehicle
    {
        public Truck(double fueLQuantity, double fuelConsumptionPerKm) : base(fueLQuantity, fuelConsumptionPerKm)
        {
            FuelConsumptionPerKm = fuelConsumptionPerKm + 1.6;
        }

        public override string Drive(double kms)
        {
            if (FueLQuantity - kms * FuelConsumptionPerKm >= 0)
            {
                FueLQuantity = FueLQuantity - kms * FuelConsumptionPerKm;
                return $"Truck travelled {kms} km";
            }
            else
            {
                return "Truck needs refueling";
            }
        }

        public override void Refueling(double littersToAdd)
        {
            FueLQuantity = FueLQuantity  + littersToAdd - littersToAdd / 20;
        }
    }
    public class Program
    {
        static void Main()
        {
            string[] carInfo = Console.ReadLine().Split(" ");
            string[] truckInfo = Console.ReadLine().Split(" ");

            Vehicle vehicleCar = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Vehicle vehicleTruck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));


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

                    case "Refuel Car":
                        double litersForCar = double.Parse(command[2]);
                        vehicleCar.Refueling(litersForCar);
                        break;

                    case "Refuel Truck":
                        double litersForTruch = double.Parse(command[2]);
                        vehicleTruck.Refueling(litersForTruch);
                        break;
                }
            }
            Console.WriteLine($"Car: {vehicleCar.FueLQuantity:f2}");

            Console.WriteLine($"Truck: {Math.Round(vehicleTruck.FueLQuantity, 2, MidpointRounding.ToPositiveInfinity)}");
        }
    }
}