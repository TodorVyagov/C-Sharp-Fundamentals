using System;

namespace AssignNull
{
    class AssignNull
    {
        static void Main()
        {
            int? var1 = null;
            double? var2 = null;
            int var3 = 1000;
            Console.WriteLine("This is{0}{1}days.", var1, var2); //prints nothing, not even an interval
            var1 = var1 + null;
            var2 = var2 + var3;
            Console.WriteLine("This is{0}{1}days.", var1, var2); //prints again nothing, not even an interval, so null + number = null
        }
    }
}
//Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.
