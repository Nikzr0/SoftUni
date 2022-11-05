namespace CarRacing
{
    public class SuperCar : Car
    {
        public SuperCar(string make, string model, string vIN, int horsePower, double fuelAvailable, double fuelConsumptionPerRace) : base(make, model, vIN, horsePower, fuelAvailable, fuelConsumptionPerRace)
        {
            FuelAvailable = 80;
            FuelConsumptionPerRace = 10;
        }
    }
}
