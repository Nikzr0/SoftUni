using System;
using System.Text;

namespace Ex01.Shapes
{
    public interface IDrawable
    {
        string Draw();
    }
    public class Circle : IDrawable
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public string Draw() // It doesn't look like a circle
        {
            StringBuilder sb = new StringBuilder();
            int gab = 2;

            string bottom = new string(' ', (Radius * 2 - 2) / 2) + new string('*', gab) + new string(' ', (Radius * 2 - 2) / 2);
            sb.AppendLine(bottom);
            while (gab < Radius * 2)
            {
                string line = new string(' ', Radius - gab / 2 - 1) + '*' + new string(' ', gab) + '*' + new string(' ', Radius - gab / 2 - 1);
                sb.AppendLine(line);
                gab += 2;
            }
            gab -= 2;

            while (gab >= 2)
            {
                string line = new string(' ', (Radius - gab / 2) - 1) + '*' + new string(' ', gab) + '*' + new string(' ', (Radius - gab / 2) - 1);
                sb.AppendLine(line);
                gab -= 2;
            }
            sb.AppendLine(bottom);

            return sb.ToString().TrimEnd();
        }
    }

    public class Rectangle : IDrawable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public string Draw()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('*', Width));
            for (int i = 0; i < Height - 2; i++)
            {
                string b = "*" + new string(' ', Width - 2) + "*";
                sb.AppendLine(b);
            }
            sb.AppendLine(new string('*', Width));
            return sb.ToString().TrimEnd();
        }
    }
    public class Program
    {
        static void Main()
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            Console.WriteLine(circle.Draw());
            Console.WriteLine(rect.Draw());
        }
    }
}