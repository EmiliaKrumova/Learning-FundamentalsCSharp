using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace _3._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articleArgs = Console.ReadLine().Split(", ");
                string title = articleArgs[0];
                string content = articleArgs[1];
                string autor = articleArgs[2];
                Article article = new Article(title, content, autor);
                list.Add(article);
            }
           


           
            foreach (Article article in list)
            {
                Console.WriteLine(article.ToString());

            }

            //Console.WriteLine(list.ToString());
        }
    }
    public class Article
    {
        public Article(string title, string content, string autor)
        {
            Title = title;
            Content = content;
            Autor = autor;
        }
        public string Title { get; set; }
        public string Content { get; set; }

        public string Autor { get; set; }

        
       
       
        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }
    }
}
    

