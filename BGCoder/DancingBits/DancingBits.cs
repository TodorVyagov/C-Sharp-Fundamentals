using System;

class DancingBits
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];
        string concatenatedNums = null;

        for (int i = 0; i < N; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            string currentNumber = Convert.ToString(numbers[i], 2);
            concatenatedNums += currentNumber;
        }

        int dancingBits = 0;
        bool areDancingBits = false;
        int zeroCounter = 0;
        int oneCounter = 0;

        for (int i = 0; i < concatenatedNums.Length; i++)
        {
            if (concatenatedNums[i] == '0')
            {
                if (oneCounter > K)
                {
                    dancingBits--;
                }
                oneCounter = 0;
                zeroCounter++;
            }

            if (concatenatedNums[i] == '1')
            {
                if (zeroCounter > K)
                {
                    dancingBits--;
                }
                zeroCounter = 0;
                oneCounter++;
            }

            if (zeroCounter == K || oneCounter == K)
            {
                dancingBits++;
            }

            if (i == concatenatedNums.Length - 1 && (zeroCounter > K || oneCounter > K))
            {
                dancingBits--;
            }
        }

        Console.WriteLine(dancingBits);
    }
}
