using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.CarEngineAndTires
{
    class Car
    {
        public string make;
        public string model;
        public int year;
        public double fuelQuantity;
        public double fuelConsumtion;

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
        public Engin Engin { get; set; }
        public Tire[] Tires { get; set; }


        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumtion, Engin engin, Tire[] tires)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelConsumtion = fuelConsumtion;
            FuelQuantity = fuelQuantity;
            Engin = engin;
            Tires = tires;
        }

    }

    class Engin
    {
        private int horePopwer;
        private double cubicCapacity;
        public int HorePopwer
        {
            get
            {
                return horePopwer;
            }
            set
            {
                horePopwer = value;
            }
        }
        public double CubicCapacity
        {
            get
            {
                return cubicCapacity;
            }
            set
            {
                cubicCapacity = value;
            }
        }

        public Engin(int horePopwer, double cubicCapacity)
        {
            HorePopwer = horePopwer;
            CubicCapacity = cubicCapacity;
        }
    }

    class Tire
    {
        private int year;
        private double pressure;
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
        public double Pressure
        {
            get
            {
                return pressure;
            }
            set
            {
                pressure = value;
            }
        }

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }

    class Program
    {
        static void Main()
        {
            Engin engin = new Engin(560, 6300);
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.5),
            };

            Car car = new Car("VW", "Passat", 1998, 200, 10, engin, tires);
        }
    }
}