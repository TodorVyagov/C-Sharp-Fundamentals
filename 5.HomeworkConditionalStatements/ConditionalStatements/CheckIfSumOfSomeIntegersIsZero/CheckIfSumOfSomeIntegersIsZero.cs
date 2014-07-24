using System;

namespace CheckIfSumOfSomeIntegersIsZero
{
    class CheckIfSumOfSomeIntegersIsZero
    {
        static void Main()
        {
            //We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

            int[] numbers = new int[5];
            Console.Write("Enter five integer numbers and I will check and print if the sum of some subset of them is 0.\nNumber 1 = ");
            numbers[0] = int.Parse(Console.ReadLine());
            Console.Write("Number 2 = ");
            numbers[1] = int.Parse(Console.ReadLine());
            Console.Write("Number 3 = ");
            numbers[2] = int.Parse(Console.ReadLine());
            Console.Write("Number 4 = ");
            numbers[3] = int.Parse(Console.ReadLine());
            Console.Write("Number 5 = ");
            numbers[4] = int.Parse(Console.ReadLine());
            int sum = 0;
            //There are 26 checks for 5 numbers to check all possible combinations. 
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("{0} = 0", numbers[i + 1]);
                }
                for (int j = 0; j < 5; j++)
                {
                    if (i == j || i > j)
                    {
                        continue;
                    }
                    if (numbers[i] + numbers[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", numbers[i], numbers[j]);
                    }
                    for (int k = 0; k < 5; k++)
                    {
                        if (j == k || i > k || j > k)
                        {
                            continue;
                        }
                        if (numbers[i] + numbers[j] + numbers[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", numbers[i], numbers[j], numbers[k]);
                        }
                        for (int l = 0; l < 5; l++)
                        {
                            if (k == l || i > l || j > l || k > l)
                            {
                                continue;
                            }
                            if (numbers[i] + numbers[j] + numbers[k] + numbers[l] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[i], numbers[j], numbers[k], numbers[l]);
                            }
                            
                        }
                    }
                }
            }
            if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            }
        }
    }
}
