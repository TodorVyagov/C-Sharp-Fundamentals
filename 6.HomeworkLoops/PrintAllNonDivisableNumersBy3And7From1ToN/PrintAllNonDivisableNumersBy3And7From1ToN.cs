using System;

namespace PrintAllNonDivisableNumersBy3And7From1ToN
{
    class PrintAllNonDivisableNumersBy3And7From1ToN
    {
        static void Main()
        {
            //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

            Console.Write("This program prints the numbers from 1 to N that are not divisable by 3 and 7 at the same time.\nEnter N = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
