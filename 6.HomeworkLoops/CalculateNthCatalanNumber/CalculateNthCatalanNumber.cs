//Write a program to calculate the Nth Catalan number by given N.
//I'm using method because otherwise I will have to repeat three times the same loop with different variables.

using System;
using System.Numerics;

namespace CalculateNthCatalanNumber
{
    class CalculateNthCatalanNumber
    {
        static BigInteger CalculateFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void Main()
        {
            Console.WriteLine("This program calculates the Nth Catalan number by given N.\nCn = (2n)! / ((n+1)!*n!).");
            int N;
            do
            {
                Console.Write("Enter N = ");
                N = int.Parse(Console.ReadLine());
            } while (N < 0);

            Console.Write("{0}-th Catalan number = ", N);
            Console.WriteLine(CalculateFactorial(2 * N) / (CalculateFactorial(N + 1) * CalculateFactorial(N)));
        }
    }
}
