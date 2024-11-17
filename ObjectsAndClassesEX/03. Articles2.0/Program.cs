using System;
using System.Collections.Generic;

namespace _03._Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new();
            int n = int.Parse(Console.ReadLine());

            for(int i = 1 ; i <= n; i++)
            {
                string text = Console.ReadLine();

                string[] data = text.Split(", ");
                string title = data[0];
                string content = data[1];
                string author = data[2];

                Articles article = new()
                {
                    Title = title,
                    Content = content,
                    Author = author
                };
                string temp = article.ToString();
                list.Add(temp);
            }
            Console.WriteLine(string.Join($"\n", list));
        }
    }

    class Articles
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
