using System;

namespace GetNNumbersAndSum
{
    class GetNNumbersAndSum
    {
        static void Main()
        {
            Console.Write("Enter how many numbers you want to sum: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.Write("Enter 1-st number: ");
                    numbers[i - 1] = int.Parse(Console.ReadLine());
                }
                else if (i == 2)
                {
                    Console.Write("Enter 2-nd number: ");
                    numbers[i - 1] = int.Parse(Console.ReadLine());
                }
                else if (i == 3)
                {
                    Console.Write("Enter 3-rd number: ");
                    numbers[i - 1] = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Enter {0}-th number: ", i);
                    numbers[i - 1] = int.Parse(Console.ReadLine());
                }
                sum = sum + numbers[i - 1];
            }
            //This prints elements of the array
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Number {0} is {1}", i, numbers[i]);
            //}
            Console.WriteLine("Sum of you numbers is = : {0}", sum);
        }
    }
}
//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
