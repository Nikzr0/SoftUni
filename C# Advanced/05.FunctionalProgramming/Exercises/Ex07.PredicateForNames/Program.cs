using System;
using System.Linq;

namespace Ex07.PredicateForNames
{
    internal class Program
    {
        static void Main()
        {
            Func<string, int, bool> nameFilter = (x, y) => x.Length <= y;
            int maxLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ").Where(x => nameFilter(x, maxLength)).ToArray();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}