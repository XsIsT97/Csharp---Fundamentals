using System;
using System.Linq;

namespace _02._Articles
{
    class Article
    {
        public Article(string edit, string changeAuthor, string rename)
        {
            this.Content = edit;
            this.Author = changeAuthor;
            this.Title = rename;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string numberOfCommands = Console.ReadLine();

            string[] command = numberOfCommands
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 1; i <= numberOfCommands.Length; i++)
            {
                string actions = command[0];
                string change1 = command[1];
                string change2 = command[2];

                Article article = new Article(actions, change1, change2);

                if (actions == "Edit:")
                {
                    
                }
                else if (actions == "ChangeAuthor:")
                {
                    
                }
                else if (actions == "Rename:")
                {
                    
                }
            }
        }
    }
}
