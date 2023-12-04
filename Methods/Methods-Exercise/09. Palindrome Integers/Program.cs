using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberRead = Console.ReadLine();
            CheckIfISPalindrome(numberRead);
        }
        static void CheckIfISPalindrome(string numberRead)
        {
            bool isPalindrome = false;

            while (numberRead != "END")
            {
                for (int i = 0; i < numberRead.Length / 2; i++)
                {
                    if (numberRead[i] == numberRead[numberRead.Length - 1])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                        Console.WriteLine("false");
                        break;
                    }
                    int num = int.Parse(numberRead);
                    num /= 10;
                    numberRead = num.ToString();
                }
                if (isPalindrome)
                {
                    Console.WriteLine("true");
                }
                numberRead = Console.ReadLine();
            }
        }
    }
}
