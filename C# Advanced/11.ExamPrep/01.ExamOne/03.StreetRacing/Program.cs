using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public int HorsePower { get; set; }
        public double Weight { get; set; }

        public Car(string make, string model, string licensePlate, int horsePower, double weight)
        {
            Make = make;
            Model = model;
            LicensePlate = licensePlate;
            HorsePower = horsePower;
            Weight = weight;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"License Plate: {LicensePlate}");
            sb.AppendLine($"Horse Power: {HorsePower}");
            sb.AppendLine($"Weight: {Weight}");
            return sb.ToString().TrimEnd();
        }
    }

    public class Race
    {
        public Dictionary<string, Car> participants { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
        }

        private int count;

        public void Add(Car car)
        {
            if (!participants.ContainsKey(car.LicensePlate) && car.HorsePower <= MaxHorsePower && count < Capacity)
            {
                participants.Add(car.LicensePlate, car);
                count++;
            }
        }

        public bool Remove(string licensePlate)
        {
            bool isRemoved = false;

            if (participants.ContainsKey(licensePlate))
            {
                participants.Remove(licensePlate);
                isRemoved = true;
            }

            return isRemoved;
        }

        public Car FindParticipant(string licensePlate)
        {
            if (participants.ContainsKey(licensePlate))
            {
                return participants.Where(x => x.Key == licensePlate).First().Value;
            }
            else
            {
                return null;
            }
        }

        public Car GetMostPowerfulCar()
        {
            if (participants.Count > 0)
            {
                return participants.OrderByDescending(x => x.Value.HorsePower).First().Value;
            }
            else
            {
                return null;
            }
        }

        public void Report()
        {
            Console.WriteLine($"Race: {Name} - Type: {Type} (Laps: {Laps}");
            
            foreach (var car in participants.Values)
            {
                car.ToString();
            }
        }
    }
    public class StartUp
    {
        static void Main()
        {

        }
    }
}