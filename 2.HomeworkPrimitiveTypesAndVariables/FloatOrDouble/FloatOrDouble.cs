using System;

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            double number1 = 34.567839023;
            float  number2 = 12.345f;
            double number3 = 8923.1234857;
            float  number4 = 3456.091f;
            Console.WriteLine("float is suitable for numbers {1} and {3}.\ndouble - for {0} and {2}", number1, number2, number3, number4);
        }
    }
}
//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
