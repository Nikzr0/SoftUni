using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        public int Count { get; private set; }

        public List<T> boxes;

        public Box()
        {
            boxes = new List<T>();
        }
        public void Add(T element)
        {
            boxes.Add(element);
            Count++;
        }

        public T Remove()
        {
            boxes.Remove(boxes[Count - 1]);
            Count--;
            return boxes[Count - 1];
        }
    }
}