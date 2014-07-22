using System;

namespace CompareNumbers
{
    class CompareNumbers
    {
        static void Main()
        {
            float numberA = 2.114f;
            float numberB = 2.113f;
            bool equalAB = (numberA == numberB);
            Console.WriteLine("True or False\n{0} is equal to {1} - {2}", numberA, numberB, equalAB); //False

            float numberC = 2.111111f;
            float numberD = 2.111112f;
            bool equalCD = (numberC == numberD);
            Console.WriteLine("{0} is equal to {1} - {2}", numberC, numberD, equalCD); //False

            float numberE = 2.1111111113f;
            float numberF = 2.1111111119f;
            bool equalEF = (numberE == numberF);
            Console.WriteLine("{0} is equal to {1} - {2}", numberE, numberF, equalEF);
            //True, because float recognizes 7 symbols and in numberE and numberF it cuts last 4 digits. float does not care what we have behind the 7-th digit.
            //I found many ways to solve this problem, but this is the easiest.
        }
    }
}
//Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true
