using System;

namespace ReadThreeIntegers
{
    class ReadThreeIntegers
    {
        static void Main()
        {
            //Write a program that reads 3 integer numbers from the console and prints their sum.

            Console.Write("Enter Three Integer Numbers and I will sum them:\na= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of your three numbers is = {0}", a + b + c);
        }
    }
}
