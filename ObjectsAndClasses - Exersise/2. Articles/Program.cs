using System;

namespace _2._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleArgs = Console.ReadLine().Split(", ");
            string title = articleArgs[0];
            string content = articleArgs[1];
            string autor = articleArgs[2];
            Article article = new Article(title, content, autor);


            int numberOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfChanges; i++)
            {
                string[]command = Console.ReadLine().Split(": ");
                string realCmd = command[0];
                if (realCmd == "Edit")
                {
                    string newContent = command[1];
                    article.EditMethod(newContent);
                }else if (realCmd == "ChangeAuthor")
                {
                    string newAutor = command[1];
                    article.ChangeAutor(newAutor);
                }else if(realCmd == "Rename")
                {
                    string newTitle = command[1];
                    article.Rename(newTitle);
                }
            }
            Console.WriteLine(article.ToString());
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

        public void EditMethod (string newContent)
        {
            Content = newContent;
        }
        public void ChangeAutor (string newAutor)
        {
            Autor = newAutor;
        }
        public void Rename(string newName)
        {
            Title = newName;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }
    }
}
