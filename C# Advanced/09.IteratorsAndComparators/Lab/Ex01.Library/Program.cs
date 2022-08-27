﻿using System.Collections.Generic;

namespace Ex01.Library
{
    public class Library  
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Remove(Book book)
        {
            books.Remove(book);
        }
    }

    public class Program
    {
        static void Main()
        {
            Library library = new Library();
            library.Add(new Book("Bible", 1605, new List<string>() { "fdas" }));
            library.Add(new Book("A", 1705, new List<string>() { "asabgd" }));
            library.Add(new Book("B", 1805, new List<string>() { "asd" }));
            library.Add(new Book("C", 1905, new List<string>() { "asd", "qwqf" }));
        }
    }
}