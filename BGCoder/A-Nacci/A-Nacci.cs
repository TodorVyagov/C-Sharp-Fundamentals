using System;

namespace A_Nacci
{
    class ANacci
    {
        static void Main()
        {
            char firstElement = char.Parse(Console.ReadLine());
            char secondElement = char.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int numberOfElements = L * 2;
            char[] aNacci = new char[numberOfElements];

            aNacci[0] = firstElement;
            aNacci[1] = secondElement;

            for (int i = 2; i < numberOfElements; i++)
            {
                int sum = (aNacci[i - 2] - 64) + (aNacci[i - 1] - 64);
                if (sum <= 26)
                {
                    aNacci[i] = (char)(sum + 64);
                }
                else
                {
                    aNacci[i] = (char)((sum % 26) + 64);
                }
            }
            int counter = 0;
            for (int i = 0; i < L; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(aNacci[counter]);
                    continue;
                }
                counter++;
                Console.Write(aNacci[counter]);
                Console.Write(new string(' ', (i - 1)));
                counter++;
                Console.WriteLine(aNacci[counter]);
            }



        }
    }
}
