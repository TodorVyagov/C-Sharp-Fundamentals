using System;

namespace SequnceOfFibonacci
{
    class SequnceOfFibonacci
    {
        static void Main()
        {
            //Write a program to print the first 100 members of the sequence of Fibonacci.

            decimal[] fibonacci = new decimal[100];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < 100; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];                 
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(fibonacci[i]);
            }
        }
    }
}
