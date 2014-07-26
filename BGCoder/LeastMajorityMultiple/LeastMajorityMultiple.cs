using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        const int N = 5;
        int[] nums = new int[N];

        for (int i = 0; i < N; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nums);
        int divisibleNumber = 0;
        bool isFoundTargetNumber = false;
        int currentDivisibleNumber = nums[N / 2];

        while (true)
        {
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                if (currentDivisibleNumber % nums[i] == 0)
                {
                    counter++;
                }
            }
            if (counter >= N / 2 + 1)
            {
                divisibleNumber = currentDivisibleNumber;
                break;
            }
            currentDivisibleNumber++;
        }
        
        //while (true)
        //{
        //    for (int i = 1; i <= ((1 << N) - 1); i++)
        //    {
        //        int counter = 0;

        //        for (int j = 0; j < N; j++)
        //        {
        //            if (((i >> j) & 1) == 1)
        //            {
        //                if (currentDivisibleNumber % nums[j] == 0)
        //                {
        //                    counter++;
        //                }
        //            }

        //            if (counter == N / 2 + 1)
        //            {
        //                divisibleNumber = currentDivisibleNumber;
        //                isFoundTargetNumber = true;
        //                break;
        //            }
        //        }
        //        if (isFoundTargetNumber)
        //        {
        //            break;
        //        }
        //    }
        //    if (isFoundTargetNumber)
        //    {
        //        break;
        //    }
        //    currentDivisibleNumber++;
        //}
        Console.WriteLine(divisibleNumber);
    }
}
