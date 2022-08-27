using System.Collections;
using System.Collections.Generic;

namespace Ex2.LibraryIterator
{
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
}
