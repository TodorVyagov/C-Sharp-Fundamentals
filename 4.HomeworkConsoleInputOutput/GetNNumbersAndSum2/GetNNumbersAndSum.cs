using System;

namespace GetNNumbersAndSum
{
    class GetNNumbersAndSum
    {
        static void Main()
        {
            //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

            Console.Write("Enter how many numbers you want to sum: ");
            int n = int.Parse(Console.ReadLine());
            int number;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number {0}: ", i);
                number = int.Parse(Console.ReadLine());
                sum = sum + number; //sum += number
            }
            Console.WriteLine("Sum of your numbers is = {0}", sum);
        }
    }
}
