using System;
using System.Collections;
using System.Collections.Generic;

namespace Ex2.Collection
{
    public class ListlyIterator<T> : IEnumerable<T>
    {
        private List<T> colection;
        private int currIndex;
        public ListlyIterator(params T[] data)
        {
            colection = new List<T>(data);
            currIndex = 0;
        }

        public bool HasNext() => currIndex < colection.Count - 1;

        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                currIndex++;
            }

            return canMove;
        }
        public void Print()
        {
            if (colection.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine($"{colection[currIndex]}");
        }

        public void PrintAll()
        {
            Console.WriteLine(String.Join(" ", colection));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in colection) 
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
