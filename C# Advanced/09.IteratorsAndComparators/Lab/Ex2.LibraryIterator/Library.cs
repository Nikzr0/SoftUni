using System.Collections;
using System.Collections.Generic;

namespace Ex2.LibraryIterator
{
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
}
