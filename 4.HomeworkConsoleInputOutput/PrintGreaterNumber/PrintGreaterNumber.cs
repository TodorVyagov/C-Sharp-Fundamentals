using System;

namespace PrintGreaterNumber
{
    class PrintGreaterNumber
    {
        static void Main()
        {
            //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

            Console.Write("Enter two integers. I will print the greather one below.\nFirst number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int second = int.Parse(Console.ReadLine());
            
            bool bigger = (first > second);
            if (first == second)
            {
                Console.WriteLine("You entered equal numbers.");
            }
            else
            {
                Console.Write("The greater one is ");
                Console.WriteLine(bigger == true ? first : second);
            }
        }
    }
}

