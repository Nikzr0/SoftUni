using System;
using System.Collections;
using System.Collections.Generic;

namespace Ex03.ComparableBook
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public Book()
        {
            Authors = new List<string>();
        }
        public Book(string title, int year, List<string> authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public int CompareTo(Book other)
        {
            if (Year > other.Year)
            {
                return 1;
            }
            else if (Year < other.Year)
            {
                return -1;
            }
            else
            {
                return Title.CompareTo(other.Title);
            }
        }
    } 

    public class Library : IEnumerable<Book>
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

        public void Sort()
        {
            books.Sort();
        }

        public IEnumerator<Book> GetEnumerator() // Just calls the thing which moves through the books
        {
            //for (int i = 0; i < books.Count; i++)
            //{
            //    yield return books[i];
            //}
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class LibraryIterator : IEnumerator<Book> // The thing which moves through the books
    {
        private List<Book> books;

        private int index;

        public LibraryIterator(List<Book> books)
        {
            this.books = books;
            index = -1;
        }
        public Book Current => books[index];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            index++;
            return index < books.Count;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose()
        {

        }
    }

    internal class Program
    {
        static void Main()
        {
            Library library = new Library();
            library.Add(new Book("Bible", 12, new List<string>() { "fdas" }));
            library.Add(new Book("A", 233, new List<string>() { "asabgd" }));
            library.Add(new Book("B", 3, new List<string>() { "asd" }));
            library.Add(new Book("C", 43, new List<string>() { "asd", "qwqf" }));
            library.Sort();
            foreach (var book in library)
            {
                Console.WriteLine($"{book.Title} - {book.Year} - {string.Join(" & ", book.Authors)}");
            }
        }
    }
}
