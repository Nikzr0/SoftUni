using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomDoublyLinkedList
{
    class Program
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);

            list.RemoveFirst();
            list.RemoveLast();
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}