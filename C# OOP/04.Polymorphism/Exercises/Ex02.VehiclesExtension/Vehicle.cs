using System;

namespace Ex02.VehiclesExtension
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        public double FueLQuantity
        {
            get { return fuelQuantity; }
            set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                    fuelQuantity = value;
                }
                fuelQuantity = value;
            }
        }
        public double FuelConsumptionPerKm { get; set; }
        public double TankCapacity { get; set; }

        public Vehicle(double fueLQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            FueLQuantity = fueLQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            TankCapacity = tankCapacity;
        }

        public abstract string Drive(double kms);

        public virtual void Refueling(double littersToAdd)
        {
            if (littersToAdd > 0 && FueLQuantity + littersToAdd < TankCapacity)
            {
                FueLQuantity += littersToAdd;
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
