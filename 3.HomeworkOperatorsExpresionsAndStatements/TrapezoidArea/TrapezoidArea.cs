using System;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main()
        {
            Console.Write("Enter side \"a\" of the trapezoid in cm: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter side \"b\" of the trapezoid in cm: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter height \"h\" of the trapezoid in cm: ");
            int h = int.Parse(Console.ReadLine());
            double area = (double)(a + b) * h / 2;
            Console.WriteLine("trapezoid's area is {0} square cantimeters.", area);
        }
    }
}
//Write an expression that calculates trapezoid's area by given sides a and b and height h