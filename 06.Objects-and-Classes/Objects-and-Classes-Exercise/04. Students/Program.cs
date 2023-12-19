using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students_Ex
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public Student(string firstName, string lastName, float grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string information = Console.ReadLine();
                string[] info = information.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firtName = info[0];
                string lastName = info[1];
                float grade = float.Parse(info[2]);
                Student newStudent = new Student(firtName, lastName, grade);
                students.Add(newStudent);
            }
            
            students = students.OrderBy(student => student.Grade).ToList();
            students.Reverse();
            foreach (var item in students)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade}");
            }
        }
    }
}
