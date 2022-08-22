using System;
using System.Collections.Generic;

namespace Ex02.CarExtension
{
    class Car
    {
        public string make;
        public string model;
        public int year;
        public double fuelQuantity;
        public double fuelConsumtion;
        public bool enoughFuel;


        public string Make
        {
            get
            {
                return make;
            }
            set
            {
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
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            set
            {
                fuelQuantity = value;
            }
        }
        public double FuelConsumtion
        {
            get
            {
                return fuelConsumtion;
            }
            set
            {
                fuelConsumtion = value;
            }
        }

        bool idEnoughFuel = true;
        public void Drive(double distance)
        {
            if (FuelQuantity - distance / 100 * FuelConsumtion >= 0)
            {
                FuelQuantity = FuelQuantity - distance / 100 * FuelConsumtion;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                idEnoughFuel = false;
            }
        }

        public void WhoIAm()
        {
            if (idEnoughFuel)
            {
                Console.WriteLine($"Make: {Make}");
                Console.WriteLine($"Model: {Model}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Fuel: {FuelQuantity:F2}");
            }
        }


    }
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "Passat";
            car.Year = 1998;
            car.FuelQuantity = 100;
            car.FuelConsumtion = 10;
            car.Drive(200);
            car.WhoIAm();
        }
    }
}
