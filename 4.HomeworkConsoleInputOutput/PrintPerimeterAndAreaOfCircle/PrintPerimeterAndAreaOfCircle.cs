using System;

namespace PrintPerimeterAndAreaOfCircle
{
    class PrintPerimeterAndAreaOfCircle
    {
        static void Main()
        {
            //Write a program that reads the radius r of a circle and prints its perimeter and area.


            Console.Write("Enter radius of the circle in cm: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Perimeter of circle with radius {0}cm is {1:0.00} cantimeters.\nArea of circle with radius {0} is {2:0.00} square cantimeters.", radius, perimeter, area);
        }
    }
}
