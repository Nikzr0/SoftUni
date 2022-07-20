using System;
using System.Collections.Generic;
using System.Linq;

class Article
{
    private string title_;
    private string content_;
    private string author_;

    public string Title
    {
        get
        {
            return title_;
        }
        set
        {
            title_ = value;
        }

    }
    public string Content
    {
        get
        {
            return content_;
        }
        set
        {
            content_ = value;
        }

    }
    public string Author
    {
        get
        {
            return author_;
        }
        set
        {
            author_ = value;
        }

    }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

class Program
{
    static void Main()
    {
        List<Article> articles = new List<Article>();// List<Title, Content, Author> articles = ...

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] initialArticle = Console.ReadLine().Split(", ");
            Article article = new Article(initialArticle[0], initialArticle[1], initialArticle[2]); // title, content, author
            articles.Add(article);

        }

        string criteria = Console.ReadLine();

        switch (criteria)
        {
            case "title":
                articles = articles.OrderBy(x => x.Title).ToList();
                break;

            case "content":
                articles = articles.OrderBy(x => x.Content).ToList();
                break;

            case "author":
                articles = articles.OrderBy(x => x.Author).ToList();
                break;
        }

        Console.WriteLine();
        foreach (var item in articles)
        {
            Console.WriteLine(item);
        }
    }
}