using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Ex01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
         
        // try - catch must be implement
        public double Length
        {
            get 
            {
                return length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }
                length = value;
            }
        }
        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double SurfaceArea(double length, double width, double height)
        {
            double sum = 0;
            sum += length * height * 2;
            sum += width * height * 2;
            sum += length * width * 2;
            return sum;
        }

        public double LateralSurfaceArea(double length, double width, double height)
        {
            double sum = 0;
            sum += length * height * 2;
            sum += width * height * 2;
            return sum;
        }
        public double Volum(double length, double width, double height)
        {
            return length * width * height;
        }
    }
    public class Program
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.SurfaceArea(length, width, height):f2}");
            Console.WriteLine($"Lateral Surface - {box.LateralSurfaceArea(length, width, height):f2}");
            Console.WriteLine($"Volum - {box.Volum(length, width, height):f2}");
        }
    }
}