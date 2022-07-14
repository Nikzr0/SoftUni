using System;

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

    public void Edit(string content)
    {
        Content = content;
    }

    public void ChangeAuthor(string authorName)
    {
        Author = authorName;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
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
        string[] initialArticle = Console.ReadLine().Split(", ");
        Article article = new Article(initialArticle[0], initialArticle[1], initialArticle[2]);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(": ");

            switch (input[0])
            {
                case "Edit":
                    article.Edit(input[1]);
                    break;

                case "ChangeAuthor":
                    article.ChangeAuthor(input[1]);
                    break;

                case "Rename":
                    article.Rename(input[1]);
                    break;
            }
        }
        Console.WriteLine();
        Console.WriteLine(article);
    }
}