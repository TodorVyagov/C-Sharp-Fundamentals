using System;

namespace CheckIfPointIsWithinACircle
{
    class CheckIfPointIsWithinACircle
    {
        static void Main()
        {
            Console.Write("Enter X coordinates: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinates: ");
            float y = float.Parse(Console.ReadLine());
            //We use the Pythagorean theorem for right triangle: a*a + b*b = c*c. We have C=5, and x=a, y=b.
            Console.Write("The point you entered({0}, {1}) is ", x, y);
            Console.WriteLine((x * x + y * y) < 5 * 5 ? "within the circle." : "outside the circle.");
        }
    }
}
