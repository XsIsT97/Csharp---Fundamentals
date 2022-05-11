using System;

namespace NthMemberSequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Solve(n));
            Console.WriteLine(SolveRecursevely(n));
        }

        public static double Solve(int n)
        {
            double n1 = 4 / 3.0;
            double n2 = 3;
            double n3 = 4;
            if (n == 1) return n1;
            if (n == 2) return n2;
            if (n == 3) return n3;
            double nth = 0;
            for (int i = 4; i <= n; i++)
            {
                nth = n3 + 2 * n2 - 8 * n1;
                n1 = n2;
                n2 = n3;
                n3 = nth;
            }
            return nth;
        }

        public static double SolveRecursevely(int n)
        {
            if (n == 1) return 4 / 3.0;
            if (n == 2) return 3;
            if (n == 3) return 4;
            return SolveRecursevely(n - 1) + 2 * SolveRecursevely(n - 2) - 8 * SolveRecursevely(n - 3);
        }
    }
}