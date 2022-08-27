using System.Collections.Generic;

namespace Ex01.Library
{
    public class Book 
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
    }
}