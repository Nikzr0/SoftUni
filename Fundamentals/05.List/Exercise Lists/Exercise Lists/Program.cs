using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();


        string name = Console.ReadLine();

        if (list.Contains(name))
        {
            Console.WriteLine(37256);
        }
    }
}