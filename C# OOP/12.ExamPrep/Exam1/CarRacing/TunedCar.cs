namespace CarRacing
{
    public class TunedCar : Car
    {
        public TunedCar(string make, string model, string vIN, int horsePower, double fuelAvailable, double fuelConsumptionPerRace) : base(make, model, vIN, horsePower, fuelAvailable, fuelConsumptionPerRace)
        {
            FuelAvailable = 65;
            FuelConsumptionPerRace = 7.5;
        }

        public override void Drive()
        {
            // Potential Error? 
            base.Drive(); 
            HorsePower -= (int)(HorsePower * 0.03);
        }
    }
}
