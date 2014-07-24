using System;

namespace RootsOfQuadraticEquation
{
    class RootsOfQuadraticEquation
    {
        static void Main()
        {
            //Write a program that enters the coefficients a, b and c of a quadratic equation a*x^2 + b*x + c = 0 
            //and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
            Console.Write("Enter coefficients of  quadratic equation ax^2+bx+c=0:\na= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());
            double discriminant = (b * b) - (4 * a * c);
            if (discriminant <= 0)
            {
                if (discriminant == 0)
                {
                    double rootX = -b / (2 * a);
                    Console.WriteLine("There is one real root x= {0}", rootX);
                }
                else
                {
                    Console.WriteLine("The equation hasn't real roots.");
                }
            }
            else
            {
                double rootX1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                double rootX2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine("Roots of {0}x^2{3}{1}x{4}{2} are x1={5:0.00} and x2={6:0.00}", a, b, c, (b < 0) ? "" : "+", (c < 0) ? "" : "+", rootX1, rootX2);
            }

        }
    }
}
