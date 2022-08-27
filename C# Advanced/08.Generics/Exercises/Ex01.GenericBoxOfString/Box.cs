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
                sb.AppendLine($"{typeof(T)}: {element}");
            }

            return sb.ToString();

        }
    }
}