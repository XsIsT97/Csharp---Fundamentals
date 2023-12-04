using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int returnedSum = returneSumOfN1andN2(number1, number2);
            Console.WriteLine(SubtractMetod(returnedSum, number3));

        }

        static int returneSumOfN1andN2(int number1, int number2)
        {
            int sum = 0;
            sum = number1 + number2;
            return sum;
        }

        static int SubtractMetod(int returnedSum, int number3)
        {
            int newTotalSum = 0;
            newTotalSum = returnedSum - number3;
            return newTotalSum;
        }
    }
}
