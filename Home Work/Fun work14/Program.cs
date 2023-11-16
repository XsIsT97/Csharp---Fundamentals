using System;

namespace Fun_work14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input username
            string username = Console.ReadLine();

            // Reverse the username using a for loop
            string reversedUsername = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                reversedUsername += username[i];
            }

            int attempts = 0;

            // Input and check passwords
            while (true)
            {
                string password = Console.ReadLine();

                if (password == reversedUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    attempts++;

                    if (attempts == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
