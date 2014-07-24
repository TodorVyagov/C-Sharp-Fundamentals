using System;

namespace SignOfProductOfThreeRealNumbers
{
    class SignOfProductOfThreeRealNumbers
    {
        static void Main()
        {
            //Write a program that shows the sign (+ or -) of the product of three real numbers
            //without calculating it. Use a sequence of if statements.

            Console.Write("Enter three numbers:\na = ");
            //We need double, because Real Numbers include floating point numbers.
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (a != 0 && b != 0 && c != 0)
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    Console.WriteLine("The product a*b*c > 0 -> " + a * b * c);
                }
                else if (a > 0 && b < 0 && c < 0)
                {
                    Console.WriteLine("The product a*b*c > 0 -> " + a * b * c);
                }
                else if (a < 0 && b > 0 && c < 0)
                {
                    Console.WriteLine("The product a*b*c > 0 -> " + a * b * c);
                }
                else if (a < 0 && b < 0 && c > 0)
                {
                    Console.WriteLine("The product a*b*c > 0 -> " + a * b * c);
                }
                else
                {
                    Console.WriteLine("The product a*b*c < 0 -> " + a * b * c);
                }
            }
            else
            {
                Console.WriteLine("The product a*b*c = " + a * b * c);
            }
        }
    }
}
