using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(',', ' ')
                .ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] token = command.Split(',',' ');
                string action = token[0];

                if (action == "Add")
                {
                    string lessonTitle = token[1];
                    bool containsLesson = lessons.Contains(token[1]);
                    if (!containsLesson)
                    {
                        lessons.Add(lessonTitle);
                    }
                    else if (containsLesson)
                    {
                        continue;
                    }
                }
                else if (action == "Insert")
                {
                    string lessonTitle = token[1];
                    int index = int.Parse(token[2]);
                    bool containsLesson = lessons.Contains(token[1]);
                    if (!containsLesson)
                    {
                        lessons.Insert(index, lessonTitle);
                    }
                    else if (containsLesson)
                    {
                        continue;
                    }
                }
                else if (action == "Remove")
                {
                    string lessonTitle = token[1];
                    bool containsLesson = lessons.Contains(token[1]);
                    if (!containsLesson)
                    {
                        lessons.Remove(lessonTitle);
                    }
                    else if (containsLesson)
                    {
                        continue;
                    }
                }
                else if (action == "Swap")
                {

                }
            }
        }
    }
}
