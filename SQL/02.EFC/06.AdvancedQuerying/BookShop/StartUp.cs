namespace BookShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using BookShop.Models;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using Z.EntityFramework.Plus;
    using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

    public class StartUp
    {
        public static void Main()
        {
            var db = new BookShopContext();
            db.Database.EnsureCreated();
            //db.Database.Migrate();

            //string ex1 = GetBooksByAgeRestriction(db, "miNor");
            //string ex2 = GetGoldenBooks(db);
            //string ex3 = GetBooksByPrice(db);
            //string ex4 = GetBooksNotReleasedIn(db, 1);
            //string ex5 = GetBooksReleasedBefore(db, 1);
            //string ex6 = GetBooksByCategory(db, 1);
            //string ex7 = GetBooksReleasedBefore(db, "12-04-1992");
            //string ex8 = GetAuthorNamesEndingIn(db, "a");
            //string ex9 = GetBookTitlesContaining(db, "my");
            //string ex10 = GetBooksByAuthor(db, "t");
            //int ex11 = CountBooks(db, 1);
            //Console.WriteLine($"There are {ex11} books with longer title than {1} symbols");
            //string ex12 = CountCopiesByAuthor(db);
            //string ex13 = GetTotalProfitByCategory(db);
            //string ex14 = GetMostRecentBooks(db);
            //EX 15 IncreasePrices(db);
            //EX 16 Console.WriteLine(RemoveBooks(db));

        }

        public static string GetBooksByAgeRestriction(BookShopContext db, string command)
        {
            StringBuilder sb = new StringBuilder();
            var ageResteiction = Enum.Parse<AgeRestriction>(command, true);
            var resultTitles = db.Books
                .Select(x => new
                {
                    BookTitle = x.Title,
                    AgeRestriction = x.AgeRestriction
                })
                .Where(x => x.AgeRestriction == ageResteiction)
                .OrderBy(x => x.BookTitle)
                .ToList();

            foreach (var title in resultTitles)
            {
                sb.AppendLine($"{title.BookTitle}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetGoldenBooks(BookShopContext db)
        {

            StringBuilder sb = new StringBuilder();

            var resultTitles = db.Books
                .Where(x => x.Copies >= 5000)
                 .OrderBy(x => x.BookId)
                .Select(x => new
                {
                    BookTitle = x.Title
                }).ToList();

            foreach (var title in resultTitles)
            {
                sb.AppendLine($"{title.BookTitle}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetBooksByPrice(BookShopContext db)
        {
            StringBuilder sb = new StringBuilder();

            var booksOver40lv = db.Books
                .Select(x => new
                {
                    BookTitle = x.Title,
                    Price = x.Price,
                })
                .Where(x => x.Price > 40)
                .OrderByDescending(x => x.Price)
                .ToList();

            foreach (var book in booksOver40lv)
            {
                sb.AppendLine($"{book.BookTitle} - ${book.Price}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetBooksNotReleasedIn(BookShopContext db, int year)
        {
            StringBuilder sb = new StringBuilder();

            var booksOver40lv = db.Books
                 .Where(x => x.ReleaseDate.Value.Year != 2000)
                .Select(x => new
                {
                    BookTitle = x.Title,
                    Price = x.Price,
                })
                .OrderByDescending(x => x.Price)
                .ToList();

            foreach (var book in booksOver40lv)
            {
                sb.AppendLine($"{book.BookTitle} - ${book.Price}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetBooksByCategory(BookShopContext db, string input)
        {
            StringBuilder sb = new StringBuilder();
            // instead of console.readline
            var listOfCAtegoris = new List<string>() { "horror", "mystery", "drama" };

            var booksByCategories = db.Books
                .Select(x => new
                {
                    Title = x.Title,
                    Categories = x.BookCategories.Select(y => y.Category.Name.ToLower()).ToList()
                })
                .Where(x => x.Categories.All(y => listOfCAtegoris.Contains(y)))
                .OrderBy(x => x.Title)
                .ToList();


            foreach (var book in booksByCategories)
            {
                sb.AppendLine($"{book.Title}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetBooksReleasedBefore(BookShopContext db, string date)
        {
            StringBuilder sb = new StringBuilder();
            var booksBefore = db.Books
                .Where(x => x.ReleaseDate.Value > DateTime.Parse(date))
                .Select(x => new
                {
                    ReleaseDate = x.ReleaseDate,
                    Title = x.Title,
                    EditionType = x.EditionType,
                    Price = x.Price
                })
                .OrderByDescending(y => y.ReleaseDate)
                .ToList();

            foreach (var book in booksBefore)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price}");
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetAuthorNamesEndingIn(BookShopContext context, string partOfName)
        {
            var authorsWithEndName = context.Authors
                .Where(x => x.FirstName.EndsWith(partOfName))
                .Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName
                })
                .OrderBy(x => x.FullName)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var author in authorsWithEndName)
            {
                sb.AppendLine($"{author.FullName}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            input = input.ToLower();

            var books = context.Books
                .Where(x => x.Title.ToLower().Contains(input))
                .Select(x => new { Title = x.Title })
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var b in books)
            {
                sb.AppendLine($"{b.Title}");
            }

            return sb.ToString().TrimEnd();

            //return String.Join(Environment.NewLine, books);
        }
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            input = input.ToLower();

            var authorsWithBooks = context.Authors
                .Where(x => x.LastName.ToLower().StartsWith(input))
                .Select(x => new
                {
                    AuthorFullName = x.FirstName + " " + x.LastName,
                    Book = x.Books.Select(x => new
                    {
                        Title = x.Title
                    }).ToList()
                }).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var awb in authorsWithBooks)
            {
                foreach (var bTitle in awb.Book)
                {
                    sb.AppendLine($"{bTitle.Title} ({awb.AuthorFullName})");
                }
            }

            return sb.ToString().TrimEnd();
        }
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var numberOfBooks = context.Books
                .Where(x => x.Title.Length > lengthCheck)
                .Count();

            return numberOfBooks;
        }
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authorsBooksCopies = context.Authors
                 .Select(x => new
                 {
                     AuthorFullName = x.FirstName + " " + x.LastName,
                     TotalCopies = x.Books.Sum(y => y.Copies)
                 })
                 .OrderByDescending(x => x.TotalCopies)
                 .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var author in authorsBooksCopies)
            {
                sb.AppendLine($"{author.AuthorFullName} - {author.TotalCopies}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetTotalProfitByCategory(BookShopContext db)
        {
            var profitByCategory = db.Categories
                            .Select(x => new
                            {
                                CategoryName = x.Name,
                                TotalProfit = x.CategoryBooks.Select(cb => cb.Book.Copies * cb.Book.Price).Sum()
                            })
                            .OrderByDescending(x => x.CategoryName)
                            .ThenBy(x => x.CategoryName)
                            .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var category in profitByCategory)
            {
                sb.AppendLine($"{category.CategoryName} ${category.TotalProfit:f2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categories = context.Categories
                .Select(x => new
                {
                    x.Name, // CategoryName
                    Books = x.CategoryBooks
                                .Select(cb => new
                                {
                                    BookTitle = cb.Book.Title,
                                    BookReleaseDate = cb.Book.ReleaseDate
                                }).OrderByDescending(b => b.BookReleaseDate).Take(3)
                })
                .OrderBy(x => x.Name)
                .ToList();

            StringBuilder output = new StringBuilder();

            foreach (var category in categories)
            {
                output.AppendLine($"--{category.Name}");

                foreach (var book in category.Books)
                {
                    output.AppendLine($"{book.BookTitle} ({book.BookReleaseDate.Value.Year})");
                }
            }

            return output.ToString().TrimEnd();
        }
        public static void IncreasePrices(BookShopContext context)
        {
            var booksReleasedBefore2010 = context.Books
               .Where(x => x.ReleaseDate.Value.Year < 2010 || x.ReleaseDate.Value.Year == null)
               .ToList();

            for (int i = 0; i < booksReleasedBefore2010.Count; i++)
            {
                booksReleasedBefore2010[i].Price += 5;
            }

            context.SaveChanges();
        }
        public static int RemoveBooks(BookShopContext context)
        {
            int numberOfDeletedBooks = context.Books
                .Where(x => x.Copies < 4200).Count();

            var booksWithLittleCopies = context.Books
          .Where(x => x.Copies < 4200).Delete();           

            context.SaveChanges();

            return numberOfDeletedBooks;
        }
    }
}
