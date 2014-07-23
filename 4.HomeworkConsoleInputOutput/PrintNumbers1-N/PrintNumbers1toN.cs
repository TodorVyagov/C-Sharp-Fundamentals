using System;

namespace PrintNumbers1toN
{
    class PrintNumbers1toN
    {
        static void Main()
        {
            //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

            Console.Write("Enter how many numbers to print - from 1 to: ");
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ",number);
                number++;                       
            }
        }
    }
}