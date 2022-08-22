using System;

namespace Ex01.Car
{
    class Car
    { 
        private string make;
        private string model;
        private int year;

        public string Make;
        public string Model;
        public int Year;

        public static string CarInfo(string make, string model, int age)
        {
            string carInfo = $"The company make {make}\nThe model is {model}\nThe year is {age}";
            return carInfo;
        }

    }
    public class Program
    {
        public static void Main()
        {
            Car car1 = new Car();
            car1.Make = "VW";
            car1.Model = "Passat";
            car1.Year = 1998;

            // Using class prop
            Console.WriteLine($"The company make {car1.Make}\nThe model is {car1.Model}\nThe year is {car1.Year}");
            // Using static method
            Console.WriteLine(Car.CarInfo("VW", "Passat", 1998));
        }
    }
}