using System.Collections.Generic;
using System.Text;

namespace Ex02.GenericBoxOfInteger
{
    public partial class Program
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

    }
}