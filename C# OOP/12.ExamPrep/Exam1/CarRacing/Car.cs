namespace CarRacing
{
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Utilities.Messages;
    using System;

    public class Car : ICar
    {
        private string make;
        private string model;
        private string vin;
        private int horsepower;
        private double fuelavailable;
        private double fuelconsumptionperrace;

        public Car(string make, string model, string vIN, int horsePower, double fuelAvailable, double fuelConsumptionPerRace)
        {
            Make = make;
            Model = model;
            VIN = vIN;
            HorsePower = horsePower;
            FuelAvailable = fuelAvailable;
            FuelConsumptionPerRace = fuelConsumptionPerRace;
        }

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarMake);
                }
                make = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarModel);
                }
                model = value;
            }
        }
        public string VIN
        {
            get
            {
                return vin;
            }
            set
            {
                if (value.Length != 17)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarVIN);
                }
                vin = value;
            }
        }
        public int HorsePower
        {
            get
            {
                return horsepower;
            }
            set
            {
                if (value < 0)
                {

                    throw new ArgumentException(ExceptionMessages.InvalidCarHorsePower);
                }
                horsepower = value;
            }
        }
        public double FuelAvailable
        {
            get
            {
                return fuelavailable;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                fuelavailable = value;
            }

        }
        public double FuelConsumptionPerRace
        {
            get
            {
                return fuelconsumptionperrace;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarFuelConsumption);
                }
                fuelconsumptionperrace = value;
            }

        }       

        public virtual void Drive()
        {
            FuelAvailable = FuelAvailable - FuelConsumptionPerRace;
        }
    }
}
