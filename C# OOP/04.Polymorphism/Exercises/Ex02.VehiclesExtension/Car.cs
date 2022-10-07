namespace Ex02.VehiclesExtension
{
    public class Car : Vehicle
    {
        public Car(double fueLQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fueLQuantity, fuelConsumptionPerKm, tankCapacity)
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
}
