using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02.Cars
{
    public interface ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        string Start();
        string Stop();
    }

    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Start()
        {
             return "Engine start";
        }

        public string Stop()
        {
            return $"Breaaal!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Seat {Model}");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            return sb.ToString().TrimEnd();
        }
    }

    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return $"Breaaal!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} {Model} with {Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            return sb.ToString().TrimEnd();
        }
    }
    public interface IElectricCar
    {
        public int Battery { get; set; }
    }

    public class Program
    {
        static void Main()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());

        }
    }
}