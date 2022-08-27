using System;
using System.Collections.Generic;

namespace Ex2.LibraryIterator
{
    public class Program
    {
        static void Main()
        {
            Library library = new Library();
            library.Add(new Book("Bible", 1605, new List<string>() { "fdas" }));
            library.Add(new Book("A", 1705, new List<string>() { "asabgd" }));
            library.Add(new Book("B", 1805, new List<string>() { "asd" }));
            library.Add(new Book("C", 1905, new List<string>() { "asd", "qwqf" }));

            foreach (var book in library)
            {
                Console.WriteLine($"{book.Title} - {book.Year} - {string.Join(" & ", book.Authors)}");
            }
        }
    }
}
