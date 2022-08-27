using System;

namespace Ex09.CustomLinkedList
{
    public class Program
    {
        static void Main()
        {
            var list = new DoublyLinkedList<string>(); // The only place where we specify the type od datа
            list.AddFirst("Ivan");
            list.AddFirst("Eva");
            list.AddFirst("Sam");
            list.AddLast("Ela");
            list.AddFirst("Tom");
            list.AddLast("Dara");
            list.RemoveFirst();
            list.RemoveLast();

            Console.WriteLine(list.Count);
            Console.WriteLine(String.Join(" - ", list.ToArray()));
            list.ForEach(x => Console.WriteLine("-> " + x));
        }
    }
}