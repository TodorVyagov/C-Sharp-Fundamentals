using System;

namespace PrintNumbersFrom1ToN
{
    class PrintNumbersFrom1ToN
    {
        static void Main()
        {
            //Write a program that prints all the numbers from 1 to N.

            Console.Write("This program prints the numbers from 1 to N.\nEnter N = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
