using System.Collections.Generic;

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
}