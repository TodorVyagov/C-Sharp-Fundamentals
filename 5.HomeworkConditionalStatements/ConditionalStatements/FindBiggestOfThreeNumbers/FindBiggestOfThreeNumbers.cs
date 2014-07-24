using System;

namespace FindBiggestOfThreeNumbers
{
    class FindBiggestOfThreeNumbers
    {
        static void Main()
        {
            //Write a program that finds the biggest of three integers using nested if statements.

            Console.Write("Enter three integer numbers and I will find the biggest one:\na = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            if (a != b && a != c && b != c)
            {
                if (a > b)
                {
                    if (a > c)
                    {
                        Console.WriteLine("a is the biggest number!");
                    }
                }
                if (b > a)
                {
                    if (b > c)
                    {
                        Console.WriteLine("b is the biggest number!");
                    }
                }
                if (c > a)
                {
                    if (c > b)
                    {
                        Console.WriteLine("c is the biggest number!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Some of your numbers are equal!");
            }
        }
    }
}
