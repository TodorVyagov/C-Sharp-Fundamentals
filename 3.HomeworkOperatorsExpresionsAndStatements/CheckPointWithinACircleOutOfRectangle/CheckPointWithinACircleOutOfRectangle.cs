using System;

namespace CheckPointWithinACircleOutOfRectangle
{
    class CheckPointWithinACircleOutOfRectangle
    {
        static void Main()
        {
            //They gave us the top left corner (-1;1), so coordinates of 4 points of the rectangle are (-1;-1), (5;-1), (5;1), (-1;1). 
            Console.Write("Enter coordinates of X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinates of Y: ");
            double y = double.Parse(Console.ReadLine());
            int inRectangle = 0;
            int inCircle = 0;
            if ((x >= -1 && x <= 5) && (y >= -1 && y <= 1)) //this is how we check if the point is in the rectangle
            {
                inRectangle++;
            }
            if (Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= 9) //this is how we check if the point is in the circle
            {
                inCircle++;
            }

            if ((inCircle > 0) && (inRectangle == 0)) //This is the condition we are looking for(in the circle and out of the rectangle).
            {
                Console.WriteLine("The point({0};{1}) is in the circle and out of the rectangle.", x, y);
            }
            else
            {
                Console.WriteLine("The point does not meet the conditions to be in the circle and out of the rectangle.");
                //It is easy to say if the point is in the circle and in the rectangle, and all other cases, but it is not necessary.
            }
        }
    }
}
//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
