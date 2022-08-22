using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07.RawData
{
    class Program
    {
        class Car
        {
            public string Model { get; set; }
            public Engine Engine { get; set; }
            public Cargo Cargo { get; set; }
            public Tire[] Tires { get; }

            public Car(string model, Engine engine, Cargo cargo, Tire tire1, Tire tire2, Tire tire3, Tire tire4)
            {
                Model = model;
                Engine = engine;
                Cargo = cargo;

                Tires = new Tire[4];
                Tires[0] = tire1;
                Tires[1] = tire2;
                Tires[2] = tire3;
                Tires[3] = tire4;
            }

        }

        class Engine
        {
            public int Speed { get; set; }
            public int Power { get; set; }
            public Engine(int speed, int power)
            {
                Speed = speed;
                Power = power;
            }
        }

        class Cargo
        {
            public string Type { get; set; }
            public int Weight { get; set; }

            public Cargo(string type, int weight)
            {
                Type = type;
                Weight = weight;
            }
        }

        class Tire
        {
            public int Age { get; set; }
            public double Pressure { get; set; }

            public Tire(int age, double pressure)
            {
                Age = age;
                Pressure = pressure;
            }
        }

        static void Main()
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(" ");

                string carName = inputInfo[0];

                int engSpeed = int.Parse(inputInfo[1]);
                int engPower = int.Parse(inputInfo[2]);

                int cargoWeight = int.Parse(inputInfo[3]);
                string cargoType = inputInfo[4];

                double tire1Pressure = double.Parse(inputInfo[5]);
                int tire1Age = int.Parse(inputInfo[6]);
                double tire2Pressure = double.Parse(inputInfo[7]);
                int tire2Age = int.Parse(inputInfo[8]);
                double tire3Pressure = double.Parse(inputInfo[9]);
                int tire3Age = int.Parse(inputInfo[10]);
                double tire4Pressure = double.Parse(inputInfo[11]);
                int tire4Age = int.Parse(inputInfo[12]);


                Engine engine = new Engine(engSpeed, engPower);

                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tire tire1 = new Tire(tire1Age, tire1Pressure);
                Tire tire2 = new Tire(tire2Age, tire2Pressure);
                Tire tire3 = new Tire(tire3Age, tire3Pressure);
                Tire tire4 = new Tire(tire4Age, tire4Pressure);

                cars.Add(new Car(carName, engine, cargo, tire1, tire2, tire3, tire4));
            }

            string command = Console.ReadLine();

            Console.WriteLine();
            switch (command)
            {
                case "fragile":

                    foreach (var item in cars.Where(x => x.Cargo.Type == command && x.Tires.Any(y => y.Pressure < 1)))
                    {
                        Console.WriteLine(item.Model);
                    }
                    break;

                case "flammable":
                    foreach (var item in cars.Where(x => x.Cargo.Type == command && x.Engine.Power > 250))
                    {
                        Console.WriteLine(item.Model);
                    }
                    break;
            }
        }
    }
}
