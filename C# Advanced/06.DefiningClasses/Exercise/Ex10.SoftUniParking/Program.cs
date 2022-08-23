using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex10.SoftUniParking
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make {Make}");
            sb.AppendLine($"Model {Model}");
            sb.AppendLine($"HorsePower {HorsePower}");
            sb.AppendLine($"RegistrationNumber {RegistrationNumber}");
            return sb.ToString().TrimEnd();
        }
    }

    class Parking
    {
        private List<Car> cars;
        private int capacity;

        public int Count { get; set; }

        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            bool problemDtector = true;
            foreach (var item in cars)
            {
                if (car.RegistrationNumber == item.RegistrationNumber)
                {
                    Console.WriteLine("Car with that registration number, already exists!");
                    problemDtector = false;
                }
            }

            if (cars.Count > capacity)
            {
                Console.WriteLine("Parking is full!");
                problemDtector = false;
            }

            if (problemDtector)
            {
                cars.Add(car);
                Console.WriteLine("Successfully added new car {Make} {RegistrationNumber}");
            }
        }

        public void RemoveCar(string RegistrationNumber)
        {
            bool doesNotExist = true;

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].RegistrationNumber == RegistrationNumber)
                {
                    cars.Remove(cars[i]);
                    doesNotExist = false;
                    Console.WriteLine("Successfully removed {registrationNumber}");
                }
            }

            if (doesNotExist)
            {
                Console.WriteLine("Car with that registration number, doesn't exist!");
            }
        }

        public Car GetCar(string RegistrationNumber)
        {
            return cars.Where(x => x.RegistrationNumber == RegistrationNumber).First();
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                for (int j = 0; j < RegistrationNumbers.Count; j++)
                {
                    if (cars[i].RegistrationNumber == RegistrationNumbers[i])
                    {
                        cars.Remove(cars[i]);
                    }
                }
            }
            Count = cars.Count;
        }
    }
    public class Program
    {
        static void Main()
        {
            /*The Main method is empty, because "SoftUni Parking"
             is exam exercises and they give the Main method*/
        }
    }
}