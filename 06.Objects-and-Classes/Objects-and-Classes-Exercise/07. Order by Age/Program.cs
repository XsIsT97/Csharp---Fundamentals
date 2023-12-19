using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] firstPersone = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = firstPersone[0];
                string id = firstPersone[1];
                int age = int.Parse(firstPersone[2]);
                List<Person> existingPerson = list.FindAll(persone => persone.ID == id);
                if (existingPerson.Count > 0)
                {
                    foreach (Person item in list)
                    {
                        if (item.ID == id)
                        {
                            item.Name = name;
                            item.Age = age;
                        }
                    }
                }
                else
                {
                    list.Add(new Person { Name = name, ID = id, Age = age });
                }
                command = Console.ReadLine();
            }
            List<Person> orderedPersons = list.OrderBy(person => person.Age).ToList();
            foreach (Person item in orderedPersons)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }
}
