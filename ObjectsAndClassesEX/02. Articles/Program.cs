using System;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] data = text.Split(", ");
            string title = data[0];
            string content = data[1];
            string author = data[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split(": ");
                string action = commandParts[0];
                string argument = commandParts[1];

                switch (action)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
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
}
