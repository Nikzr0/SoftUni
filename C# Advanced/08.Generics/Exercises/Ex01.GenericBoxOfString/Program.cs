using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01.GenericBoxOfString
{
    public class Box<T>
    {
        public List<T> Boxes;

        public Box()
        {
            Boxes = new List<T>();
        }
        public void Add(T element)
        {
            Boxes.Add(element);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T element in Boxes)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }

            return sb.ToString();

        }
    }
    public class StartUp
    {
        static void Main()
        {
            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine(box.ToString());
        }
    }
}