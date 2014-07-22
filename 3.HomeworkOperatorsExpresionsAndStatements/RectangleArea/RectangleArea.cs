using System;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            Console.Write("Enter width of the recrangle in cm: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter height of the recrangle in cm: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle's Area is {0} square cantimeters.", (width * height));
        }
    }
}
//Write an expression that calculates rectangle’s area by given width and height.
