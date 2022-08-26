using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GenericSwapMethodStrings
{
    public class Program
    {
        public class Swaper<T>
        {
            public List<T> Items { get; private set; }

            public Swaper()
            {
                Items = new List<T>();
            }

            public void Swap(int firstIndex, int secondIndex)
            {
                T temp = Items[firstIndex];
                Items[firstIndex] = Items[secondIndex];
                Items[secondIndex] = temp;
            }

            public void Add(T element)
            {
                Items.Add(element);
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach (T element in Items)
                {
                    sb.AppendLine($"{element.GetType()}: {element}");
                }

                return sb.ToString().Trim();
            }
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Swaper<string> swapper = new Swaper<string>();

            for (int i = 0; i < n; i++)
            {
                swapper.Add(Console.ReadLine());
            }

            int[] indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            swapper.Swap(indexes[0], indexes[1]);

            Console.WriteLine(swapper.ToString());
        }
    }
}