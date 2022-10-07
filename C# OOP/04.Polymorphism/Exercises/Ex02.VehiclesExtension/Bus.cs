namespace Ex02.VehiclesExtension
{
    public class Bus : Vehicle
    {
        public bool Travelers { get; set; }
        public Bus(double fueLQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fueLQuantity, fuelConsumptionPerKm, tankCapacity)
        {
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
        public override string Drive(double kms)
        {
            if (FueLQuantity - (kms * (FuelConsumptionPerKm + 1.4)) >= 0)
            {
                FueLQuantity = FueLQuantity - (kms * (FuelConsumptionPerKm + 1.4));
                return $"Bus travelled {kms} km";
            }
            else
            {
                return "Bus needs refueling";
            }
        }
        public string DriveEmpty(double kms)
        {
            if (FueLQuantity - kms * FuelConsumptionPerKm >= 0)
            {
                FueLQuantity = FueLQuantity - kms * FuelConsumptionPerKm;
                return $"Bus travelled {kms} km";
            }
            else
            {
                return "Bus needs refueling";
            }
        }
    }
}
