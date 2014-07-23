using System;

namespace HowManyNumbersDivideByFive
{
    class HowManyNumbersDivideByFive
    {
        static void Main()
        {
            //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.


            Console.Write("Enter two positive integers. I will find how many numbers between them can be divided by five without remainder.\nFirst number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int second = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = first; i <= second; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    p++;
                }
            }
            Console.WriteLine(p != 1 ? "There are {0} numbers between {1} and {2} that can be divided by 5." : "There is {0} number between {1} and {2} that can be divided by 5.", p, first, second);
        }
    }
}
