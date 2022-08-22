using System;
namespace Ex03.CarConstructors
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

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumtion = 10;
        }

        //public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this()
        //{

        //}
    }
    class Program
    {
        static void Main()
        {
            Car car = new Car();

            Console.WriteLine($"Make - {car.Make}");
            Console.WriteLine($"Model - {car.Model}");
            Console.WriteLine($"Year - {car.Year}");
            Console.WriteLine($"FuelQuantity - {car.FuelQuantity}");
            Console.WriteLine($"FuelConsumtion - {car.FuelConsumtion}");
        }
    }
}