using System;

namespace Ex02.VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fueLQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fueLQuantity, fuelConsumptionPerKm, tankCapacity)
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
            if (littersToAdd > 0 && FueLQuantity + littersToAdd < TankCapacity)
            {
                FueLQuantity = FueLQuantity + littersToAdd - littersToAdd / 20;
            }
            else if (littersToAdd <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (FueLQuantity + littersToAdd > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {littersToAdd} fuel in the tank");
            }
        }
    }
}
