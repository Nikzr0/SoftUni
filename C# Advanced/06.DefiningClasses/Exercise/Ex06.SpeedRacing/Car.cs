namespace Ex06.SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double ConsumptionPerKm { get; set; }
        public double TravelledDistance { get; set; }

        public Car()
        {
            TravelledDistance = 0;
        }

        public Car(string modelName, double fuelAmount, double consPerKm)
        {
            Model = modelName;
            FuelAmount = fuelAmount;
            ConsumptionPerKm = consPerKm;
        }
    }
}