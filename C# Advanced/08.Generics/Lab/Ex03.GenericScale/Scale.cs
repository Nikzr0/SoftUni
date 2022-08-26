using System;
using System.Collections.Generic;

namespace Ex03.GenericScale
{
    public class EqualityScale<T>
    {
        public T Left { get; set; }
        public T Right { get; set; }
        public EqualityScale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public bool AreEqual()
        {
            bool result = false;

            if (Left.Equals(Right))
            {
                result = true;
            }

            return result;
        }
    }
}