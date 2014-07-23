using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

            Console.Write("Enter coefficients of  quadratic equation ax^2+bx+c=0:\na= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - (4 * a * c);
            if (discriminant <= 0)
            {
                if (discriminant == 0)
                {
                    double rootx = -b / (2 * a);
                    Console.WriteLine("There is one real root x= {0:0.00}", rootx);
                }
                else
                {
                    Console.WriteLine("The equation hasn't real roots.");
                }
            }
            else
        	{
                double rootx1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                double rootx2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine("Roots of {0}x^2{3}{1}x{4}{2} are x1={5:0.00} and x2={6:0.00}", a, b, c, (b < 0) ? "" : "+", (c < 0) ? "" : "+", rootx1, rootx2);
            }
        }
    }
}

