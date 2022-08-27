using System.Collections.Generic;
using System.Text;

namespace Ex03.GenericSwapMethodStrings
{
    public partial class Program
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
    }
}