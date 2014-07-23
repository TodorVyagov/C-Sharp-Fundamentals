using System;

namespace CalculateSumWithAccuracy
{
    class CalculateSumWithAccuracy
    {
        static void Main()
        {
            //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

            decimal accuracyNumber = 1;
            for (int i = 0; i < 1500; i++) //I've tried numbers up to 1/100000, but for 0.001 accuracy we need not more than 1/1500. 
            {                              //If we use i < 100000 the result will be the same(the result will be the same also if we use numbers up to 1/Infinity).
                if (i % 2 == 0)
                {
                    accuracyNumber = accuracyNumber + 1.0m / (i + 2);
                }
                else
                {
                    accuracyNumber = accuracyNumber - 1.0m / (i + 2);
                }
            }
            Console.WriteLine("1 + 1/2 - 1/3 + 1/4 - 1/5 + ... + 1/Infinity = {0:0.000}", accuracyNumber);
        }
    }
}

