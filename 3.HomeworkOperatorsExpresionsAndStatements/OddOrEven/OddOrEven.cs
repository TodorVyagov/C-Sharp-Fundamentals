using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int evenOrOdd = int.Parse(Console.ReadLine());
            int remainder = evenOrOdd % 2;
            Console.WriteLine(remainder == 0 ? "The number you entered is even." : "The number you entered is odd."); //we can also use If, but we haven't learned the Conditional Statements, and it is recommended to use Ternary operator, because it is in the Third lesson/lecture.
        }
    }
}
