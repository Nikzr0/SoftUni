using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex08.CarSalesman
{
    class Program
    {
        class Car
        {
            public string Model { get; set; }
            public Engine Engine { get; set; }
            public int Weight { get; set; } // optional
            public string Color { get; set; } // optional

            public Car()
            {

            }
            public Car(string model, Engine engine)
            {
                Model = model;
                Engine = engine;
            }

            public Car(string model, Engine engine, int weight) : this(model, engine)
            {
                Weight = weight;               
            }

            public Car(string model, Engine engine, string color) : this(model, engine)
            {
                Color = color;
            }

            public Car(string model, Engine engine, int weight, string color) : this(model, engine, weight)
            {
                Color = color;
            }
            public override string ToString() // ERROR 
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{Model}:");
                sb.AppendLine(Engine.ToString());

                if (Weight != 0)
                {
                    sb.AppendLine($"Weight: {Weight}");
                }
                else
                {
                    sb.AppendLine($"Weight: n/a");
                }

                if (Color != null)
                {
                    sb.AppendLine($"Color: {Color}");
                }
                else
                {
                    sb.AppendLine($"Color: n/a");
                }

                return sb.ToString().TrimEnd();
            }
        }

        class Engine
        {
            public string Model { get; set; }
            public int Power { get; set; }
            public int Displacement { get; set; } // optional
            public string Efficiency { get; set; }// optional

            public Engine()
            {

            }
            public Engine(string model, int power)
            {
                Model = model;
                Power = power;
            }

            public Engine(string model, int power, int displacement)
            {
                Model = model;
                Power = power;
                Displacement = displacement;
            }

            public Engine(string model, int power, string efficiency)
            {
                Model = model;
                Power = power;
                Efficiency = efficiency;
            }

            public Engine(string model, int power, int displacement, string efficiency)
            {
                Model = model;
                Power = power;
                Displacement = displacement;
                Efficiency = efficiency;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"  {Model}:");
                sb.AppendLine($"    Power: {Power}");

                if (Displacement != 0)
                {
                    sb.AppendLine($"    Displacement: {Displacement}");
                }
                else
                {
                    sb.AppendLine($"    Displacement: n/a");
                }

                if (Efficiency != null)
                {
                    sb.AppendLine($"    Efficiency: {Efficiency}");
                }
                else
                {
                    sb.AppendLine($"    Efficiency: n/a");
                }

                return sb.ToString().TrimEnd();
            }

        }

        static void Main()
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)// "{model} {power} {displacement} {efficiency}"
            {
                string[] enginInfo = Console.ReadLine().Split(" ");

                string engNme = enginInfo[0];
                int power = int.Parse(enginInfo[1]);

                if (enginInfo.Length == 2)
                {                   
                    engines.Add(new Engine(engNme, power));
                }
                else if (enginInfo.Length == 3)
                {
                    int intStr;
                    bool intResultTryParse = int.TryParse(enginInfo[2], out intStr);

                    if (intResultTryParse)
                    {
                        int displacement = int.Parse(enginInfo[2]);
                        engines.Add(new Engine(engNme, power, displacement));
                    }
                    else
                    {
                        string efficiancy = enginInfo[2];
                        engines.Add(new Engine(engNme, power, efficiancy));
                    }
                }
                else if (enginInfo.Length == 4)
                {
                    int displacement = int.Parse(enginInfo[2]);
                    string efficiency = enginInfo[3];
                    engines.Add(new Engine(engNme, power, displacement, efficiency));
                }
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)//"{model} {engine} {weight} {color}".
            {                
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = carInfo[0];
                string engModel = carInfo[1];

                Engine engine = engines.Where(x => x.Model == engModel).First();

                if (carInfo.Length ==2)
                {
                    cars.Add(new Car(carModel, engine));

                }
                else if (carInfo.Length == 3)
                {
                    int intStr;
                    bool intResultTryParse = int.TryParse(carInfo[2], out intStr);

                    if (intResultTryParse)
                    {
                        int weight = int.Parse(carInfo[2]);
                        cars.Add(new Car(carModel, engine, weight));
                    }
                    else
                    {
                        string color = carInfo[2];
                        cars.Add(new Car(carModel, engine, color));
                    }
                }
                else if (carInfo.Length == 4)
                {
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    cars.Add(new Car(carModel, engine, weight, color));
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}