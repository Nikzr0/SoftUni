using System;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract double CalculatePerimeter(double a, double b);
        public virtual double CalculateArea(double a, double b)
        {
            return a * b;
        }

        public virtual string Draw(double a, double b)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < a; i++)
            {
                int width = (int)b;
                sb.AppendLine(new string('#', width));
            }
            return sb.ToString().TrimEnd();
        }
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double CalculatePerimeter(double Height, double Width)
        {
            return (Height + Width) * 2;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius, double p)
        {
            Radius = radius;
        }

        public override double CalculatePerimeter(double Radius, double P)
        {
            return 2 * Radius * P;
        }

        public override double CalculateArea(double r, double p)
        {
            return p * r * r;
        }
        public override string Draw(double a, double b)// NOT DONE
        {
            return "This is circle -> 0";
        }
    }
    public class StartUp
    {
        static void Main()
        {
            double heigth = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(heigth, width);
            Console.WriteLine(rectangle.CalculatePerimeter(heigth, width));
            Console.WriteLine(rectangle.CalculateArea(heigth, width));
            Console.WriteLine(rectangle.Draw(heigth, width));

            double radius = double.Parse(Console.ReadLine());
            double p = Math.PI;
            Circle circle = new Circle(radius, p);
            Console.WriteLine(circle.CalculatePerimeter(radius, p));
            Console.WriteLine(circle.CalculateArea(radius, p));
            Console.WriteLine(circle.Draw(radius, p));
        }
    }
}