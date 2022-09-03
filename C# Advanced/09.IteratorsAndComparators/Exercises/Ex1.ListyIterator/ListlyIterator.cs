using System;
using System.Collections.Generic;

namespace Ex1.ListyIterator
{
    public class ListlyIterator<T>
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

        public  void Print()
        {
            if (colection.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine($"{colection[currIndex]}");
        }
    }
}