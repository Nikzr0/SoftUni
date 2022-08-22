using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05.SpecialCars
{
    class Car
    {
        public string make;
        public string model;
        public int year;
        public double fuelQuantity;
        public double fuelConsumtion;
        public int engin;
        public double tire;

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
        public int Engin
        {
            get
            {
                return engin;
            }
            set
            {
                engin = value;
            }
        }
        public double Tire
        {
            get
            {
                return tire;
            }
            set
            {
                tire = value;
            }
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumtion, int engin, double tire)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelConsumtion = fuelConsumtion;
            FuelQuantity = fuelQuantity;
            Engin = engin;
            Tire = tire;
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
            List<Tire> tires = new List<Tire>();

            while (true)
            {
                string tiresInput = Console.ReadLine();

                if (tiresInput == "No more tires")
                {
                    break;
                }

                string[] tiresInfo = tiresInput.Split(" ");
                for (int i = 0; i < tiresInfo.Length; i+=2)
                {
                    int year = int.Parse(tiresInfo[i]);
                    double pressure = double.Parse(tiresInfo[i + 1]);

                    tires.Add(new Tire(year, pressure));
                }
            }

            List<Engin> engines = new List<Engin>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }

                string[] engInput = input.Split(" ");
                int engHorePopwer = int.Parse(engInput[0]);
                double cubicCapacity = double.Parse(engInput[1]);

                engines.Add(new Engin(engHorePopwer, cubicCapacity));
            }

            List<Car> cars = new List<Car>();

            while (true)
            {
                string carInfo = Console.ReadLine();

                if (carInfo == "Show special")
                {
                    break;
                }

                string[] command = carInfo.Split(" ");

                
                int enginPower = engines[0].HorePopwer;
                engines.Remove(engines[0]);
                double tirePressure = 0;

                for (int i = 0; i < 4; i++)
                {
                    tirePressure += tires[i].Pressure;
                }

                for (int i = 0; i < 4; i++)
                {
                    tires.Remove(tires[0]);
                }


                cars.Add(new Car(command[0], command[1], int.Parse(command[2]), double.Parse(command[3]) - double.Parse(command[4]) / 5,
                    double.Parse(command[4]), enginPower, tirePressure));
            }

            Console.WriteLine();
            foreach (var item in cars.Where(x=>x.Year >= 2017 && x.Engin > 330 && x.Tire > 9 && x.Tire < 10))
            {
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine($"HorsePowers: {item.Engin}");
                Console.WriteLine($"FuelQuantity: {item.FuelQuantity:f1}");
                Console.WriteLine();
            }            
        }
    }
}