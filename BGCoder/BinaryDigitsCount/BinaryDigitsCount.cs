using System;

namespace BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main()
        {
            char digit = char.Parse(Console.ReadLine());
            int countOfInputNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfInputNumbers; i++)
            {
                int counter = 0;
                uint checkingNumber = uint.Parse(Console.ReadLine());
                char[] binaryRepresentation = Convert.ToString(checkingNumber, 2).ToCharArray();
                for (int j = 0; j < binaryRepresentation.Length; j++)
                {
                    if (binaryRepresentation[j] == digit)
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
            }
        }
    }
}
