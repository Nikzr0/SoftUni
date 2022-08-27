using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05.GenericCountMethodStrings
{
    public static class GetCount
    {
        public static int GetCountGreaterThan<T>(List<T> list, T element) where T : IComparable<T>
        {
            return list.Count(x => x.CompareTo(element) > 0);
        }
    }
}