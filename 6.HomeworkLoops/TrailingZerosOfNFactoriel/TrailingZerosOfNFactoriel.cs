using System;
using System.Numerics; 

namespace TrailingZerosOfNFactoriel
{
    class TrailingZerosOfNFactoriel
    {
        static void Main()
        {
            //* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	        //N = 10 -> N! = 3628800 -> 2
	        //N = 20 -> N! = 2432902008176640000 -> 4
	        //Does your program work for N = 50 000?

            Console.WriteLine("This program for given N how many trailing zeros present at the end of the number N!");
            int N;
            do
            {
                Console.Write("Enter N = ");
                N = int.Parse(Console.ReadLine());
            } while (N < 0);
            BigInteger factoriel = 1;
            int counter = 0;
            for (int i = 1; i <= N; i++)
            {
                factoriel *= i;
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("{0}! = {1}", N, factoriel);
            Console.WriteLine("There are {0} trailing Zeros in {1}!.", counter, N); //for N = 50 000 there are 10 000 trailing Zeros...

        }
    }
}
