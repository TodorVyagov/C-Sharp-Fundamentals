using System;

namespace DeclareFiveVariables
{
    class DeclareFiveVariables
    {
        static void Main()
        {
            ushort number1 = 52130;
            sbyte number2 = -115;
            int number3 = 4825932;
            byte number4 = 97; //sbyte is also suitable
            short number5 = -10000;
            Console.WriteLine("Most appropriate integer type for number {0} is ushort.", number1);
            Console.WriteLine("Most appropriate integer type for number {0} is sbyte.", number2);
            Console.WriteLine("Most appropriate integer type for number {0} is int.", number3);
            Console.WriteLine("Most appropriate integer type for number {0} is byte or sbyte(I used byte).", number4);
            Console.WriteLine("Most appropriate integer type for number {0} is short.", number5);
        }
    }
}
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
