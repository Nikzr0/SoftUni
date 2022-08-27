using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06.GenericCountMethodDoubles
{
    public static class GetCountClass
    {
        public static int GetCountGreaterThan<T>(List<T> list, T element)
       where T : IComparable<T>
        {
            //int count = 0;
            //foreach (T item in list)
            //{
            //    if (item.CompareTo(element) > 0)
            //    {
            //        count++;
            //    }
            //}
            return list.Count(x => x.CompareTo(element) > 0);
        }
    }
}