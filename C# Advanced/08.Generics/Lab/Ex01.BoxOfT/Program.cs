using System;
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

    public class StartUp
    {
        static void Main()
        {
            Box<string> box = new Box<string>();
            box.Add("as");
            box.Add("assd");
            box.Add("ass");
            Console.WriteLine(box.Remove());

            foreach (var item in box.boxes)
            {
                Console.WriteLine(item);
            }
        }
    }
}